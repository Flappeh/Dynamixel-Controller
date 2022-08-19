using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace Connect_Form
{
    public partial class Single_Servo : Form
    {

        Int32 indexCurrReal,nilaiCurrReal,indexSpeedReal,idpilih,indexList,nilaiServo, nilaiSModel,indexServo, indexSModel, indexID, indexModel, indexBaud, indexProtocol, indexPos_now, indexPos_Goal, index_Speed_now, index_Speed_goal, index_torque, index_Current, index_p_gain, index_i_gain, index_d_gain, index_return_delay, index_temp;
        string dataCurrReal,dataSpeedReal,pos_val, dataServo, dataSModel, dataIN, dataID, dataModel, dataBaud,dataProtocol,dataPos_now,dataPos_Goal,dataSpeed_now,dataSpeed_goal,dataTorque,dataCurrent,data_p_gain,data_i_gain,data_d_gain,data_return_delay,data_temp;

        public DataTable List_servo = new DataTable("List_servo");


        public static Single_Servo instance;

        #region Form Load
        public Single_Servo(String port, Int32 baud)
        {
            try
            {
                InitializeComponent();
                Serial_Port2.PortName = port;
                Serial_Port2.BaudRate = baud;
                Serial_Port2.Open();
                instance = this;
                Serial_Port2.WriteLine("mode0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Single_Servo_Load(object sender, EventArgs e)
        {
            try
            {
                if (Serial_Port2.IsOpen)
                {
                    List_servo.Columns.Add("Servo_id", Type.GetType("System.Int32"));
                    List_servo.Columns.Add("Servo_model", Type.GetType("System.Int32"));

                    List_Servo_Single.DataSource = List_servo;
                    Console.WriteLine("Open");
                }
                else
                {
                    Console.WriteLine("Close");
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        #endregion


        #region Disconnect Form
        private void Disconnect_Click(object sender, EventArgs e)
        {
            Serial_Port2.Close();
            Thread.Sleep(100);

            Connection.instance.t.Text += "Sub Single_Servo ditutup";
            this.Close();
        }
        
        private void Single_Servo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Serial_Port2.IsOpen)
                {
                    Serial_Port2.Close();
                    Connection.instance.t.Text += "Sub Single_Servo ditutup";

                }
            }
            catch (Exception ex)
            {

                Connection.instance.t.Text += ex.Message;
            }
        }
        #endregion

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion


        #region .. code for Flucuring ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        #region Terima data serial
        public bool Udahpilih = false;

        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataIN = Serial_Port2.ReadLine();
                this.Invoke(new EventHandler(setText));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void setText(object sender, EventArgs e)
        {
            try
            {
                SetDoubleBuffered(table_single);
                
                if(Udahpilih == false)
                {
                    indexServo = Convert.ToInt32(dataIN.IndexOf("Servo"));
                    indexSModel = Convert.ToInt32(dataIN.IndexOf("SModel"));
                    dataServo = dataIN.Substring(indexServo + 5,(indexSModel-indexServo)-5);
                    dataSModel = dataIN.Substring(indexSModel + 6);
                    nilaiServo = Convert.ToInt32(dataServo);
                    nilaiSModel = Convert.ToInt32(dataSModel);
                    Connection.instance.t.Text += "Servo " + dataServo + "Model " + nilaiSModel;
                    if (nilaiServo == 999)
                    {
                        Connection.instance.t.Text += "OK List Selesai diterima";
                    }
                    else
                    {
                        List_servo.Rows.Add(nilaiServo, nilaiSModel);

                    }
                    
                }
                else
                {

                    terima_data(sender, e);
                }
                                
            }
            catch (Exception er)
            {
                Connection.instance.t.Text += er.Message;
            }
        }
        public void terima_data(object sender, EventArgs e)
        {
            indexID = Convert.ToInt32(dataIN.IndexOf("ID"));
            indexBaud = Convert.ToInt32(dataIN.IndexOf("Baud"));
            indexModel = Convert.ToInt32(dataIN.IndexOf("Model"));
            indexProtocol = Convert.ToInt32(dataIN.IndexOf("Prot"));
            indexPos_now = Convert.ToInt32(dataIN.IndexOf("PosN"));
            indexPos_Goal = Convert.ToInt32(dataIN.IndexOf("PosG"));
            index_Speed_now = Convert.ToInt32(dataIN.IndexOf("SpeedN"));
            index_Speed_goal = Convert.ToInt32(dataIN.IndexOf("SpeedG"));
            index_Current = Convert.ToInt32(dataIN.IndexOf("Current"));
            index_torque = Convert.ToInt32(dataIN.IndexOf("Torque"));
            index_p_gain = Convert.ToInt32(dataIN.IndexOf("pgain"));
            index_i_gain = Convert.ToInt32(dataIN.IndexOf("igain"));
            index_d_gain = Convert.ToInt32(dataIN.IndexOf("dgain"));
            index_return_delay = Convert.ToInt32(dataIN.IndexOf("retdelay"));
            index_temp = Convert.ToInt32(dataIN.IndexOf("temp"));
            indexSpeedReal = Convert.ToInt32(dataIN.IndexOf("speedReal"));
            indexCurrReal = Convert.ToInt32(dataIN.IndexOf("RealCurr"));

            dataID = dataIN.Substring(indexID + 2, (indexBaud - indexID) - 2);
            dataBaud = dataIN.Substring(indexBaud + 4, (indexModel - indexBaud) - 4);
            dataModel = dataIN.Substring(indexModel + 5, (indexProtocol - indexModel) - 5);
            dataProtocol = dataIN.Substring(indexProtocol + 4, (indexPos_now - indexProtocol) - 4);
            dataPos_now = dataIN.Substring(indexPos_now + 4, (indexPos_Goal - indexPos_now) - 4);
            dataPos_Goal = dataIN.Substring(indexPos_Goal + 4, (index_Speed_now - indexPos_Goal) - 4);
            dataSpeed_now = dataIN.Substring(index_Speed_now + 6, (index_Speed_goal - index_Speed_now) - 6);
            dataSpeed_goal = dataIN.Substring(index_Speed_goal + 6, (index_Current - index_Speed_goal) - 6);
            dataCurrent = dataIN.Substring(index_Current + 7, (index_torque - index_Current) - 7);
            dataTorque = dataIN.Substring(index_torque + 6, (index_p_gain - index_torque) - 6);
            data_p_gain = dataIN.Substring(index_p_gain + 5, (index_i_gain - index_p_gain) - 5);
            data_i_gain = dataIN.Substring(index_i_gain + 5, (index_d_gain - index_i_gain) - 5);
            data_d_gain = dataIN.Substring(index_d_gain + 5, (index_return_delay - index_d_gain) - 5);
            data_return_delay = dataIN.Substring(index_return_delay + 8, (index_temp - index_return_delay) - 8);
            data_temp = dataIN.Substring(index_temp + 4, (indexSpeedReal - index_temp)-4);
            dataSpeedReal = dataIN.Substring(indexSpeedReal + 9, (indexCurrReal - indexSpeedReal) - 9);
            dataCurrReal = dataIN.Substring(indexCurrReal + 8);


            label_Value_ID.Text = dataID;
            label_Value_Model.Text = dataModel;
            label_Value_Baud.Text = dataBaud;
            label_Value_Protocol.Text = dataProtocol;
            label_Value_Torque.Text = dataTorque;
            label_Value_Goal_Pos.Text = dataPos_Goal;
            label_Value_Now_Pos.Text = dataPos_now;
            label_Act_Pos.Text = Convert.ToString((Convert.ToDouble(dataPos_now)) / 4096 * 360);
            label_Value_Goal_Speed.Text = dataSpeed_goal;
            label_Value_Now_Speed.Text = dataSpeed_now;
            label_Value_Torque.Text = dataTorque;
            label_Value_Now_Current.Text = dataCurrent;
            label_id_box.Text = dataID;
            label_Now_baud.Text = dataBaud;
            label_p_gain.Text = data_p_gain;
            label_i_gain.Text = data_i_gain;
            label_d_gain.Text = data_d_gain;
            label_ret_val.Text = data_return_delay;
            label_temp.Text = data_temp;
            label_P_now.Text = data_p_gain;
            label_I_now.Text = data_i_gain;
            label_Act_Speed.Text = dataSpeedReal;
            label_Act_Current.Text = dataCurrReal;
        }
        #endregion

        #region Clickable dalam Table
        private void List_Servo_Single_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexList = e.RowIndex;
            DataGridViewRow row = List_Servo_Single.Rows[indexList];
            idpilih = Convert.ToInt32(row.Cells[0].Value);
            Connection.instance.t.Text += "ID yang dipilih adalah : " + idpilih;
            Serial_Port2.WriteLine("ganti" + idpilih.ToString());
            Udahpilih = true;
        }

        private void button_rescan_Click(object sender, EventArgs e)
        {
            Serial_Port2.WriteLine("reset");
        }

        private void checkBox_Pos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Pos.Checked)
            {
                Bar_Position.Enabled = true;
                

            }
            else
            {
                Bar_Position.Enabled = false;
            }
        }
        private void label_ID_Click(object sender, EventArgs e)
        {
            group_ID.Visible = true;
            group_Baud.Visible = false;
            group_Pos.Visible = false;
            group_P_gain.Visible = false;
            group_i_gain.Visible = false;
            group_d_gain.Visible = false;
        }
        private void button_p_gain_Click(object sender, EventArgs e)
        {
            group_P_gain.Visible = true;
            group_ID.Visible = false;
            group_Baud.Visible = false;
            group_Pos.Visible = false;
            group_i_gain.Visible = false;
            group_d_gain.Visible = false;
        }

        private void Bar_Position_MouseUp(object sender, MouseEventArgs e)
        {
            Serial_Port2.WriteLine("Pos" + pos_val);

        }
        private void Bar_Position_Scroll(object sender, EventArgs e)
        {

            label_Now_pos.Text = Bar_Position.Value.ToString();
            pos_val = Convert.ToString(Bar_Position.Value);
            if (button_center_clicked == true)
            {
                Bar_Position.Value = 2048;
                label_Now_pos.Text = 2048.ToString();

                Serial_Port2.WriteLine("Pos" + 2048);
                button_center_clicked = false;
            }
        }
        private void label_Pos_Now_Click(object sender, EventArgs e)
        {
            try
            {
                group_P_gain.Visible = false;
                group_ID.Visible = false;
                group_Baud.Visible = false;
                group_Pos.Visible = true;
                group_i_gain.Visible = false;
                group_d_gain.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_send_baud_Click(object sender, EventArgs e)
        {
            string Baud_out = box_Send_Baud.Text;
            try
            {
                if (Baud_out != dataBaud)
                {
                    Serial_Port2.WriteLine("Baud" + Baud_out);
                }
            }
            catch (Exception ex)
            {
                Connection.instance.t.Text += "Baudrate sama, tidak perlu dikirim ulang";
            }
        }
        private void button_d_gain_Click(object sender, EventArgs e)
        {
            group_P_gain.Visible = false;
            group_ID.Visible = false;
            group_Baud.Visible = false;
            group_Pos.Visible = false;
            group_i_gain.Visible = false;
            group_d_gain.Visible = true;
        }

        private void button_i_gain_Click(object sender, EventArgs e)
        {
            group_P_gain.Visible = false;
            group_ID.Visible = false;
            group_Baud.Visible = false;
            group_Pos.Visible = false;
            group_i_gain.Visible = true;
            group_d_gain.Visible = false;
        }
        private void label_Baudrate_Click(object sender, EventArgs e)
        {
            group_P_gain.Visible = false;
            group_ID.Visible = false;
            group_Baud.Visible = true;
            group_Pos.Visible = false;
            group_i_gain.Visible = false;
            group_d_gain.Visible = false;
        }
        public bool button_center_clicked = false;
        private void button_center_Click(object sender, EventArgs e)
        {
            try
            {
                button_center_clicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Send_Click_ID(object sender, EventArgs e)
        {
            try
            {
                string ID_out = box_Send_ID.Text;
                if ((ID_out != dataID))
                {
                    Serial_Port2.WriteLine("ID" + ID_out);
                    List_Servo_Single.Rows[indexList].Cells[0].Value = Convert.ToInt32(ID_out);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_i_send_Click(object sender, EventArgs e)
        {
            string i_out = box_i_gain.Text;
            try
            {
                if (i_out != data_p_gain)
                {
                    Serial_Port2.WriteLine("IG" + i_out);
                }
            }
            catch (Exception ex)
            {
                Connection.instance.t.Text += "I Gain sama, tidak perlu dikirim ulang";
            }
        }

        private void button_d_send_Click(object sender, EventArgs e)
        {
            string d_out = box_d_gain.Text;
            try
            {
                if (d_out != data_d_gain)
                {
                    Serial_Port2.WriteLine("DG" + d_out);
                }
            }
            catch (Exception ex)
            {
                Connection.instance.t.Text += "D Gain sama, tidak perlu dikirim ulang";
            }
        }
        private void button_send_p_gain_Click(object sender, EventArgs e)
        {
            string p_out = box_p_gain.Text;
            try
            {
                if (p_out!= data_p_gain)
                {
                    Serial_Port2.WriteLine("PG" + p_out);
                }
            }
            catch (Exception ex)
            {
                Connection.instance.t.Text += "P Gain sama, tidak perlu dikirim ulang";
            }
        }
        #endregion
    }
}
