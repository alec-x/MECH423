namespace lab3_2
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.comCombo = new System.Windows.Forms.ComboBox();
            this.headerText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.baudRateText = new System.Windows.Forms.TextBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.duty1Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.duty2Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.directionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.escapeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.modeText = new System.Windows.Forms.TextBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.part3Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(427, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(167, 34);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(7, 55);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(201, 26);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Header Byte (255)";
            // 
            // comCombo
            // 
            this.comCombo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCombo.FormattingEnabled = true;
            this.comCombo.Location = new System.Drawing.Point(12, 12);
            this.comCombo.Name = "comCombo";
            this.comCombo.Size = new System.Drawing.Size(121, 34);
            this.comCombo.TabIndex = 3;
            this.comCombo.SelectedIndexChanged += new System.EventHandler(this.comCombo_SelectedIndexChanged);
            this.comCombo.Click += new System.EventHandler(this.comCombo_Click);
            // 
            // headerText
            // 
            this.headerText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(12, 86);
            this.headerText.Name = "headerText";
            this.headerText.ReadOnly = true;
            this.headerText.Size = new System.Drawing.Size(196, 32);
            this.headerText.TabIndex = 4;
            this.headerText.Text = "255";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(891, 142);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(125, 48);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // baudRateText
            // 
            this.baudRateText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateText.Location = new System.Drawing.Point(281, 13);
            this.baudRateText.Name = "baudRateText";
            this.baudRateText.Size = new System.Drawing.Size(131, 32);
            this.baudRateText.TabIndex = 6;
            this.baudRateText.Text = "9600";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateLabel.Location = new System.Drawing.Point(141, 16);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(125, 26);
            this.baudRateLabel.TabIndex = 7;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // duty1Text
            // 
            this.duty1Text.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duty1Text.Location = new System.Drawing.Point(216, 86);
            this.duty1Text.Name = "duty1Text";
            this.duty1Text.Size = new System.Drawing.Size(196, 32);
            this.duty1Text.TabIndex = 9;
            this.duty1Text.Text = "0";
            this.duty1Text.TextChanged += new System.EventHandler(this.duty1Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Duty Cycle Byte 1";
            // 
            // duty2Text
            // 
            this.duty2Text.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duty2Text.Location = new System.Drawing.Point(418, 86);
            this.duty2Text.Name = "duty2Text";
            this.duty2Text.Size = new System.Drawing.Size(196, 32);
            this.duty2Text.TabIndex = 11;
            this.duty2Text.Text = "0";
            this.duty2Text.TextChanged += new System.EventHandler(this.duty2Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Duty Cycle Byte 2";
            // 
            // directionText
            // 
            this.directionText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionText.Location = new System.Drawing.Point(620, 86);
            this.directionText.Name = "directionText";
            this.directionText.Size = new System.Drawing.Size(196, 32);
            this.directionText.TabIndex = 13;
            this.directionText.Text = "0";
            this.directionText.TextChanged += new System.EventHandler(this.directionText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direction Byte";
            // 
            // escapeText
            // 
            this.escapeText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapeText.Location = new System.Drawing.Point(822, 86);
            this.escapeText.Name = "escapeText";
            this.escapeText.Size = new System.Drawing.Size(196, 32);
            this.escapeText.TabIndex = 15;
            this.escapeText.Text = "0";
            this.escapeText.TextChanged += new System.EventHandler(this.escapeText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(817, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Escape Byte";
            // 
            // modeText
            // 
            this.modeText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeText.Location = new System.Drawing.Point(214, 157);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(196, 32);
            this.modeText.TabIndex = 17;
            this.modeText.Text = "0";
            this.modeText.TextChanged += new System.EventHandler(this.modeText_TextChanged);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(209, 126);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(118, 26);
            this.modeLabel.TabIndex = 16;
            this.modeLabel.Text = "Mode Byte";
            // 
            // part3Check
            // 
            this.part3Check.AutoSize = true;
            this.part3Check.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.part3Check.Location = new System.Drawing.Point(427, 160);
            this.part3Check.Name = "part3Check";
            this.part3Check.Size = new System.Drawing.Size(215, 30);
            this.part3Check.TabIndex = 18;
            this.part3Check.Text = "Lab 3-3 (Stepper)";
            this.part3Check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 209);
            this.Controls.Add(this.part3Check);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.escapeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.duty2Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duty1Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.baudRateText);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.comCombo);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Lab 3 Serial Communicator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox comCombo;
        private System.Windows.Forms.TextBox headerText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox baudRateText;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.TextBox duty1Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox duty2Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox escapeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox directionText;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox modeText;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.CheckBox part3Check;
    }
}

