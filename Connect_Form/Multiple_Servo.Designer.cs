namespace Connect_Form
{
    partial class Multiple_Servo
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
            this.Disconnect = new System.Windows.Forms.Button();
            this.Serial_Port3 = new System.IO.Ports.SerialPort(this.components);
            this.List_Servo_Multi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bar_posisi_multi = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label_pos_now = new System.Windows.Forms.Label();
            this.button_rescan = new System.Windows.Forms.Button();
            this.label_PosDegree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.List_Servo_Multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_posisi_multi)).BeginInit();
            this.SuspendLayout();
            // 
            // Disconnect
            // 
            this.Disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Disconnect.BackColor = System.Drawing.Color.Transparent;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disconnect.ForeColor = System.Drawing.Color.Transparent;
            this.Disconnect.Location = new System.Drawing.Point(788, 462);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(109, 41);
            this.Disconnect.TabIndex = 14;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Serial_Port3
            // 
            this.Serial_Port3.BaudRate = 9600;
            this.Serial_Port3.DataBits = 8;
            this.Serial_Port3.DiscardNull = false;
            this.Serial_Port3.DtrEnable = false;
            //asciiEncodingSealed1.DecoderFallback = decoderReplacementFallback1;
            //asciiEncodingSealed1.EncoderFallback = encoderReplacementFallback1;
            //this.Serial_Port3.Encoding = asciiEncodingSealed1;
            this.Serial_Port3.Handshake = System.IO.Ports.Handshake.None;
            this.Serial_Port3.NewLine = "\n";
            this.Serial_Port3.Parity = System.IO.Ports.Parity.None;
            this.Serial_Port3.ParityReplace = ((byte)(63));
            this.Serial_Port3.PortName = "COM1";
            this.Serial_Port3.ReadBufferSize = 4096;
            this.Serial_Port3.ReadTimeout = -1;
            this.Serial_Port3.ReceivedBytesThreshold = 1;
            this.Serial_Port3.RtsEnable = false;
            this.Serial_Port3.StopBits = System.IO.Ports.StopBits.One;
            this.Serial_Port3.WriteBufferSize = 2048;
            this.Serial_Port3.WriteTimeout = -1;
            this.Serial_Port3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_Port3_DataReceived);
            // 
            // List_Servo_Multi
            // 
            this.List_Servo_Multi.AllowUserToAddRows = false;
            this.List_Servo_Multi.AllowUserToResizeColumns = false;
            this.List_Servo_Multi.AllowUserToResizeRows = false;
            this.List_Servo_Multi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Servo_Multi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_Servo_Multi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.List_Servo_Multi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_Servo_Multi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_Servo_Multi.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Servo_Multi.Location = new System.Drawing.Point(210, 89);
            this.List_Servo_Multi.Name = "List_Servo_Multi";
            this.List_Servo_Multi.RowHeadersWidth = 51;
            this.List_Servo_Multi.Size = new System.Drawing.Size(534, 258);
            this.List_Servo_Multi.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Multiple Servo Position Control";
            // 
            // bar_posisi_multi
            // 
            this.bar_posisi_multi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar_posisi_multi.Location = new System.Drawing.Point(72, 397);
            this.bar_posisi_multi.Maximum = 4095;
            this.bar_posisi_multi.Name = "bar_posisi_multi";
            this.bar_posisi_multi.Size = new System.Drawing.Size(788, 56);
            this.bar_posisi_multi.SmallChange = 4;
            this.bar_posisi_multi.TabIndex = 512;
            this.bar_posisi_multi.TickFrequency = 128;
            this.bar_posisi_multi.Scroll += new System.EventHandler(this.bar_posisi_multi_Scroll);
            this.bar_posisi_multi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bar_posisi_multi_MouseUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(225, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 40);
            this.label5.TabIndex = 47;
            this.label5.Text = "Posisi Servo :";
            // 
            // label_pos_now
            // 
            this.label_pos_now.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_pos_now.AutoSize = true;
            this.label_pos_now.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_pos_now.ForeColor = System.Drawing.Color.Transparent;
            this.label_pos_now.Location = new System.Drawing.Point(484, 445);
            this.label_pos_now.Name = "label_pos_now";
            this.label_pos_now.Size = new System.Drawing.Size(271, 40);
            this.label_pos_now.TabIndex = 48;
            this.label_pos_now.Text = "Posisi Sekarang";
            // 
            // button_rescan
            // 
            this.button_rescan.BackColor = System.Drawing.Color.White;
            this.button_rescan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_rescan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_rescan.ForeColor = System.Drawing.Color.Black;
            this.button_rescan.Location = new System.Drawing.Point(12, 475);
            this.button_rescan.Name = "button_rescan";
            this.button_rescan.Size = new System.Drawing.Size(91, 28);
            this.button_rescan.TabIndex = 513;
            this.button_rescan.Text = "Scan Ulang";
            this.button_rescan.UseVisualStyleBackColor = false;
            this.button_rescan.Click += new System.EventHandler(this.button_rescan_Click);
            // 
            // label_PosDegree
            // 
            this.label_PosDegree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_PosDegree.AutoSize = true;
            this.label_PosDegree.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_PosDegree.ForeColor = System.Drawing.Color.Transparent;
            this.label_PosDegree.Location = new System.Drawing.Point(668, 445);
            this.label_PosDegree.Name = "label_PosDegree";
            this.label_PosDegree.Size = new System.Drawing.Size(76, 40);
            this.label_PosDegree.TabIndex = 514;
            this.label_PosDegree.Text = "(x°)";
            // 
            // Multiple_Servo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(909, 515);
            this.Controls.Add(this.label_PosDegree);
            this.Controls.Add(this.button_rescan);
            this.Controls.Add(this.label_pos_now);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bar_posisi_multi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_Servo_Multi);
            this.Controls.Add(this.Disconnect);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(909, 515);
            this.Name = "Multiple_Servo";
            this.Text = "Multiple_Servo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Multiple_Servo_FormClosing);
            this.Load += new System.EventHandler(this.Multiple_Servo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_Servo_Multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_posisi_multi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Disconnect;
        private System.IO.Ports.SerialPort Serial_Port3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar bar_posisi_multi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_pos_now;
        public System.Windows.Forms.DataGridView List_Servo_Multi;
        private System.Windows.Forms.Button button_rescan;
        private System.Windows.Forms.Label label_PosDegree;
    }
}