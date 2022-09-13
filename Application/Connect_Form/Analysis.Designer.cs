namespace Connect_Form
{
    partial class Analysis
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
            this.Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Disconnect
            // 
            this.Disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Disconnect.BackColor = System.Drawing.Color.Transparent;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disconnect.ForeColor = System.Drawing.Color.Transparent;
            this.Disconnect.Location = new System.Drawing.Point(780, 512);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(109, 41);
            this.Disconnect.TabIndex = 15;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = false;
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(901, 565);
            this.Controls.Add(this.Disconnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(901, 565);
            this.Name = "Analysis";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Disconnect;
    }
}