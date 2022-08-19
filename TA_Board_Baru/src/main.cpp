#include <Dynamixel2Arduino.h> //Library untuk interface arduino dengan Dynamixel
#include <List.hpp> //Library untuk membuat list pada Arduino API
#include "ESP32SerialPortHandler.cpp" //PortHandler agar Dynamixel2Arduino dapat dipakai pada Micro ESP32  
#define DEBUG_SERIAL Serial
#define DXL_SERIAL Serial1
#define MAX_BAUD  3

TaskHandle_t Task1;
TaskHandle_t Task2;

List<int> nilai;
const uint8_t DXL_DIR_PIN = 4; //  Pin output dari ESP untuk kontrol DXL
const uint8_t DXL_RX_PIN = 16; //  RX Pin Serial1
const uint8_t DXL_TX_PIN = 17; //  TX Pin Serial1
String Input_str;
int id,Model, id_new;
uint16_t PosN,PosG,SpeedN,SpeedG,Current,nilai_Pos;
bool Torque, list_kirim,ModeKirim, ok;
const float protocol = 1.0;
uint32_t Sbaud,Sbaud_new,nilaiBaud,SpeedReal;
uint8_t nilaiP, nilaiI, nilaiD, p_gain,i_gain,d_gain, ret_delay,temp,nilaiRet,CurrentReal; 
uint32_t baud[MAX_BAUD] = {57600, 115200, 1000000};

ESP32SerialPortHandler esp_dxl_port(DXL_SERIAL, DXL_RX_PIN, DXL_TX_PIN, DXL_DIR_PIN);
Dynamixel2Arduino dxl;
using namespace ControlTableItem;
uint8_t op_mode = OP_POSITION;


#pragma region fungsi calling 

void scan_dxl() {
  nilai.removeAll(); //Membersihkan isi List saved sebelum scan Dynamixel dilakukan
  int8_t index = 0;
  int8_t found_dynamixel = 0; //variabel yang menyimpan jumlah Dynamixel yang terbaca
  dxl.setPortProtocolVersion(protocol); //Set Protocol yang dipakai yaitu protocol 1.0
    
  for(index = 0; index < 3; index++) {
    dxl.begin(baud[index]); //Mulai Scan Dynamixel dengan Baudrate sesuai dengan nilai index
    for(id = 0; id < DXL_BROADCAST_ID; id++) { //Scan Device Dynamixel yang tersambung mulai dari ID 1-255
      if(dxl.ping(id)) { //mulai task dibawah jika ada Servo dengan ID dan Baudrate dalam iterasi
        Model = dxl.getModelNumber(id);
        nilai.add(id);
        nilai.add(Model);
      }
    }      
  }
}
void List_send(){
  int *test = nilai.toArray();
  delay(100);
  for(int i =0; i<nilai.getSize();i+=2){
      Serial.println((String)"Servo" + nilai[i] + "SModel" + nilai[i+1]);
  delay(100);
  }
  delay(1000);
  Serial.println((String)"Servo999SModel999");
  free(test);
  list_kirim = true;
}
void Pchange(){
  if(op_mode != OP_POSITION){
    dxl.torqueOff(id);
    dxl.setOperatingMode((uint8_t)id, OP_POSITION);
    dxl.torqueOn(id);
  }
  dxl.writeControlTableItem(P_GAIN, id,nilaiP);
  op_mode = OP_POSITION;
}
void Ichange(){
  if(op_mode != OP_POSITION){
    dxl.torqueOff(id);
    dxl.setOperatingMode((uint8_t)id, OP_POSITION);
    dxl.torqueOn(id);
  }
  dxl.writeControlTableItem(I_GAIN, id,nilaiI);
  op_mode = OP_POSITION;
}
void Dchange(){
  if(op_mode != OP_POSITION){
    dxl.torqueOff(id);    
    dxl.setOperatingMode((uint8_t)id, OP_POSITION);
    dxl.torqueOn(id);
  }
  dxl.writeControlTableItem(D_GAIN, id,nilaiD);
  op_mode = OP_POSITION;
  
}
void ret_change(){
  dxl.torqueOff(id);    
  dxl.writeControlTableItem(RETURN_DELAY_TIME,(uint8_t)id,nilaiRet);
  dxl.writeControlTableItem(PROFILE_VELOCITY, (uint8_t)id, 0);
  dxl.torqueOn(id);
  Serial.print("Task1 running on core ");
  Serial.println(xPortGetCoreID());

}
void Serial_Flush(){  
  while(!Serial.available()){
    Serial.flush();
    }
}
void set_pos(){
  if(op_mode != OP_POSITION){
  op_mode = OP_POSITION;
  dxl.torqueOff(id);    
  dxl.setOperatingMode((uint8_t)id, OP_POSITION);
  dxl.torqueOn(id);
  }
  if(ModeKirim == false){
    dxl.writeControlTableItem(GOAL_VELOCITY, id, 50);
    dxl.setGoalPosition(id, nilai_Pos);
    PosN = dxl.getPresentPosition(id);
    
  }
  else{
    
    dxl.writeControlTableItem(GOAL_VELOCITY, 254, 50);
    dxl.setGoalPosition(254, nilai_Pos);
  }
}
void Serial_flush(){
  if(Serial.read() >= 0){
    Serial.flush();
  }
}
void set_Baud(){
  if(dxl.ping(id) == true){
    dxl.torqueOff(id);
    dxl.setBaudrate(Sbaud, Sbaud_new);
    dxl.setOperatingMode((uint8_t)id, OP_POSITION);
    dxl.torqueOn(id);
    delay(100);
    Sbaud = Sbaud_new;
    
  }
}
void set_ID(){
  if(dxl.ping(id) == true){
    dxl.torqueOff(id);
    dxl.setID(id, id_new);
    dxl.torqueOn(id_new);
    delay(100);
    for(int i =0; i<nilai.getSize();i+=2){
        if(nilai[i] == id){
          nilai.remove(i);
          nilai.addAtIndex(i,id_new);
        }
    }
    id = id_new;
  }
}
#pragma endregion

