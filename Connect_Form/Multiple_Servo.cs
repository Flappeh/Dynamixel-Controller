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
    public partial class Multiple_Servo : Form
    {
        Int32 indexID, indexModel,indexPos,indexSModel,indexServo,nilaiPos,nilaiSModel,nilaiServo,nilaiID,nilaiModel;
        string dataIN,dataID,dataModel,dataPos,dataServo,dataSModel;

        private void button_rescan_Click(object sender, EventArgs e)
        {
            Serial_Port3.WriteLine("mode1");
            List_servo2.Clear();
            Udahkirim = false;
        }

        public static Multiple_Servo instance;
        public DataTable List_servo2 = new DataTable("List_Servo2");
        public Multiple_Servo(String port2, Int32 baud2)
        {
            InitializeComponent();
            Serial_Port3.PortName = port2;
            Serial_Port3.BaudRate = baud2;
            Serial_Port3.Open();
            instance = this;
        }

        private void Multiple_Servo_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Serial_Port3.WriteLine("mode1");
            List_servo2.Columns.Add("Servo_id", Type.GetType("System.Int32"));
            List_servo2.Columns.Add("Servo_model", Type.GetType("System.Int32"));
            List_servo2.Columns.Add("Position", Type.GetType("System.Int32"));


            List_Servo_Multi.DataSource = List_servo2;
            label_pos_now.Text = "0";
        }

        private void bar_posisi_multi_Scroll(object sender, EventArgs e)
        {
            label_pos_now.Text = bar_posisi_multi.Value.ToString();
            label_PosDegree.Text = String.Format("{0}°", (float)bar_posisi_multi.Value / 4095*360);
        }

        private void bar_posisi_multi_MouseUp(object sender, MouseEventArgs e)
        {
            Serial_Port3.WriteLine("Pos" + bar_posisi_multi.Value.ToString());
        }

        private void Multiple_Servo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void Disconnect_Click(object sender, EventArgs e)
        {
            Serial_Port3.Close();
        }

        #region Terima data serial

        private void Serial_Port3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataIN = Serial_Port3.ReadLine();
                this.Invoke(new EventHandler(setText));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public bool Udahkirim = false;
        public void setText(object sender, EventArgs e)
        {
            try
            {
                if(Udahkirim == false)
                {
                    indexServo = Convert.ToInt32(dataIN.IndexOf("Servo"));
                    indexSModel = Convert.ToInt32(dataIN.IndexOf("SModel"));
                    dataServo = dataIN.Substring(indexServo + 5, (indexSModel - indexServo) - 5);
                    dataSModel = dataIN.Substring(indexSModel + 6);
                    nilaiServo = Convert.ToInt32(dataServo);
                    nilaiSModel = Convert.ToInt32(dataSModel);
                    Connection.instance.t.Text += "Servo " + dataServo + "Model " + nilaiSModel;
                    if (nilaiServo == 999)
                    {
                        Connection.instance.t.Text += "OK List Selesai diterima";
                        Udahkirim = true;
                    }
                    else
                    {
                        List_servo2.Rows.Add(nilaiServo, nilaiSModel);

                    }
                }
                indexID = Convert.ToInt32(dataIN.IndexOf("ID"));
                indexModel = Convert.ToInt32(dataIN.IndexOf("Model"));
                indexPos = Convert.ToInt32(dataIN.IndexOf("Pos"));

                dataID = dataIN.Substring(indexID + 2, (indexModel - indexID) - 2);
                dataModel = dataIN.Substring(indexModel + 5, (indexPos - indexModel) - 5);
                dataPos = dataIN.Substring(indexPos + 3);

                nilaiID = Convert.ToInt32(dataID);
                nilaiModel = Convert.ToInt32(dataModel);
                nilaiPos = Convert.ToInt32(dataPos);
                baca_list();

            }
            catch (Exception er)
            {
                Connection.instance.t.Text += "Gabisa" + er.Message;
            }
        }
        private void baca_list()
        {
            try
            {
                var count = List_Servo_Multi.Rows.Cast<DataGridViewRow>().Count();
                for (int i = 0; i < count; i++)
                {
                    DataGridViewRow row = List_Servo_Multi.Rows[i];
                    if(row.Cells[0].Value.ToString() == dataID && row.Cells[1].Value.ToString() == dataModel)
                    {
                        row.Cells[2].Value = nilaiPos;
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
