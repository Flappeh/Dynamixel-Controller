using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Reflection;

namespace Connect_Form
{
    public partial class Connection : Form
    {
        
        string portname;
        Int32 baudrate;
        public static Connection instance;
        public RichTextBox t;
        public Connection()
        {
            InitializeComponent();
            instance = this;
            t = debugBox;
        }
        private void Connection_Load(object sender, EventArgs e)
        {
            SetPortNameValues();
            box_Ports.Enabled = true;
            box_Bauds.Enabled = true;
            button_Connect.Enabled = true;
            button_Disconnect.Enabled = false;
            check_autoscroll.Enabled = true;
        }
        public void AppendText(string value)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(AppendText), new object[] { value });
                return;
            }
            debugBox.Text += value;
        }

        
        public void SetPortNameValues()
        {
            String[] ports = SerialPort.GetPortNames();
            box_Ports.Items.Clear();
            foreach (string port in ports) //add this names to comboboxPort items
            {
                box_Ports.Items.Add(port); //if there are some com ports ,select first
            }
            if (box_Ports.Items.Count > 0)
            {
                (box_Ports).SelectedIndex = 0;
            }
            else
            {
                box_Ports.Text = " "; //if there are no com ports ,write Empty
            }                
            
        }
        public async void initiate_progress()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(i.ToString());
            }
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                label_progress.Text = string.Format("{0}%", report.PercentComplete);
                progress_Connect.Value = report.PercentComplete;
                progress_Connect.Update();
            };
            await ProcessData(list, progress);
            label_progress.Text = "Done!";
        }
        public void button_Connect_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Serial_Port.IsOpen)
                {
                    initiate_progress();
                    portname = box_Ports.Text;
                    baudrate = Convert.ToInt32(box_Bauds.Text);
                    
                    Serial_Port.PortName = portname;
                    Serial_Port.BaudRate = baudrate;
                    Serial_Port.Open();
                    if (Serial_Port.IsOpen)
                    {
                        Thread.Sleep(200);
                        Serial_Port.Close();
                        openChildForm(new Single_Servo(portname, baudrate));
                        Thread.Sleep(200);
                        cekFrm("Single_Servo", true);

                        button_Connect.Enabled = false;
                        button_Disconnect.Enabled = true;
                        //button_Analysis.Enabled = true;
                        button_single_servo.Enabled = false;
                        button_multiple_servo.Enabled = true;
                        debugBox.Text += Environment.NewLine+ "Sukses koneksi pada Port " + portname + ", Baudrate " + baudrate.ToString(); 
                    }
                }
                else
                {
                }
            }
            catch (Exception err)
            {
                Thread.Sleep(1000);
                debugBox.Text = err.Message;
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Serial_Port.Close();
                SetPortNameValues();
                button_Connect.Enabled = true;
                button_Disconnect.Enabled = false;
            }
        }
            
        
        
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Serial_Port.IsOpen)
                {
                    Serial_Port.Close();
                    progress_Connect.Value = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            button_Connect.Enabled = true;
            button_Disconnect.Enabled = false;
            progress_Connect.Value = 0;
        }

        private void Connection_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Serial_Port.IsOpen)
                {
                    Serial_Port.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess=list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / 100;
                    progress.Report(progressReport);
                    //debugBox.Text = progressReport.ToString();
                    Thread.Sleep(10);

                }
            });
        }

        #region buka form kecil
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void closeChildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.Close();
        }
        public void cekFrm(string cekform, bool status)

        {
            try
            {
                Form form_name = Application.OpenForms[cekform];
                if (activeForm == form_name && status)
                {
                    debugBox.Text += ("Sub  dibuka".Insert(4,cekform));
                    if (cekform == "Single_Servo")
                    {
                        button_single_servo.Enabled = false;
                        button_multiple_servo.Enabled = true;
                        //button_Analysis.Enabled = true;

                    }
                    else if (cekform == "Multiple_Servo")
                    {
                        button_multiple_servo.Enabled = false;
                        button_single_servo.Enabled = true;
                        //button_Analysis.Enabled = true;

                    }
                    else if (cekform == "Analysis")
                    {
                        //.Enabled = false;
                        button_single_servo.Enabled = true;
                        button_multiple_servo.Enabled = true;

                    }
                }
                else if (activeForm == form_name && !status)
                {
                    debugBox.Text += ("Sub  ditutup".Insert(4, cekform));
                    if (cekform == "Single_Servo")
                        button_single_servo.Enabled = true;
                    else if (cekform == "Multiple_Servo")
                        button_multiple_servo.Enabled = true;
                    //else if (cekform == "Analysis")
                        //button_Analysis.Enabled = true;
                }
                else
                {
                    
                }

            }
            catch (Exception ex)
            {
                debugBox.Text += ex.Message;
            }
            
        }
        private void button_Connection_Click(object sender, EventArgs e)
        {
            if (Serial_Port.IsOpen)
            {
                button_single_servo.Enabled = true;
                button_multiple_servo.Enabled = true;
                //xbutton_Analysis.Enabled = true; 
                foreach (Form frm in Application.OpenForms)
                {
                    closeChildForm(frm);
                }
            }
            group_connection.Enabled = true;
            group_connection.Visible = true;
        }
        private void button_single_servo_Click(object sender, EventArgs e)
        {
            if(Serial_Port.IsOpen)
            Serial_Port.Close();
            progress_Connect.Value = 0;
            if (activeForm != null)
            activeForm.Close();
            Thread.Sleep(200);
            openChildForm(new Single_Servo(portname, baudrate));
            Thread.Sleep(200);
            cekFrm("Single_Servo", true);

        }

        private void button_multiple_servo_Click(object sender, EventArgs e)
        {
            if (Serial_Port.IsOpen)
                Serial_Port.Close();
            progress_Connect.Value = 0;
            initiate_progress();
            if (activeForm != null)
                activeForm.Close();
            Thread.Sleep(1000);
            openChildForm(new Multiple_Servo(portname, baudrate));
            cekFrm("Multiple_Servo", true);

        }
        private void button_Analysis_Click(object sender, EventArgs e)
        {
            progress_Connect.Value = 0;
            initiate_progress();
            if (activeForm != null)
                activeForm.Close();
            Serial_Port.Close();
            openChildForm(new Analysis());
            cekFrm("Analysis", true);
        }
        #endregion

        private void debugBox_TextChanged(object sender, EventArgs e)
        {
            debugBox.Text += "\n";
            if (check_autoscroll.Checked)
            {
                debugBox.SelectionStart = debugBox.TextLength;
                debugBox.ScrollToCaret();
            }
        }

        private void check_autoscroll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            debugBox.Text = "";
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