#pragma region Fungsi Loop
void Core0( void * pvParameters ){

  for(;;){
    delay(25);
      if(ModeKirim == false){
        //core 0 (instruksi pembacaan data dari masing-masing servo dan hasilnya disimpan dalam variabel)
        PosN = dxl.getPresentPosition(id);
        SpeedN = dxl.getPresentVelocity(id);
        SpeedReal = dxl.getPresentVelocity(id, UNIT_RPM);
        Torque = dxl.getTorqueEnableStat(id);
        PosG = dxl.readControlTableItem(GOAL_POSITION, id);
        SpeedG = dxl.readControlTableItem(GOAL_VELOCITY, id);
        p_gain = dxl.readControlTableItem(P_GAIN, id);
        i_gain = dxl.readControlTableItem(I_GAIN, id);
        d_gain = dxl.readControlTableItem(D_GAIN, id);
        ret_delay = dxl.readControlTableItem(RETURN_DELAY_TIME, id); 
        temp = dxl.readControlTableItem(PRESENT_TEMPERATURE, id);
        Current = dxl.getPresentCurrent(id);
        CurrentReal = dxl.getPresentCurrent(id, UNIT_MILLI_AMPERE);
        }
      else{
        for(int i =0;i<nilai.getSize();i+=2){
          id = nilai[i];
          Model = nilai[i+1];
          PosN = dxl.getPresentPosition(id);
          Serial.println((String)"ID" + id + "Model" + Model + "Pos" + PosN);
          }
        }

    }
  
} 

