namespace Connect_Form
{
    partial class Connection
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
            //System.Text.ASCIIEncoding.ASCIIEncodingSealed asciiEncodingSealed1 = new System.Text.ASCIIEncoding.ASCIIEncodingSealed();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.box_Ports = new System.Windows.Forms.ComboBox();
            this.box_Bauds = new System.Windows.Forms.ComboBox();
            this.Label_Ports = new System.Windows.Forms.Label();
            this.label_Baud = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.Serial_Port = new System.IO.Ports.SerialPort(this.components);
            this.panelSamping = new System.Windows.Forms.Panel();
            this.button_single_servo = new System.Windows.Forms.Button();
            this.button_multiple_servo = new System.Windows.Forms.Button();
            this.button_Connection = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_progress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.progress_Connect = new System.Windows.Forms.ProgressBar();
            this.group_connection = new System.Windows.Forms.GroupBox();
            this.panel_bawah = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_clear_debug = new System.Windows.Forms.Button();
            this.check_autoscroll = new System.Windows.Forms.CheckBox();
            this.panelSamping.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.group_connection.SuspendLayout();
            this.panel_bawah.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_Ports
            // 
            this.box_Ports.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.box_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Ports.Enabled = false;
            this.box_Ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_Ports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_Ports.ForeColor = System.Drawing.Color.Navy;
            this.box_Ports.FormattingEnabled = true;
            this.box_Ports.ItemHeight = 22;
            this.box_Ports.Location = new System.Drawing.Point(150, 52);
            this.box_Ports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_Ports.Name = "box_Ports";
            this.box_Ports.Size = new System.Drawing.Size(140, 30);
            this.box_Ports.TabIndex = 3;
            // 
            // box_Bauds
            // 
            this.box_Bauds.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.box_Bauds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Bauds.Enabled = false;
            this.box_Bauds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_Bauds.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_Bauds.ForeColor = System.Drawing.Color.Navy;
            this.box_Bauds.FormattingEnabled = true;
            this.box_Bauds.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200",
            "500000",
            "1000000",
            "2000000"});
            this.box_Bauds.Location = new System.Drawing.Point(150, 111);
            this.box_Bauds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.box_Bauds.Name = "box_Bauds";
            this.box_Bauds.Size = new System.Drawing.Size(140, 30);
            this.box_Bauds.TabIndex = 4;
            // 
            // Label_Ports
            // 
            this.Label_Ports.AutoSize = true;
            this.Label_Ports.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label_Ports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Ports.Location = new System.Drawing.Point(59, 54);
            this.Label_Ports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Ports.Name = "Label_Ports";
            this.Label_Ports.Size = new System.Drawing.Size(68, 23);
            this.Label_Ports.TabIndex = 5;
            this.Label_Ports.Text = "Ports : ";
            // 
            // label_Baud
            // 
            this.label_Baud.AutoSize = true;
            this.label_Baud.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Baud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Baud.Location = new System.Drawing.Point(16, 111);
            this.label_Baud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(110, 23);
            this.label_Baud.TabIndex = 6;
            this.label_Baud.Text = "Baudrate : ";
            // 
            // label_Status
            // 
            this.label_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Status.Location = new System.Drawing.Point(899, 551);
            this.label_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(79, 23);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Status : ";
            // 
            // Serial_Port
            // 
            this.Serial_Port.BaudRate = 9600;
            this.Serial_Port.DataBits = 8;
            this.Serial_Port.DiscardNull = false;
            this.Serial_Port.DtrEnable = false;
            //asciiEncodingSealed1.DecoderFallback = decoderReplacementFallback1;
            //asciiEncodingSealed1.EncoderFallback = encoderReplacementFallback1;
            //this.Serial_Port.Encoding = asciiEncodingSealed1;
            this.Serial_Port.Handshake = System.IO.Ports.Handshake.None;
            this.Serial_Port.NewLine = "\n";
            this.Serial_Port.Parity = System.IO.Ports.Parity.None;
            this.Serial_Port.ParityReplace = ((byte)(63));
            this.Serial_Port.PortName = "COM1";
            this.Serial_Port.ReadBufferSize = 4096;
            this.Serial_Port.ReadTimeout = -1;
            this.Serial_Port.ReceivedBytesThreshold = 1;
            this.Serial_Port.RtsEnable = false;
            this.Serial_Port.StopBits = System.IO.Ports.StopBits.One;
            this.Serial_Port.WriteBufferSize = 2048;
            this.Serial_Port.WriteTimeout = -1;
            // 
            // panelSamping
            // 
            this.panelSamping.AutoSize = true;
            this.panelSamping.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSamping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.panelSamping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSamping.Controls.Add(this.button_single_servo);
            this.panelSamping.Controls.Add(this.button_multiple_servo);
            this.panelSamping.Controls.Add(this.button_Connection);
            this.panelSamping.Controls.Add(this.panelLogo);
            this.panelSamping.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSamping.Location = new System.Drawing.Point(0, 0);
            this.panelSamping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSamping.Name = "panelSamping";
            this.panelSamping.Size = new System.Drawing.Size(243, 763);
            this.panelSamping.TabIndex = 9;
            // 
            // button_single_servo
            // 
            this.button_single_servo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_single_servo.Enabled = false;
            this.button_single_servo.FlatAppearance.BorderSize = 0;
            this.button_single_servo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_single_servo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_single_servo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_single_servo.Image = global::Connect_Form.Properties.Resources.Single_Servo_Control1;
            this.button_single_servo.Location = new System.Drawing.Point(1, 324);
            this.button_single_servo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_single_servo.MinimumSize = new System.Drawing.Size(233, 165);
            this.button_single_servo.Name = "button_single_servo";
            this.button_single_servo.Size = new System.Drawing.Size(233, 165);
            this.button_single_servo.TabIndex = 6;
            this.button_single_servo.Text = "Single Servo Control";
            this.button_single_servo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_single_servo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_single_servo.UseVisualStyleBackColor = true;
            this.button_single_servo.Click += new System.EventHandler(this.button_single_servo_Click);
            // 
            // button_multiple_servo
            // 
            this.button_multiple_servo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_multiple_servo.Enabled = false;
            this.button_multiple_servo.FlatAppearance.BorderSize = 0;
            this.button_multiple_servo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multiple_servo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multiple_servo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_multiple_servo.Image = global::Connect_Form.Properties.Resources.Multiple_Servos_Control;
            this.button_multiple_servo.Location = new System.Drawing.Point(1, 152);
            this.button_multiple_servo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_multiple_servo.MinimumSize = new System.Drawing.Size(233, 165);
            this.button_multiple_servo.Name = "button_multiple_servo";
            this.button_multiple_servo.Size = new System.Drawing.Size(233, 165);
            this.button_multiple_servo.TabIndex = 3;
            this.button_multiple_servo.Text = "Multiple Servos Control";
            this.button_multiple_servo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_multiple_servo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_multiple_servo.UseVisualStyleBackColor = true;
            this.button_multiple_servo.Click += new System.EventHandler(this.button_multiple_servo_Click);
            // 
            // button_Connection
            // 
            this.button_Connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Connection.FlatAppearance.BorderSize = 0;
            this.button_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Connection.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Connection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Connection.Image = global::Connect_Form.Properties.Resources._1connection;
            this.button_Connection.Location = new System.Drawing.Point(1, 496);
            this.button_Connection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Connection.MinimumSize = new System.Drawing.Size(233, 165);
            this.button_Connection.Name = "button_Connection";
            this.button_Connection.Size = new System.Drawing.Size(233, 165);
            this.button_Connection.TabIndex = 1;
            this.button_Connection.Text = "Connection";
            this.button_Connection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Connection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Connection.UseVisualStyleBackColor = true;
            this.button_Connection.Click += new System.EventHandler(this.button_Connection_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.BackgroundImage = global::Connect_Form.Properties.Resources.Servo_Logo2;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.MinimumSize = new System.Drawing.Size(237, 115);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 115);
            this.panelLogo.TabIndex = 0;
            // 
            // debugBox
            // 
            this.debugBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugBox.Location = new System.Drawing.Point(0, 0);
            this.debugBox.Margin = new System.Windows.Forms.Padding(0);
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(892, 166);
            this.debugBox.TabIndex = 0;
            this.debugBox.Text = "";
            this.debugBox.TextChanged += new System.EventHandler(this.debugBox_TextChanged);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackColor = System.Drawing.Color.Transparent;
            this.button_Disconnect.BackgroundImage = global::Connect_Form.Properties.Resources.Disconnect;
            this.button_Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Disconnect.Location = new System.Drawing.Point(239, 173);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(52, 52);
            this.button_Disconnect.TabIndex = 1;
            this.button_Disconnect.UseVisualStyleBackColor = false;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.BackgroundImage = global::Connect_Form.Properties.Resources.Connect1;
            this.button_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Connect.Enabled = false;
            this.button_Connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Connect.Location = new System.Drawing.Point(150, 173);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(52, 52);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_progress
            // 
            this.label_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_progress.AutoSize = true;
            this.label_progress.BackColor = System.Drawing.Color.Silver;
            this.label_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_progress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_progress.ForeColor = System.Drawing.Color.Navy;
            this.label_progress.Location = new System.Drawing.Point(995, 551);
            this.label_progress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(41, 22);
            this.label_progress.TabIndex = 11;
            this.label_progress.Text = "0 %";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.progress_Connect);
            this.panelChildForm.Controls.Add(this.label_Status);
            this.panelChildForm.Controls.Add(this.label_progress);
            this.panelChildForm.Controls.Add(this.group_connection);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(243, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1060, 595);
            this.panelChildForm.TabIndex = 11;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // progress_Connect
            // 
            this.progress_Connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress_Connect.Location = new System.Drawing.Point(0, 583);
            this.progress_Connect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progress_Connect.Name = "progress_Connect";
            this.progress_Connect.Size = new System.Drawing.Size(1060, 12);
            this.progress_Connect.TabIndex = 13;
            // 
            // group_connection
            // 
            this.group_connection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group_connection.BackColor = System.Drawing.Color.Transparent;
            this.group_connection.Controls.Add(this.box_Bauds);
            this.group_connection.Controls.Add(this.Label_Ports);
            this.group_connection.Controls.Add(this.box_Ports);
            this.group_connection.Controls.Add(this.label_Baud);
            this.group_connection.Controls.Add(this.button_Connect);
            this.group_connection.Controls.Add(this.button_Disconnect);
            this.group_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_connection.Location = new System.Drawing.Point(354, 167);
            this.group_connection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_connection.Name = "group_connection";
            this.group_connection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_connection.Size = new System.Drawing.Size(332, 264);
            this.group_connection.TabIndex = 12;
            this.group_connection.TabStop = false;
            this.group_connection.Visible = false;
            // 
            // panel_bawah
            // 
            this.panel_bawah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bawah.Controls.Add(this.panel1);
            this.panel_bawah.Controls.Add(this.debugBox);
            this.panel_bawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bawah.Location = new System.Drawing.Point(243, 595);
            this.panel_bawah.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_bawah.Name = "panel_bawah";
            this.panel_bawah.Size = new System.Drawing.Size(1060, 168);
            this.panel_bawah.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_clear_debug);
            this.panel1.Controls.Add(this.check_autoscroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(892, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(166, 163);
            this.panel1.MinimumSize = new System.Drawing.Size(166, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 163);
            this.panel1.TabIndex = 1;
            // 
            // button_clear_debug
            // 
            this.button_clear_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_debug.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_clear_debug.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear_debug.ForeColor = System.Drawing.Color.Transparent;
            this.button_clear_debug.Location = new System.Drawing.Point(56, 130);
            this.button_clear_debug.Margin = new System.Windows.Forms.Padding(0);
            this.button_clear_debug.Name = "button_clear_debug";
            this.button_clear_debug.Size = new System.Drawing.Size(106, 27);
            this.button_clear_debug.TabIndex = 1;
            this.button_clear_debug.Text = "Clear Debug";
            this.button_clear_debug.UseVisualStyleBackColor = true;
            this.button_clear_debug.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_autoscroll
            // 
            this.check_autoscroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.check_autoscroll.AutoSize = true;
            this.check_autoscroll.Checked = true;
            this.check_autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_autoscroll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_autoscroll.ForeColor = System.Drawing.Color.Transparent;
            this.check_autoscroll.Location = new System.Drawing.Point(74, 106);
            this.check_autoscroll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check_autoscroll.Name = "check_autoscroll";
            this.check_autoscroll.Size = new System.Drawing.Size(91, 21);
            this.check_autoscroll.TabIndex = 0;
            this.check_autoscroll.Text = "AutoScroll";
            this.check_autoscroll.UseVisualStyleBackColor = true;
            this.check_autoscroll.CheckedChanged += new System.EventHandler(this.check_autoscroll_CheckedChanged);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1303, 763);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel_bawah);
            this.Controls.Add(this.panelSamping);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1319, 781);
            this.Name = "Connection";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connection_FormClosing);
            this.Load += new System.EventHandler(this.Connection_Load);
            this.panelSamping.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.group_connection.ResumeLayout(false);
            this.group_connection.PerformLayout();
            this.panel_bawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.ComboBox box_Ports;
        private System.Windows.Forms.ComboBox box_Bauds;
        private System.Windows.Forms.Label Label_Ports;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.Label label_Status;
        private System.IO.Ports.SerialPort Serial_Port;
        private System.Windows.Forms.Panel panelSamping;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button_Connection;
        private System.Windows.Forms.Button button_multiple_servo;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.GroupBox group_connection;
        private System.Windows.Forms.ProgressBar progress_Connect;
        private System.Windows.Forms.Button button_single_servo;
        public System.Windows.Forms.RichTextBox debugBox;
        private System.Windows.Forms.Panel panel_bawah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox check_autoscroll;
        private System.Windows.Forms.Button button_clear_debug;
    }
}

