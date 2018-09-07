namespace SerialReaderSuperSimple
{
    partial class FormSerialReader
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
            this.ListComPort = new System.Windows.Forms.ComboBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.LabelX = new System.Windows.Forms.Label();
            this.TextX = new System.Windows.Forms.TextBox();
            this.TextY = new System.Windows.Forms.TextBox();
            this.LabelY = new System.Windows.Forms.Label();
            this.TextZ = new System.Windows.Forms.TextBox();
            this.LabelZ = new System.Windows.Forms.Label();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ListComPort
            // 
            this.ListComPort.DropDownHeight = 1000;
            this.ListComPort.Font = new System.Drawing.Font("Consolas", 12F);
            this.ListComPort.FormattingEnabled = true;
            this.ListComPort.IntegralHeight = false;
            this.ListComPort.Location = new System.Drawing.Point(12, 12);
            this.ListComPort.MaxDropDownItems = 20;
            this.ListComPort.Name = "ListComPort";
            this.ListComPort.Size = new System.Drawing.Size(164, 31);
            this.ListComPort.TabIndex = 0;
            this.ListComPort.SelectedIndexChanged += new System.EventHandler(this.ListComPort_SelectedIndexChanged);
            this.ListComPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListComPort_MouseClick);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.Font = new System.Drawing.Font("Consolas", 12F);
            this.ButtonConnect.Location = new System.Drawing.Point(195, 7);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(113, 40);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Consolas", 12F);
            this.LabelX.Location = new System.Drawing.Point(12, 60);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(21, 23);
            this.LabelX.TabIndex = 2;
            this.LabelX.Text = "X";
            // 
            // TextX
            // 
            this.TextX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextX.Font = new System.Drawing.Font("Consolas", 12F);
            this.TextX.Location = new System.Drawing.Point(39, 57);
            this.TextX.Name = "TextX";
            this.TextX.Size = new System.Drawing.Size(137, 31);
            this.TextX.TabIndex = 3;
            // 
            // TextY
            // 
            this.TextY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextY.Font = new System.Drawing.Font("Consolas", 12F);
            this.TextY.Location = new System.Drawing.Point(39, 94);
            this.TextY.Name = "TextY";
            this.TextY.Size = new System.Drawing.Size(137, 31);
            this.TextY.TabIndex = 5;
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Font = new System.Drawing.Font("Consolas", 12F);
            this.LabelY.Location = new System.Drawing.Point(12, 97);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(21, 23);
            this.LabelY.TabIndex = 4;
            this.LabelY.Text = "Y";
            // 
            // TextZ
            // 
            this.TextZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextZ.Font = new System.Drawing.Font("Consolas", 12F);
            this.TextZ.Location = new System.Drawing.Point(39, 131);
            this.TextZ.Name = "TextZ";
            this.TextZ.Size = new System.Drawing.Size(137, 31);
            this.TextZ.TabIndex = 7;
            // 
            // LabelZ
            // 
            this.LabelZ.AutoSize = true;
            this.LabelZ.Font = new System.Drawing.Font("Consolas", 12F);
            this.LabelZ.Location = new System.Drawing.Point(12, 134);
            this.LabelZ.Name = "LabelZ";
            this.LabelZ.Size = new System.Drawing.Size(21, 23);
            this.LabelZ.TabIndex = 6;
            this.LabelZ.Text = "Z";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormSerialReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 178);
            this.Controls.Add(this.TextZ);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.TextY);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.TextX);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ListComPort);
            this.MinimumSize = new System.Drawing.Size(338, 222);
            this.Name = "FormSerialReader";
            this.Text = "Serial Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSerialReader_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListComPort;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.TextBox TextX;
        private System.Windows.Forms.TextBox TextY;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.TextBox TextZ;
        private System.Windows.Forms.Label LabelZ;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer Timer;
    }
}

