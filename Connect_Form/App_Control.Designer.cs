namespace Connect_Form
{
    partial class Single_Servo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            this.label_Item = new System.Windows.Forms.Label();
            this.label_Nilai = new System.Windows.Forms.Label();
            this.label_Unit_Current = new System.Windows.Forms.Label();
            this.label_Unit_Pos = new System.Windows.Forms.Label();
            this.label_Value_Goal_Speed = new System.Windows.Forms.Label();
            this.label_Act_Current = new System.Windows.Forms.Label();
            this.label_Value_Now_Current = new System.Windows.Forms.Label();
            this.label_Value_ID = new System.Windows.Forms.Label();
            this.label_Value_Torque = new System.Windows.Forms.Label();
            this.label_Value_Goal_Pos = new System.Windows.Forms.Label();
            this.label_Value_Now_Speed = new System.Windows.Forms.Label();
            this.label_Value_Now_Pos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Value_Protocol = new System.Windows.Forms.Label();
            this.label_Act_Speed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Value_Model = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Value_Baud = new System.Windows.Forms.Label();
            this.label_Act_Pos = new System.Windows.Forms.Label();
            this.label_Actual = new System.Windows.Forms.Label();
            this.label_Unit_Speed = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Serial_Port2 = new System.IO.Ports.SerialPort(this.components);
            this.box_Send_Baud = new System.Windows.Forms.ComboBox();
            this.button_Send_ID = new System.Windows.Forms.Button();
            this.box_Send_ID = new System.Windows.Forms.ComboBox();
            this.label_Send_ID = new System.Windows.Forms.Label();
            this.label_Send_Baud = new System.Windows.Forms.Label();
            this.Bar_Position = new System.Windows.Forms.TrackBar();
            this.label_Send_Pos = new System.Windows.Forms.Label();
            this.group_ID = new System.Windows.Forms.GroupBox();
            this.label_ID_now = new System.Windows.Forms.Label();
            this.label_id_box = new System.Windows.Forms.Label();
            this.button_center = new System.Windows.Forms.Button();
            this.checkBox_Pos = new System.Windows.Forms.CheckBox();
            this.label_ID = new System.Windows.Forms.Button();
            this.label_Baudrate = new System.Windows.Forms.Button();
            this.label_Pos_Now = new System.Windows.Forms.Button();
            this.table_single = new System.Windows.Forms.TableLayoutPanel();
            this.button_i_gain = new System.Windows.Forms.Button();
            this.button_d_gain = new System.Windows.Forms.Button();
            this.button_p_gain = new System.Windows.Forms.Button();
            this.label_Speed_Now = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_i_gain = new System.Windows.Forms.Label();
            this.label_d_gain = new System.Windows.Forms.Label();
            this.label_p_gain = new System.Windows.Forms.Label();
            this.label_prot = new System.Windows.Forms.Label();
            this.label_ret_val = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_return_delay = new System.Windows.Forms.Label();
            this.label_Pos_Goal = new System.Windows.Forms.Label();
            this.label_Torque = new System.Windows.Forms.Label();
            this.label_Arus = new System.Windows.Forms.Label();
            this.label_Speed_Goal = new System.Windows.Forms.Label();
            this.group_Baud = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Now_baud = new System.Windows.Forms.Label();
            this.button_send_baud = new System.Windows.Forms.Button();
            this.group_Pos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label_Now_pos = new System.Windows.Forms.Label();
            this.group_P_gain = new System.Windows.Forms.GroupBox();
            this.button_send_p_gain = new System.Windows.Forms.Button();
            this.box_p_gain = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label_P_now = new System.Windows.Forms.Label();
            this.label_P_group = new System.Windows.Forms.Label();
            this.List_Servo_Single = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_i_gain = new System.Windows.Forms.GroupBox();
            this.button_i_send = new System.Windows.Forms.Button();
            this.box_i_gain = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_I_now = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.group_d_gain = new System.Windows.Forms.GroupBox();
            this.button_d_send = new System.Windows.Forms.Button();
            this.box_d_gain = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_d_now = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button_rescan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Position)).BeginInit();
            this.group_ID.SuspendLayout();
            this.table_single.SuspendLayout();
            this.group_Baud.SuspendLayout();
            this.group_Pos.SuspendLayout();
            this.group_P_gain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_Servo_Single)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_i_gain.SuspendLayout();
            this.group_d_gain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Item
            // 
            this.label_Item.AutoSize = true;
            this.label_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Item.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Item.Location = new System.Drawing.Point(63, 3);
            this.label_Item.Margin = new System.Windows.Forms.Padding(0);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(234, 46);
            this.label_Item.TabIndex = 8;
            this.label_Item.Text = "Item";
            this.label_Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Nilai
            // 
            this.label_Nilai.AutoSize = true;
            this.label_Nilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Nilai.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Nilai.Location = new System.Drawing.Point(300, 3);
            this.label_Nilai.Margin = new System.Windows.Forms.Padding(0);
            this.label_Nilai.Name = "label_Nilai";
            this.label_Nilai.Size = new System.Drawing.Size(139, 46);
            this.label_Nilai.TabIndex = 9;
            this.label_Nilai.Text = "Nilai Raw";
            this.label_Nilai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Unit_Current
            // 
            this.label_Unit_Current.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_Unit_Current.AutoSize = true;
            this.label_Unit_Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Unit_Current.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Unit_Current.Location = new System.Drawing.Point(599, 484);
            this.label_Unit_Current.Margin = new System.Windows.Forms.Padding(0);
            this.label_Unit_Current.Name = "label_Unit_Current";
            this.label_Unit_Current.Size = new System.Drawing.Size(89, 40);
            this.label_Unit_Current.TabIndex = 42;
            this.label_Unit_Current.Text = "[mA]";
            this.label_Unit_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Unit_Pos
            // 
            this.label_Unit_Pos.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_Unit_Pos.AutoSize = true;
            this.label_Unit_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Unit_Pos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Unit_Pos.Location = new System.Drawing.Point(599, 226);
            this.label_Unit_Pos.Margin = new System.Windows.Forms.Padding(0);
            this.label_Unit_Pos.Name = "label_Unit_Pos";
            this.label_Unit_Pos.Size = new System.Drawing.Size(89, 40);
            this.label_Unit_Pos.TabIndex = 43;
            this.label_Unit_Pos.Text = "[ ° ]";
            this.label_Unit_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Goal_Speed
            // 
            this.label_Value_Goal_Speed.AutoSize = true;
            this.label_Value_Goal_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Goal_Speed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Goal_Speed.Location = new System.Drawing.Point(300, 613);
            this.label_Value_Goal_Speed.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Goal_Speed.Name = "label_Value_Goal_Speed";
            this.label_Value_Goal_Speed.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Goal_Speed.TabIndex = 35;
            this.label_Value_Goal_Speed.Text = "Goal Speed";
            this.label_Value_Goal_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Act_Current
            // 
            this.label_Act_Current.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_Act_Current.AutoSize = true;
            this.label_Act_Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Act_Current.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Act_Current.Location = new System.Drawing.Point(442, 484);
            this.label_Act_Current.Margin = new System.Windows.Forms.Padding(0);
            this.label_Act_Current.Name = "label_Act_Current";
            this.label_Act_Current.Size = new System.Drawing.Size(154, 40);
            this.label_Act_Current.TabIndex = 40;
            this.label_Act_Current.Text = "Arus";
            this.label_Act_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Now_Current
            // 
            this.label_Value_Now_Current.AutoSize = true;
            this.label_Value_Now_Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Now_Current.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Now_Current.Location = new System.Drawing.Point(300, 484);
            this.label_Value_Now_Current.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Now_Current.Name = "label_Value_Now_Current";
            this.label_Value_Now_Current.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Now_Current.TabIndex = 36;
            this.label_Value_Now_Current.Text = "Curr Now";
            this.label_Value_Now_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_ID
            // 
            this.label_Value_ID.AutoSize = true;
            this.label_Value_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_ID.Location = new System.Drawing.Point(300, 95);
            this.label_Value_ID.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_ID.Name = "label_Value_ID";
            this.label_Value_ID.Size = new System.Drawing.Size(139, 40);
            this.label_Value_ID.TabIndex = 36;
            this.label_Value_ID.Text = "Nilai ID";
            this.label_Value_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Torque
            // 
            this.label_Value_Torque.AutoSize = true;
            this.label_Value_Torque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Torque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Torque.Location = new System.Drawing.Point(300, 527);
            this.label_Value_Torque.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Torque.Name = "label_Value_Torque";
            this.label_Value_Torque.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Torque.TabIndex = 34;
            this.label_Value_Torque.Text = "Torque";
            this.label_Value_Torque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Goal_Pos
            // 
            this.label_Value_Goal_Pos.AutoSize = true;
            this.label_Value_Goal_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Goal_Pos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Goal_Pos.Location = new System.Drawing.Point(300, 570);
            this.label_Value_Goal_Pos.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Goal_Pos.Name = "label_Value_Goal_Pos";
            this.label_Value_Goal_Pos.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Goal_Pos.TabIndex = 33;
            this.label_Value_Goal_Pos.Text = "Goal Pos";
            this.label_Value_Goal_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Now_Speed
            // 
            this.label_Value_Now_Speed.AutoSize = true;
            this.label_Value_Now_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Now_Speed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Now_Speed.Location = new System.Drawing.Point(300, 269);
            this.label_Value_Now_Speed.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Now_Speed.Name = "label_Value_Now_Speed";
            this.label_Value_Now_Speed.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Now_Speed.TabIndex = 29;
            this.label_Value_Now_Speed.Text = "Speed Now";
            this.label_Value_Now_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Now_Pos
            // 
            this.label_Value_Now_Pos.AutoSize = true;
            this.label_Value_Now_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Now_Pos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Now_Pos.Location = new System.Drawing.Point(300, 226);
            this.label_Value_Now_Pos.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Now_Pos.Name = "label_Value_Now_Pos";
            this.label_Value_Now_Pos.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Now_Pos.TabIndex = 32;
            this.label_Value_Now_Pos.Text = "Pos Now";
            this.label_Value_Now_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 441);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 40);
            this.label10.TabIndex = 26;
            this.label10.Text = "10.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Protocol
            // 
            this.label_Value_Protocol.AutoSize = true;
            this.label_Value_Protocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Protocol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Protocol.Location = new System.Drawing.Point(300, 138);
            this.label_Value_Protocol.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Protocol.Name = "label_Value_Protocol";
            this.label_Value_Protocol.Size = new System.Drawing.Size(139, 42);
            this.label_Value_Protocol.TabIndex = 31;
            this.label_Value_Protocol.Text = "Protokol";
            this.label_Value_Protocol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Act_Speed
            // 
            this.label_Act_Speed.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_Act_Speed.AutoSize = true;
            this.label_Act_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Act_Speed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Act_Speed.Location = new System.Drawing.Point(442, 269);
            this.label_Act_Speed.Margin = new System.Windows.Forms.Padding(0);
            this.label_Act_Speed.Name = "label_Act_Speed";
            this.label_Act_Speed.Size = new System.Drawing.Size(154, 40);
            this.label_Act_Speed.TabIndex = 38;
            this.label_Act_Speed.Text = "Speed";
            this.label_Act_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 40);
            this.label9.TabIndex = 25;
            this.label9.Text = "9.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 40);
            this.label8.TabIndex = 23;
            this.label8.Text = "8.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "3.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 40);
            this.label7.TabIndex = 22;
            this.label7.Text = "7.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Model
            // 
            this.label_Value_Model.AutoSize = true;
            this.label_Value_Model.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_Model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Model.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Model.Location = new System.Drawing.Point(300, 52);
            this.label_Value_Model.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Model.Name = "label_Value_Model";
            this.label_Value_Model.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Model.TabIndex = 28;
            this.label_Value_Model.Text = "Nilai Model";
            this.label_Value_Model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 40);
            this.label6.TabIndex = 21;
            this.label6.Text = "6.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "5.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Number.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Number.Location = new System.Drawing.Point(3, 3);
            this.label_Number.Margin = new System.Windows.Forms.Padding(0);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(57, 46);
            this.label_Number.TabIndex = 15;
            this.label_Number.Text = "No.";
            this.label_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "4.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "2.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "1.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Baud
            // 
            this.label_Value_Baud.AutoSize = true;
            this.label_Value_Baud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Baud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Value_Baud.Location = new System.Drawing.Point(300, 183);
            this.label_Value_Baud.Margin = new System.Windows.Forms.Padding(0);
            this.label_Value_Baud.Name = "label_Value_Baud";
            this.label_Value_Baud.Size = new System.Drawing.Size(139, 40);
            this.label_Value_Baud.TabIndex = 30;
            this.label_Value_Baud.Text = "Baud";
            this.label_Value_Baud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Act_Pos
            // 
            this.label_Act_Pos.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_Act_Pos.AutoSize = true;
            this.label_Act_Pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Act_Pos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Act_Pos.Location = new System.Drawing.Point(442, 226);
            this.label_Act_Pos.Margin = new System.Windows.Forms.Padding(0);
            this.label_Act_Pos.Name = "label_Act_Pos";
            this.label_Act_Pos.Size = new System.Drawing.Size(154, 40);
            this.label_Act_Pos.TabIndex = 37;
            this.label_Act_Pos.Text = "Pos";
            this.label_Act_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Actual
            // 
            this.label_Actual.AutoSize = true;
            this.label_Actual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Actual.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Actual.Location = new System.Drawing.Point(442, 3);
            this.label_Actual.Margin = new System.Windows.Forms.Padding(0);
            this.label_Actual.Name = "label_Actual";
            this.label_Actual.Size = new System.Drawing.Size(154, 46);
            this.label_Actual.TabIndex = 13;
            this.label_Actual.Text = "Nilai Asli";
            this.label_Actual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Unit_Speed
            // 
            this.label_Unit_Speed.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_Unit_Speed.AutoSize = true;
            this.label_Unit_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Unit_Speed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Unit_Speed.Location = new System.Drawing.Point(599, 269);
            this.label_Unit_Speed.Margin = new System.Windows.Forms.Padding(0);
            this.label_Unit_Speed.Name = "label_Unit_Speed";
            this.label_Unit_Speed.Size = new System.Drawing.Size(89, 40);
            this.label_Unit_Speed.TabIndex = 41;
            this.label_Unit_Speed.Text = "[rpm]";
            this.label_Unit_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Disconnect
            // 
            this.Disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Disconnect.BackColor = System.Drawing.Color.Transparent;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disconnect.ForeColor = System.Drawing.Color.Transparent;
            this.Disconnect.Location = new System.Drawing.Point(919, 533);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(127, 47);
            this.Disconnect.TabIndex = 13;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Serial_Port2
            // 
            this.Serial_Port2.BaudRate = 9600;
            this.Serial_Port2.DataBits = 8;
            this.Serial_Port2.DiscardNull = false;
            this.Serial_Port2.DtrEnable = false;
            this.Serial_Port2.Handshake = System.IO.Ports.Handshake.None;
            this.Serial_Port2.NewLine = "\n";
            this.Serial_Port2.Parity = System.IO.Ports.Parity.None;
            this.Serial_Port2.ParityReplace = ((byte)(63));
            this.Serial_Port2.PortName = "COM1";
            this.Serial_Port2.ReadBufferSize = 4096;
            this.Serial_Port2.ReadTimeout = -1;
            this.Serial_Port2.ReceivedBytesThreshold = 1;
            this.Serial_Port2.RtsEnable = false;
            this.Serial_Port2.StopBits = System.IO.Ports.StopBits.One;
            this.Serial_Port2.WriteBufferSize = 2048;
            this.Serial_Port2.WriteTimeout = -1;
            this.Serial_Port2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SP_DataReceived);
            // 
            // box_Send_Baud
            // 
            this.box_Send_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Send_Baud.FormattingEnabled = true;
            this.box_Send_Baud.Items.AddRange(new object[] {
            "57600",
            "115200",
            "500000",
            "1000000",
            "2000000"});
            this.box_Send_Baud.Location = new System.Drawing.Point(132, 40);
            this.box_Send_Baud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_Send_Baud.Name = "box_Send_Baud";
            this.box_Send_Baud.Size = new System.Drawing.Size(150, 23);
            this.box_Send_Baud.TabIndex = 14;
            // 
            // button_Send_ID
            // 
            this.button_Send_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Send_ID.Location = new System.Drawing.Point(55, 99);
            this.button_Send_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Send_ID.Name = "button_Send_ID";
            this.button_Send_ID.Size = new System.Drawing.Size(196, 44);
            this.button_Send_ID.TabIndex = 15;
            this.button_Send_ID.Text = "SEND";
            this.button_Send_ID.UseVisualStyleBackColor = true;
            this.button_Send_ID.Click += new System.EventHandler(this.button_Send_Click_ID);
            // 
            // box_Send_ID
            // 
            this.box_Send_ID.BackColor = System.Drawing.Color.White;
            this.box_Send_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Send_ID.FormattingEnabled = true;
            this.box_Send_ID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.box_Send_ID.Location = new System.Drawing.Point(111, 33);
            this.box_Send_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_Send_ID.Name = "box_Send_ID";
            this.box_Send_ID.Size = new System.Drawing.Size(154, 23);
            this.box_Send_ID.TabIndex = 16;
            // 
            // label_Send_ID
            // 
            this.label_Send_ID.AutoSize = true;
            this.label_Send_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Send_ID.Location = new System.Drawing.Point(15, 31);
            this.label_Send_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Send_ID.Name = "label_Send_ID";
            this.label_Send_ID.Size = new System.Drawing.Size(43, 20);
            this.label_Send_ID.TabIndex = 17;
            this.label_Send_ID.Text = "ID : ";
            // 
            // label_Send_Baud
            // 
            this.label_Send_Baud.AutoSize = true;
            this.label_Send_Baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Send_Baud.Location = new System.Drawing.Point(7, 38);
            this.label_Send_Baud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Send_Baud.Name = "label_Send_Baud";
            this.label_Send_Baud.Size = new System.Drawing.Size(98, 20);
            this.label_Send_Baud.TabIndex = 18;
            this.label_Send_Baud.Text = "Baudrate : ";
            // 
            // Bar_Position
            // 
            this.Bar_Position.Enabled = false;
            this.Bar_Position.LargeChange = 32;
            this.Bar_Position.Location = new System.Drawing.Point(108, 42);
            this.Bar_Position.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bar_Position.Maximum = 4095;
            this.Bar_Position.Name = "Bar_Position";
            this.Bar_Position.Size = new System.Drawing.Size(170, 45);
            this.Bar_Position.SmallChange = 4;
            this.Bar_Position.TabIndex = 20;
            this.Bar_Position.TickFrequency = 8;
            this.Bar_Position.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Bar_Position.Scroll += new System.EventHandler(this.Bar_Position_Scroll);
            this.Bar_Position.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bar_Position_MouseUp);
            // 
            // label_Send_Pos
            // 
            this.label_Send_Pos.AutoSize = true;
            this.label_Send_Pos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Send_Pos.ForeColor = System.Drawing.Color.White;
            this.label_Send_Pos.Location = new System.Drawing.Point(12, 51);
            this.label_Send_Pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Send_Pos.Name = "label_Send_Pos";
            this.label_Send_Pos.Size = new System.Drawing.Size(95, 23);
            this.label_Send_Pos.TabIndex = 21;
            this.label_Send_Pos.Text = "Position : ";
            // 
            // group_ID
            // 
            this.group_ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.group_ID.Controls.Add(this.label_ID_now);
            this.group_ID.Controls.Add(this.label_id_box);
            this.group_ID.Controls.Add(this.button_Send_ID);
            this.group_ID.Controls.Add(this.box_Send_ID);
            this.group_ID.Controls.Add(this.label_Send_ID);
            this.group_ID.ForeColor = System.Drawing.Color.White;
            this.group_ID.Location = new System.Drawing.Point(751, 269);
            this.group_ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_ID.Name = "group_ID";
            this.group_ID.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_ID.Size = new System.Drawing.Size(289, 177);
            this.group_ID.TabIndex = 22;
            this.group_ID.TabStop = false;
            this.group_ID.Visible = false;
            // 
            // label_ID_now
            // 
            this.label_ID_now.AutoSize = true;
            this.label_ID_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ID_now.Location = new System.Drawing.Point(15, 73);
            this.label_ID_now.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID_now.Name = "label_ID_now";
            this.label_ID_now.Size = new System.Drawing.Size(82, 20);
            this.label_ID_now.TabIndex = 38;
            this.label_ID_now.Text = "ID Now : ";
            // 
            // label_id_box
            // 
            this.label_id_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_box.AutoSize = true;
            this.label_id_box.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_id_box.Location = new System.Drawing.Point(115, 74);
            this.label_id_box.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_box.Name = "label_id_box";
            this.label_id_box.Size = new System.Drawing.Size(105, 19);
            this.label_id_box.TabIndex = 37;
            this.label_id_box.Text = "Nilai ID";
            this.label_id_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_center
            // 
            this.button_center.Location = new System.Drawing.Point(149, 123);
            this.button_center.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_center.Name = "button_center";
            this.button_center.Size = new System.Drawing.Size(88, 36);
            this.button_center.TabIndex = 23;
            this.button_center.Text = "Center";
            this.button_center.UseVisualStyleBackColor = true;
            this.button_center.Click += new System.EventHandler(this.button_center_Click);
            // 
            // checkBox_Pos
            // 
            this.checkBox_Pos.AutoSize = true;
            this.checkBox_Pos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Pos.ForeColor = System.Drawing.Color.White;
            this.checkBox_Pos.Location = new System.Drawing.Point(16, 123);
            this.checkBox_Pos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_Pos.Name = "checkBox_Pos";
            this.checkBox_Pos.Size = new System.Drawing.Size(95, 23);
            this.checkBox_Pos.TabIndex = 22;
            this.checkBox_Pos.Text = "Pos Mode";
            this.checkBox_Pos.UseVisualStyleBackColor = true;
            this.checkBox_Pos.CheckedChanged += new System.EventHandler(this.checkBox_Pos_CheckedChanged);
            // 
            // label_ID
            // 
            this.label_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.label_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ID.Location = new System.Drawing.Point(63, 95);
            this.label_ID.Margin = new System.Windows.Forms.Padding(0);
            this.label_ID.MinimumSize = new System.Drawing.Size(236, 40);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(236, 40);
            this.label_ID.TabIndex = 25;
            this.label_ID.Text = "ID : ";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ID.UseVisualStyleBackColor = false;
            this.label_ID.Click += new System.EventHandler(this.label_ID_Click);
            // 
            // label_Baudrate
            // 
            this.label_Baudrate.BackColor = System.Drawing.Color.Transparent;
            this.label_Baudrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.label_Baudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Baudrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Baudrate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Baudrate.Location = new System.Drawing.Point(63, 183);
            this.label_Baudrate.Margin = new System.Windows.Forms.Padding(0);
            this.label_Baudrate.MinimumSize = new System.Drawing.Size(236, 40);
            this.label_Baudrate.Name = "label_Baudrate";
            this.label_Baudrate.Size = new System.Drawing.Size(236, 40);
            this.label_Baudrate.TabIndex = 35;
            this.label_Baudrate.Text = "Baudrate : ";
            this.label_Baudrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Baudrate.UseVisualStyleBackColor = false;
            this.label_Baudrate.Click += new System.EventHandler(this.label_Baudrate_Click);
            // 
            // label_Pos_Now
            // 
            this.label_Pos_Now.BackColor = System.Drawing.Color.Transparent;
            this.label_Pos_Now.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.label_Pos_Now.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Pos_Now.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Pos_Now.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Pos_Now.Location = new System.Drawing.Point(63, 226);
            this.label_Pos_Now.Margin = new System.Windows.Forms.Padding(0);
            this.label_Pos_Now.MinimumSize = new System.Drawing.Size(236, 40);
            this.label_Pos_Now.Name = "label_Pos_Now";
            this.label_Pos_Now.Size = new System.Drawing.Size(236, 40);
            this.label_Pos_Now.TabIndex = 42;
            this.label_Pos_Now.Text = "Posisi Sekarang : ";
            this.label_Pos_Now.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Pos_Now.UseVisualStyleBackColor = false;
            this.label_Pos_Now.Click += new System.EventHandler(this.label_Pos_Now_Click);
            // 
            // table_single
            // 
            this.table_single.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_single.AutoScroll = true;
            this.table_single.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table_single.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.table_single.ColumnCount = 5;
            this.table_single.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.532026F));
            this.table_single.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.78122F));
            this.table_single.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.79702F));
            this.table_single.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.97085F));
            this.table_single.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.91889F));
            this.table_single.Controls.Add(this.button_i_gain, 1, 8);
            this.table_single.Controls.Add(this.button_d_gain, 1, 9);
            this.table_single.Controls.Add(this.button_p_gain, 1, 7);
            this.table_single.Controls.Add(this.label_Speed_Now, 1, 6);
            this.table_single.Controls.Add(this.label25, 4, 0);
            this.table_single.Controls.Add(this.label20, 0, 15);
            this.table_single.Controls.Add(this.label21, 0, 14);
            this.table_single.Controls.Add(this.label22, 0, 13);
            this.table_single.Controls.Add(this.label24, 0, 11);
            this.table_single.Controls.Add(this.label23, 0, 12);
            this.table_single.Controls.Add(this.label_temp, 2, 15);
            this.table_single.Controls.Add(this.label17, 1, 15);
            this.table_single.Controls.Add(this.label_i_gain, 2, 8);
            this.table_single.Controls.Add(this.label_d_gain, 2, 9);
            this.table_single.Controls.Add(this.label_p_gain, 2, 7);
            this.table_single.Controls.Add(this.label_prot, 1, 3);
            this.table_single.Controls.Add(this.label_ret_val, 2, 10);
            this.table_single.Controls.Add(this.label15, 4, 10);
            this.table_single.Controls.Add(this.label_model, 1, 1);
            this.table_single.Controls.Add(this.label_Actual, 3, 0);
            this.table_single.Controls.Add(this.label_return_delay, 1, 10);
            this.table_single.Controls.Add(this.label_Number, 0, 0);
            this.table_single.Controls.Add(this.label_Item, 1, 0);
            this.table_single.Controls.Add(this.label_Nilai, 2, 0);
            this.table_single.Controls.Add(this.label9, 0, 9);
            this.table_single.Controls.Add(this.label8, 0, 8);
            this.table_single.Controls.Add(this.label7, 0, 7);
            this.table_single.Controls.Add(this.label_Act_Speed, 3, 6);
            this.table_single.Controls.Add(this.label_Value_Now_Speed, 2, 6);
            this.table_single.Controls.Add(this.label_Unit_Speed, 4, 6);
            this.table_single.Controls.Add(this.label_Unit_Pos, 4, 5);
            this.table_single.Controls.Add(this.label_Act_Pos, 3, 5);
            this.table_single.Controls.Add(this.label_Value_Now_Pos, 2, 5);
            this.table_single.Controls.Add(this.label6, 0, 6);
            this.table_single.Controls.Add(this.label5, 0, 5);
            this.table_single.Controls.Add(this.label_Pos_Now, 1, 5);
            this.table_single.Controls.Add(this.label_Baudrate, 1, 4);
            this.table_single.Controls.Add(this.label4, 0, 4);
            this.table_single.Controls.Add(this.label_Value_Baud, 2, 4);
            this.table_single.Controls.Add(this.label_Value_Protocol, 2, 3);
            this.table_single.Controls.Add(this.label3, 0, 3);
            this.table_single.Controls.Add(this.label_Value_ID, 2, 2);
            this.table_single.Controls.Add(this.label_ID, 1, 2);
            this.table_single.Controls.Add(this.label2, 0, 2);
            this.table_single.Controls.Add(this.label1, 0, 1);
            this.table_single.Controls.Add(this.label_Value_Model, 2, 1);
            this.table_single.Controls.Add(this.label10, 0, 10);
            this.table_single.Controls.Add(this.label_Pos_Goal, 1, 13);
            this.table_single.Controls.Add(this.label_Value_Goal_Pos, 2, 13);
            this.table_single.Controls.Add(this.label_Torque, 1, 12);
            this.table_single.Controls.Add(this.label_Arus, 1, 11);
            this.table_single.Controls.Add(this.label_Value_Now_Current, 2, 11);
            this.table_single.Controls.Add(this.label_Act_Current, 3, 11);
            this.table_single.Controls.Add(this.label_Unit_Current, 4, 11);
            this.table_single.Controls.Add(this.label_Value_Goal_Speed, 2, 14);
            this.table_single.Controls.Add(this.label_Speed_Goal, 1, 14);
            this.table_single.Controls.Add(this.label_Value_Torque, 2, 12);
            this.table_single.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.table_single.ForeColor = System.Drawing.Color.White;
            this.table_single.Location = new System.Drawing.Point(10, 158);
            this.table_single.Margin = new System.Windows.Forms.Padding(0);
            this.table_single.MaximumSize = new System.Drawing.Size(0, 1038);
            this.table_single.MinimumSize = new System.Drawing.Size(708, 422);
            this.table_single.Name = "table_single";
            this.table_single.RowCount = 16;
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_single.Size = new System.Drawing.Size(708, 422);
            this.table_single.TabIndex = 35;
            // 
            // button_i_gain
            // 
            this.button_i_gain.BackColor = System.Drawing.Color.Transparent;
            this.button_i_gain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_i_gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_i_gain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_i_gain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_i_gain.Location = new System.Drawing.Point(63, 355);
            this.button_i_gain.Margin = new System.Windows.Forms.Padding(0);
            this.button_i_gain.MinimumSize = new System.Drawing.Size(236, 40);
            this.button_i_gain.Name = "button_i_gain";
            this.button_i_gain.Size = new System.Drawing.Size(236, 40);
            this.button_i_gain.TabIndex = 42;
            this.button_i_gain.Text = "I Gain :";
            this.button_i_gain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_i_gain.UseVisualStyleBackColor = false;
            this.button_i_gain.Click += new System.EventHandler(this.button_i_gain_Click);
            // 
            // button_d_gain
            // 
            this.button_d_gain.BackColor = System.Drawing.Color.Transparent;
            this.button_d_gain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_d_gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_d_gain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_d_gain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_d_gain.Location = new System.Drawing.Point(63, 398);
            this.button_d_gain.Margin = new System.Windows.Forms.Padding(0);
            this.button_d_gain.MinimumSize = new System.Drawing.Size(236, 40);
            this.button_d_gain.Name = "button_d_gain";
            this.button_d_gain.Size = new System.Drawing.Size(236, 40);
            this.button_d_gain.TabIndex = 43;
            this.button_d_gain.Text = "D Gain :";
            this.button_d_gain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_d_gain.UseVisualStyleBackColor = false;
            this.button_d_gain.Click += new System.EventHandler(this.button_d_gain_Click);
            // 
            // button_p_gain
            // 
            this.button_p_gain.BackColor = System.Drawing.Color.Transparent;
            this.button_p_gain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_p_gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_p_gain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_p_gain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_p_gain.Location = new System.Drawing.Point(63, 312);
            this.button_p_gain.Margin = new System.Windows.Forms.Padding(0);
            this.button_p_gain.MinimumSize = new System.Drawing.Size(236, 40);
            this.button_p_gain.Name = "button_p_gain";
            this.button_p_gain.Size = new System.Drawing.Size(236, 40);
            this.button_p_gain.TabIndex = 44;
            this.button_p_gain.Text = "P Gain :";
            this.button_p_gain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_p_gain.UseVisualStyleBackColor = false;
            this.button_p_gain.Click += new System.EventHandler(this.button_p_gain_Click);
            // 
            // label_Speed_Now
            // 
            this.label_Speed_Now.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Speed_Now.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Speed_Now.ForeColor = System.Drawing.Color.Transparent;
            this.label_Speed_Now.Location = new System.Drawing.Point(63, 269);
            this.label_Speed_Now.Margin = new System.Windows.Forms.Padding(0);
            this.label_Speed_Now.MinimumSize = new System.Drawing.Size(210, 40);
            this.label_Speed_Now.Name = "label_Speed_Now";
            this.label_Speed_Now.Size = new System.Drawing.Size(234, 40);
            this.label_Speed_Now.TabIndex = 42;
            this.label_Speed_Now.Text = "Kecepatan Sekarang :";
            this.label_Speed_Now.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(599, 3);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 46);
            this.label25.TabIndex = 52;
            this.label25.Text = "Satuan";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(3, 656);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 144);
            this.label20.TabIndex = 42;
            this.label20.Text = "15.";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(3, 613);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 40);
            this.label21.TabIndex = 43;
            this.label21.Text = "14.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(3, 570);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 40);
            this.label22.TabIndex = 45;
            this.label22.Text = "13.";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(3, 484);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 40);
            this.label24.TabIndex = 46;
            this.label24.Text = "11.";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(3, 527);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 40);
            this.label23.TabIndex = 44;
            this.label23.Text = "12.";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.BackColor = System.Drawing.Color.Transparent;
            this.label_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_temp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_temp.ForeColor = System.Drawing.Color.Transparent;
            this.label_temp.Location = new System.Drawing.Point(300, 656);
            this.label_temp.Margin = new System.Windows.Forms.Padding(0);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(139, 144);
            this.label_temp.TabIndex = 50;
            this.label_temp.Text = "temp val:";
            this.label_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(63, 656);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(234, 144);
            this.label17.TabIndex = 49;
            this.label17.Text = "Temperature : ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_i_gain
            // 
            this.label_i_gain.AutoSize = true;
            this.label_i_gain.BackColor = System.Drawing.Color.Transparent;
            this.label_i_gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_i_gain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_i_gain.ForeColor = System.Drawing.Color.Transparent;
            this.label_i_gain.Location = new System.Drawing.Point(300, 355);
            this.label_i_gain.Margin = new System.Windows.Forms.Padding(0);
            this.label_i_gain.Name = "label_i_gain";
            this.label_i_gain.Size = new System.Drawing.Size(139, 40);
            this.label_i_gain.TabIndex = 50;
            this.label_i_gain.Text = "I_now";
            this.label_i_gain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_d_gain
            // 
            this.label_d_gain.AutoSize = true;
            this.label_d_gain.BackColor = System.Drawing.Color.Transparent;
            this.label_d_gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_d_gain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_d_gain.ForeColor = System.Drawing.Color.Transparent;
            this.label_d_gain.Location = new System.Drawing.Point(300, 398);
            this.label_d_gain.Margin = new System.Windows.Forms.Padding(0);
            this.label_d_gain.Name = "label_d_gain";
            this.label_d_gain.Size = new System.Drawing.Size(139, 40);
            this.label_d_gain.TabIndex = 44;
            this.label_d_gain.Text = "D_now";
            this.label_d_gain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_p_gain
            // 
            this.label_p_gain.AutoSize = true;
            this.label_p_gain.BackColor = System.Drawing.Color.Transparent;
            this.label_p_gain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_p_gain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_p_gain.ForeColor = System.Drawing.Color.Transparent;
            this.label_p_gain.Location = new System.Drawing.Point(300, 312);
            this.label_p_gain.Margin = new System.Windows.Forms.Padding(0);
            this.label_p_gain.Name = "label_p_gain";
            this.label_p_gain.Size = new System.Drawing.Size(139, 40);
            this.label_p_gain.TabIndex = 51;
            this.label_p_gain.Text = "P_now";
            this.label_p_gain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_prot
            // 
            this.label_prot.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_prot.Location = new System.Drawing.Point(63, 138);
            this.label_prot.Margin = new System.Windows.Forms.Padding(0);
            this.label_prot.MinimumSize = new System.Drawing.Size(210, 40);
            this.label_prot.Name = "label_prot";
            this.label_prot.Size = new System.Drawing.Size(231, 42);
            this.label_prot.TabIndex = 49;
            this.label_prot.Text = "Protokol";
            this.label_prot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ret_val
            // 
            this.label_ret_val.AutoSize = true;
            this.label_ret_val.BackColor = System.Drawing.Color.Transparent;
            this.label_ret_val.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ret_val.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ret_val.ForeColor = System.Drawing.Color.Transparent;
            this.label_ret_val.Location = new System.Drawing.Point(300, 441);
            this.label_ret_val.Margin = new System.Windows.Forms.Padding(0);
            this.label_ret_val.Name = "label_ret_val";
            this.label_ret_val.Size = new System.Drawing.Size(139, 40);
            this.label_ret_val.TabIndex = 48;
            this.label_ret_val.Text = "Return Val";
            this.label_ret_val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(599, 441);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 40);
            this.label15.TabIndex = 45;
            this.label15.Text = "µ(S)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.BackColor = System.Drawing.Color.Transparent;
            this.label_model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_model.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_model.Location = new System.Drawing.Point(63, 52);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.MinimumSize = new System.Drawing.Size(236, 40);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(236, 40);
            this.label_model.TabIndex = 40;
            this.label_model.Text = "Nilai Model";
            this.label_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_return_delay
            // 
            this.label_return_delay.AutoSize = true;
            this.label_return_delay.BackColor = System.Drawing.Color.Transparent;
            this.label_return_delay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_return_delay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_return_delay.ForeColor = System.Drawing.Color.Transparent;
            this.label_return_delay.Location = new System.Drawing.Point(63, 441);
            this.label_return_delay.Margin = new System.Windows.Forms.Padding(0);
            this.label_return_delay.MinimumSize = new System.Drawing.Size(236, 40);
            this.label_return_delay.Name = "label_return_delay";
            this.label_return_delay.Size = new System.Drawing.Size(236, 40);
            this.label_return_delay.TabIndex = 46;
            this.label_return_delay.Text = "Return Delay Time :";
            this.label_return_delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Pos_Goal
            // 
            this.label_Pos_Goal.AutoSize = true;
            this.label_Pos_Goal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Pos_Goal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Pos_Goal.Location = new System.Drawing.Point(63, 570);
            this.label_Pos_Goal.Margin = new System.Windows.Forms.Padding(0);
            this.label_Pos_Goal.MinimumSize = new System.Drawing.Size(210, 40);
            this.label_Pos_Goal.Name = "label_Pos_Goal";
            this.label_Pos_Goal.Size = new System.Drawing.Size(234, 40);
            this.label_Pos_Goal.TabIndex = 48;
            this.label_Pos_Goal.Text = "Goal Posisi :";
            this.label_Pos_Goal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Torque
            // 
            this.label_Torque.AutoSize = true;
            this.label_Torque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Torque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Torque.Location = new System.Drawing.Point(63, 527);
            this.label_Torque.Margin = new System.Windows.Forms.Padding(0);
            this.label_Torque.MinimumSize = new System.Drawing.Size(210, 40);
            this.label_Torque.Name = "label_Torque";
            this.label_Torque.Size = new System.Drawing.Size(234, 40);
            this.label_Torque.TabIndex = 49;
            this.label_Torque.Text = "Status Torsi :";
            this.label_Torque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Arus
            // 
            this.label_Arus.AutoSize = true;
            this.label_Arus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Arus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Arus.Location = new System.Drawing.Point(63, 484);
            this.label_Arus.Margin = new System.Windows.Forms.Padding(0);
            this.label_Arus.MinimumSize = new System.Drawing.Size(210, 40);
            this.label_Arus.Name = "label_Arus";
            this.label_Arus.Size = new System.Drawing.Size(234, 40);
            this.label_Arus.TabIndex = 50;
            this.label_Arus.Text = "Arus Sekarang :";
            this.label_Arus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Speed_Goal
            // 
            this.label_Speed_Goal.AutoSize = true;
            this.label_Speed_Goal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Speed_Goal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Speed_Goal.Location = new System.Drawing.Point(63, 613);
            this.label_Speed_Goal.Margin = new System.Windows.Forms.Padding(0);
            this.label_Speed_Goal.MinimumSize = new System.Drawing.Size(210, 40);
            this.label_Speed_Goal.Name = "label_Speed_Goal";
            this.label_Speed_Goal.Size = new System.Drawing.Size(234, 40);
            this.label_Speed_Goal.TabIndex = 49;
            this.label_Speed_Goal.Text = "Goal Kecepatan : ";
            this.label_Speed_Goal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group_Baud
            // 
            this.group_Baud.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.group_Baud.Controls.Add(this.label11);
            this.group_Baud.Controls.Add(this.label_Now_baud);
            this.group_Baud.Controls.Add(this.box_Send_Baud);
            this.group_Baud.Controls.Add(this.button_send_baud);
            this.group_Baud.Controls.Add(this.label_Send_Baud);
            this.group_Baud.ForeColor = System.Drawing.Color.White;
            this.group_Baud.Location = new System.Drawing.Point(751, 268);
            this.group_Baud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_Baud.Name = "group_Baud";
            this.group_Baud.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_Baud.Size = new System.Drawing.Size(288, 177);
            this.group_Baud.TabIndex = 39;
            this.group_Baud.TabStop = false;
            this.group_Baud.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(15, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Baud Now : ";
            // 
            // label_Now_baud
            // 
            this.label_Now_baud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Now_baud.AutoSize = true;
            this.label_Now_baud.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Now_baud.Location = new System.Drawing.Point(132, 75);
            this.label_Now_baud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Now_baud.Name = "label_Now_baud";
            this.label_Now_baud.Size = new System.Drawing.Size(129, 19);
            this.label_Now_baud.TabIndex = 37;
            this.label_Now_baud.Text = "Nilai Baud";
            this.label_Now_baud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_send_baud
            // 
            this.button_send_baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_send_baud.Location = new System.Drawing.Point(55, 119);
            this.button_send_baud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_send_baud.Name = "button_send_baud";
            this.button_send_baud.Size = new System.Drawing.Size(196, 44);
            this.button_send_baud.TabIndex = 15;
            this.button_send_baud.Text = "SEND";
            this.button_send_baud.UseVisualStyleBackColor = true;
            this.button_send_baud.Click += new System.EventHandler(this.button_send_baud_Click);
            // 
            // group_Pos
            // 
            this.group_Pos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.group_Pos.Controls.Add(this.label12);
            this.group_Pos.Controls.Add(this.label_Now_pos);
            this.group_Pos.Controls.Add(this.button_center);
            this.group_Pos.Controls.Add(this.checkBox_Pos);
            this.group_Pos.Controls.Add(this.label_Send_Pos);
            this.group_Pos.Controls.Add(this.Bar_Position);
            this.group_Pos.Location = new System.Drawing.Point(752, 270);
            this.group_Pos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_Pos.Name = "group_Pos";
            this.group_Pos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_Pos.Size = new System.Drawing.Size(288, 172);
            this.group_Pos.TabIndex = 40;
            this.group_Pos.TabStop = false;
            this.group_Pos.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Pos Now : ";
            // 
            // label_Now_pos
            // 
            this.label_Now_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Now_pos.AutoSize = true;
            this.label_Now_pos.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Now_pos.ForeColor = System.Drawing.Color.White;
            this.label_Now_pos.Location = new System.Drawing.Point(138, 91);
            this.label_Now_pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Now_pos.Name = "label_Now_pos";
            this.label_Now_pos.Size = new System.Drawing.Size(117, 19);
            this.label_Now_pos.TabIndex = 37;
            this.label_Now_pos.Text = "Nilai Pos";
            this.label_Now_pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_P_gain
            // 
            this.group_P_gain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.group_P_gain.Controls.Add(this.button_send_p_gain);
            this.group_P_gain.Controls.Add(this.box_p_gain);
            this.group_P_gain.Controls.Add(this.label16);
            this.group_P_gain.Controls.Add(this.label_P_now);
            this.group_P_gain.Controls.Add(this.label_P_group);
            this.group_P_gain.Location = new System.Drawing.Point(751, 272);
            this.group_P_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_P_gain.Name = "group_P_gain";
            this.group_P_gain.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_P_gain.Size = new System.Drawing.Size(288, 172);
            this.group_P_gain.TabIndex = 41;
            this.group_P_gain.TabStop = false;
            this.group_P_gain.Visible = false;
            // 
            // button_send_p_gain
            // 
            this.button_send_p_gain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_send_p_gain.Location = new System.Drawing.Point(46, 119);
            this.button_send_p_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_send_p_gain.Name = "button_send_p_gain";
            this.button_send_p_gain.Size = new System.Drawing.Size(196, 44);
            this.button_send_p_gain.TabIndex = 40;
            this.button_send_p_gain.Text = "SEND";
            this.button_send_p_gain.UseVisualStyleBackColor = true;
            this.button_send_p_gain.Click += new System.EventHandler(this.button_send_p_gain_Click);
            // 
            // box_p_gain
            // 
            this.box_p_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_p_gain.FormattingEnabled = true;
            this.box_p_gain.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254"});
            this.box_p_gain.Location = new System.Drawing.Point(132, 38);
            this.box_p_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_p_gain.Name = "box_p_gain";
            this.box_p_gain.Size = new System.Drawing.Size(140, 23);
            this.box_p_gain.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 70);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "P Gain Now :";
            // 
            // label_P_now
            // 
            this.label_P_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_P_now.AutoSize = true;
            this.label_P_now.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_P_now.ForeColor = System.Drawing.Color.White;
            this.label_P_now.Location = new System.Drawing.Point(144, 74);
            this.label_P_now.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_P_now.Name = "label_P_now";
            this.label_P_now.Size = new System.Drawing.Size(93, 19);
            this.label_P_now.TabIndex = 37;
            this.label_P_now.Text = "Nilai P";
            this.label_P_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_P_group
            // 
            this.label_P_group.AutoSize = true;
            this.label_P_group.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_P_group.ForeColor = System.Drawing.Color.White;
            this.label_P_group.Location = new System.Drawing.Point(12, 33);
            this.label_P_group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_P_group.Name = "label_P_group";
            this.label_P_group.Size = new System.Drawing.Size(86, 23);
            this.label_P_group.TabIndex = 21;
            this.label_P_group.Text = "P Gain : ";
            // 
            // List_Servo_Single
            // 
            this.List_Servo_Single.AllowUserToAddRows = false;
            this.List_Servo_Single.AllowUserToResizeColumns = false;
            this.List_Servo_Single.AllowUserToResizeRows = false;
            this.List_Servo_Single.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_Servo_Single.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.List_Servo_Single.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_Servo_Single.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_Servo_Single.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Servo_Single.Location = new System.Drawing.Point(9, 1);
            this.List_Servo_Single.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.List_Servo_Single.Name = "List_Servo_Single";
            this.List_Servo_Single.RowHeadersWidth = 51;
            this.List_Servo_Single.Size = new System.Drawing.Size(285, 136);
            this.List_Servo_Single.TabIndex = 41;
            this.List_Servo_Single.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_Servo_Single_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Connect_Form.Properties.Resources.MX_64;
            this.pictureBox1.Location = new System.Drawing.Point(849, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // group_i_gain
            // 
            this.group_i_gain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.group_i_gain.Controls.Add(this.button_i_send);
            this.group_i_gain.Controls.Add(this.box_i_gain);
            this.group_i_gain.Controls.Add(this.label13);
            this.group_i_gain.Controls.Add(this.label_I_now);
            this.group_i_gain.Controls.Add(this.label18);
            this.group_i_gain.Location = new System.Drawing.Point(751, 271);
            this.group_i_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_i_gain.Name = "group_i_gain";
            this.group_i_gain.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_i_gain.Size = new System.Drawing.Size(288, 172);
            this.group_i_gain.TabIndex = 42;
            this.group_i_gain.TabStop = false;
            this.group_i_gain.Visible = false;
            // 
            // button_i_send
            // 
            this.button_i_send.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_i_send.Location = new System.Drawing.Point(46, 119);
            this.button_i_send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_i_send.Name = "button_i_send";
            this.button_i_send.Size = new System.Drawing.Size(196, 44);
            this.button_i_send.TabIndex = 40;
            this.button_i_send.Text = "SEND";
            this.button_i_send.UseVisualStyleBackColor = true;
            this.button_i_send.Click += new System.EventHandler(this.button_i_send_Click);
            // 
            // box_i_gain
            // 
            this.box_i_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_i_gain.FormattingEnabled = true;
            this.box_i_gain.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254"});
            this.box_i_gain.Location = new System.Drawing.Point(132, 38);
            this.box_i_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_i_gain.Name = "box_i_gain";
            this.box_i_gain.Size = new System.Drawing.Size(140, 23);
            this.box_i_gain.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "I Gain Now :";
            // 
            // label_I_now
            // 
            this.label_I_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_I_now.AutoSize = true;
            this.label_I_now.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_I_now.ForeColor = System.Drawing.Color.White;
            this.label_I_now.Location = new System.Drawing.Point(144, 74);
            this.label_I_now.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_I_now.Name = "label_I_now";
            this.label_I_now.Size = new System.Drawing.Size(93, 19);
            this.label_I_now.TabIndex = 37;
            this.label_I_now.Text = "Nilai I";
            this.label_I_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 33);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 21;
            this.label18.Text = "I Gain : ";
            // 
            // group_d_gain
            // 
            this.group_d_gain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.group_d_gain.Controls.Add(this.button_d_send);
            this.group_d_gain.Controls.Add(this.box_d_gain);
            this.group_d_gain.Controls.Add(this.label14);
            this.group_d_gain.Controls.Add(this.label_d_now);
            this.group_d_gain.Controls.Add(this.label26);
            this.group_d_gain.Location = new System.Drawing.Point(751, 273);
            this.group_d_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_d_gain.Name = "group_d_gain";
            this.group_d_gain.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_d_gain.Size = new System.Drawing.Size(288, 172);
            this.group_d_gain.TabIndex = 43;
            this.group_d_gain.TabStop = false;
            this.group_d_gain.Visible = false;
            // 
            // button_d_send
            // 
            this.button_d_send.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_d_send.Location = new System.Drawing.Point(46, 119);
            this.button_d_send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_d_send.Name = "button_d_send";
            this.button_d_send.Size = new System.Drawing.Size(196, 44);
            this.button_d_send.TabIndex = 40;
            this.button_d_send.Text = "SEND";
            this.button_d_send.UseVisualStyleBackColor = true;
            this.button_d_send.Click += new System.EventHandler(this.button_d_send_Click);
            // 
            // box_d_gain
            // 
            this.box_d_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_d_gain.FormattingEnabled = true;
            this.box_d_gain.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254"});
            this.box_d_gain.Location = new System.Drawing.Point(132, 38);
            this.box_d_gain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_d_gain.Name = "box_d_gain";
            this.box_d_gain.Size = new System.Drawing.Size(140, 23);
            this.box_d_gain.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 70);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "D Gain Now :";
            // 
            // label_d_now
            // 
            this.label_d_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_d_now.AutoSize = true;
            this.label_d_now.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_d_now.ForeColor = System.Drawing.Color.White;
            this.label_d_now.Location = new System.Drawing.Point(144, 74);
            this.label_d_now.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_d_now.Name = "label_d_now";
            this.label_d_now.Size = new System.Drawing.Size(93, 19);
            this.label_d_now.TabIndex = 37;
            this.label_d_now.Text = "Nilai D";
            this.label_d_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(12, 33);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 23);
            this.label26.TabIndex = 21;
            this.label26.Text = "D Gain : ";
            // 
            // button_rescan
            // 
            this.button_rescan.BackColor = System.Drawing.Color.White;
            this.button_rescan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_rescan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_rescan.ForeColor = System.Drawing.Color.Black;
            this.button_rescan.Location = new System.Drawing.Point(301, 1);
            this.button_rescan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_rescan.Name = "button_rescan";
            this.button_rescan.Size = new System.Drawing.Size(106, 32);
            this.button_rescan.TabIndex = 44;
            this.button_rescan.Text = "Scan Ulang";
            this.button_rescan.UseVisualStyleBackColor = false;
            this.button_rescan.Click += new System.EventHandler(this.button_rescan_Click);
            // 
            // Single_Servo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1060, 594);
            this.Controls.Add(this.button_rescan);
            this.Controls.Add(this.group_d_gain);
            this.Controls.Add(this.group_i_gain);
            this.Controls.Add(this.group_P_gain);
            this.Controls.Add(this.List_Servo_Single);
            this.Controls.Add(this.group_Pos);
            this.Controls.Add(this.group_Baud);
            this.Controls.Add(this.table_single);
            this.Controls.Add(this.group_ID);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1060, 594);
            this.Name = "Single_Servo";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Single_Servo_FormClosing);
            this.Load += new System.EventHandler(this.Single_Servo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Position)).EndInit();
            this.group_ID.ResumeLayout(false);
            this.group_ID.PerformLayout();
            this.table_single.ResumeLayout(false);
            this.table_single.PerformLayout();
            this.group_Baud.ResumeLayout(false);
            this.group_Baud.PerformLayout();
            this.group_Pos.ResumeLayout(false);
            this.group_Pos.PerformLayout();
            this.group_P_gain.ResumeLayout(false);
            this.group_P_gain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_Servo_Single)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_i_gain.ResumeLayout(false);
            this.group_i_gain.PerformLayout();
            this.group_d_gain.ResumeLayout(false);
            this.group_d_gain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Item;
        private System.Windows.Forms.Label label_Nilai;
        private System.Windows.Forms.Label label_Actual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Value_Goal_Speed;
        private System.Windows.Forms.Label label_Value_Now_Current;
        private System.Windows.Forms.Label label_Value_ID;
        private System.Windows.Forms.Label label_Value_Torque;
        private System.Windows.Forms.Label label_Value_Goal_Pos;
        private System.Windows.Forms.Label label_Value_Now_Speed;
        private System.Windows.Forms.Label label_Value_Now_Pos;
        private System.Windows.Forms.Label label_Value_Baud;
        private System.Windows.Forms.Label label_Value_Protocol;
        private System.Windows.Forms.Label label_Value_Model;
        private System.Windows.Forms.Label label_Act_Current;
        private System.Windows.Forms.Label label_Act_Speed;
        private System.Windows.Forms.Label label_Act_Pos;
        private System.Windows.Forms.Button Disconnect;
        private System.IO.Ports.SerialPort Serial_Port2;
        private System.Windows.Forms.ComboBox box_Send_Baud;
        private System.Windows.Forms.Button button_Send_ID;
        private System.Windows.Forms.ComboBox box_Send_ID;
        private System.Windows.Forms.Label label_Send_ID;
        private System.Windows.Forms.Label label_Send_Baud;
        private System.Windows.Forms.TrackBar Bar_Position;
        private System.Windows.Forms.Label label_Send_Pos;
        private System.Windows.Forms.GroupBox group_ID;
        private System.Windows.Forms.Label label_Unit_Current;
        private System.Windows.Forms.Label label_Unit_Pos;
        private System.Windows.Forms.Label label_Unit_Speed;
        private System.Windows.Forms.CheckBox checkBox_Pos;
        private System.Windows.Forms.Button button_center;
        private System.Windows.Forms.Button label_ID;
        private System.Windows.Forms.Button label_Baudrate;
        private System.Windows.Forms.Button label_Pos_Now;
        private System.Windows.Forms.TableLayoutPanel table_single;
        private System.Windows.Forms.Label label_ID_now;
        private System.Windows.Forms.Label label_id_box;
        private System.Windows.Forms.GroupBox group_Baud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Now_baud;
        private System.Windows.Forms.Button button_send_baud;
        private System.Windows.Forms.GroupBox group_Pos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_Now_pos;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_Torque;
        private System.Windows.Forms.Label label_Pos_Goal;
        private System.Windows.Forms.Label label_Arus;
        private System.Windows.Forms.Label label_Speed_Goal;
        private System.Windows.Forms.Label label_prot;
        private System.Windows.Forms.Label label_i_gain;
        private System.Windows.Forms.Label label_d_gain;
        private System.Windows.Forms.Label label_p_gain;
        private System.Windows.Forms.Label label_ret_val;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_return_delay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Label label_Speed_Now;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox group_P_gain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_P_now;
        private System.Windows.Forms.Label label_P_group;
        private System.Windows.Forms.ComboBox box_p_gain;
        private System.Windows.Forms.Button button_send_p_gain;
        private System.Windows.Forms.Button button_i_gain;
        private System.Windows.Forms.Button button_d_gain;
        private System.Windows.Forms.Button button_p_gain;
        private System.Windows.Forms.GroupBox group_i_gain;
        private System.Windows.Forms.Button button_i_send;
        private System.Windows.Forms.ComboBox box_i_gain;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_I_now;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox group_d_gain;
        private System.Windows.Forms.Button button_d_send;
        private System.Windows.Forms.ComboBox box_d_gain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_d_now;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView List_Servo_Single;
        private System.Windows.Forms.Button button_rescan;
    }
}