void Core1( void * pvParameters ){
  for(;;){  
    delay(100);
    if(list_kirim == false){
      List_send();
      list_kirim = true;
      if(ModeKirim == false){
        Serial_Flush();
      }
    }
    else{
      if(ModeKirim == false){
        Serial.println((String)"ID" + id +  "Baud" + Sbaud + "Model" + Model + "Prot" + protocol + "PosN" + PosN + "PosG" + PosG + "SpeedN" + SpeedN + "SpeedG" + SpeedG + "Current" +  Current + "Torque" + Torque +"pgain"+ p_gain + "igain" + i_gain + "dgain" + d_gain + "retdelay" + ret_delay*2 + "temp" + temp + "speedReal" + SpeedReal+ "RealCurr" + CurrentReal);  
      }
    }
    while(Serial.available()>0){
      vTaskSuspend(Task1);
      Input_str = Serial.readString();
      int8_t indexganti = Input_str.indexOf("ganti");
      int8_t indexID = Input_str.indexOf("ID");
      int8_t indexBaud = Input_str.indexOf("Baud");
      int8_t indexPos = Input_str.indexOf("Pos");
      int8_t indexP = Input_str.indexOf("PG");
      int8_t indexI = Input_str.indexOf("IG");
      int8_t indexD = Input_str.indexOf("DG");
      int8_t indexRet = Input_str.indexOf("Ret");
      int8_t indexMode = Input_str.indexOf("mode");
      int8_t indexreset = Input_str.indexOf("reset");
      if(indexreset >= 0){
        scan_dxl();
      }

      if(indexganti >=0){
        uint8_t id_ganti = Input_str.substring(indexganti+5).toInt();
        if(ModeKirim == false){
          id = id_ganti;
          for(int i=0;i<nilai.getSize();i+=2){
            if(id_ganti == nilai[i]){
              Model = nilai[i+1];
              }
          }
        }
        else{
          ModeKirim = false;
          delay(1000);
        }
      }
      if(indexID >= 0){
        id_new = Input_str.substring((indexID+2), indexBaud).toInt();
        if(id_new != id){
          set_ID();
        }
      }
      
      if(indexBaud >= 0){ 
        Sbaud_new = Input_str.substring(indexBaud+4).toInt();
        if(Sbaud_new != Sbaud){
          set_Baud();
        }
      }
      if(indexPos >=0){
        nilai_Pos = Input_str.substring(indexPos+3).toInt();
        set_pos();
      }
      if(indexP >=0){
        nilaiP = Input_str.substring(indexPos+2).toInt();
        if(nilaiP != p_gain){
          Pchange();
        }
      }
      if(indexI >=0){
        nilaiI = Input_str.substring(indexPos+2).toInt();
        if(nilaiI != i_gain){
          Ichange();
        }
      }
      if(indexD >=0){
        nilaiD = Input_str.substring(indexPos+2).toInt();
        if(nilaiD != d_gain){
          Dchange();
        }
      }
      if(indexRet >=0){
        nilaiRet = uint8_t(Input_str.substring(indexPos+3).toInt());
        if(nilaiRet != ret_delay){
          ret_change();
        }
      }
      if(indexMode >=0){
        ModeKirim = Input_str.substring(indexMode+4).toInt();
        list_kirim = false;
        if(ModeKirim == false){
          
        }
        delay(2000);
      }
      
      Serial_flush();
      vTaskResume(Task1);
     }
  }
}
#pragma endregion

void setup() {
  // put your setup code here, to run once:
  int8_t index = 0;
  int8_t found_dynamixel = 0; 

  dxl.setPort(esp_dxl_port);
  // Use Serial to debug.
  Serial.begin(500000);
  // Set Port baudrate to 57600bps. This has to match with DYNAMIXEL baudrate.
  dxl.begin(1000000);
  // Set Port Protocol Version. This has to match with DYNAMIXEL protocol version.
  dxl.setPortProtocolVersion(protocol);
  for(index = 0; index < MAX_BAUD; index++) {
    dxl.begin(baud[index]); //Mulai Scan Dynamixel dengan Baudrate sesuai dengan nilai index
    for(uint8_t id_scan = 0; id_scan < DXL_BROADCAST_ID; id_scan++) { //Scan Device Dynamixel yang tersambung mulai dari ID 1-255
      if(dxl.ping(id_scan)) { //mulai task dibawah jika ada Servo dengan ID dan Baudrate dalam iterasi
        Model = dxl.getModelNumber(id_scan);
        Sbaud = baud[index];
        id = id_scan;
        nilai.add(id);
        nilai.add(Model);
        dxl.torqueOff(id_scan);
        dxl.writeControlTableItem(DRIVE_MODE,id_scan,4);
        dxl.writeControlTableItem(RETURN_DELAY_TIME,id_scan,50);
        dxl.writeControlTableItem(PROFILE_VELOCITY, id_scan, 0);
        dxl.setOperatingMode(id_scan, OP_POSITION);
        dxl.torqueOn(id_scan);
        dxl.writeControlTableItem(P_GAIN,id_scan,32);
        dxl.writeControlTableItem(I_GAIN,id_scan,0); 
        dxl.writeControlTableItem(D_GAIN,id_scan,0);
      }
    }
    
  }
  ModeKirim = true;
  xTaskCreatePinnedToCore(
                    Core0,   /* Task function. */
                    "Task1",     /* name of task. */
                    60000,       /* Stack size of task */
                    NULL,        /* parameter of the task */
                    2,           /* priority of the task */
                    &Task1,      /* Task handle to keep track of created task */
                    0);          /* pin task to core 0 */                  
  delay(500);
  xTaskCreatePinnedToCore(
                    Core1,   /* Task function. */
                    "Task2",     /* name of task. */
                    100000,       /* Stack size of task */
                    NULL,        /* parameter of the task */
                    1,           /* priority of the task */
                    &Task2,      /* Task handle to keep track of created task */
                    1);          /* pin task to core 1 */
    delay(500); 
  
}

void loop(){
   
}