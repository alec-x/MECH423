namespace Lab1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.TextAccelX = new System.Windows.Forms.TextBox();
            this.LabelAccelX = new System.Windows.Forms.Label();
            this.LabelAccelY = new System.Windows.Forms.Label();
            this.TextAccelY = new System.Windows.Forms.TextBox();
            this.LabelAccelZ = new System.Windows.Forms.Label();
            this.TextAccelZ = new System.Windows.Forms.TextBox();
            this.LabelAccel = new System.Windows.Forms.Label();
            this.ProgressBarBuffer = new System.Windows.Forms.ProgressBar();
            this.LabelBuffer = new System.Windows.Forms.Label();
            this.TextProgressBar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextAvgAccelZ = new System.Windows.Forms.TextBox();
            this.TextAvgAccelY = new System.Windows.Forms.TextBox();
            this.TextAvgAccelX = new System.Windows.Forms.TextBox();
            this.LabelOrientation = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ComboPortList = new System.Windows.Forms.ComboBox();
            this.PictureLeft = new System.Windows.Forms.PictureBox();
            this.PictureMiddle = new System.Windows.Forms.PictureBox();
            this.PictureRight = new System.Windows.Forms.PictureBox();
            this.PictureUp = new System.Windows.Forms.PictureBox();
            this.PictureDown = new System.Windows.Forms.PictureBox();
            this.ButtonGameStart = new System.Windows.Forms.Button();
            this.ListDialogue = new System.Windows.Forms.ListBox();
            this.PictureBoxX = new System.Windows.Forms.PictureBox();
            this.PictureBoxY = new System.Windows.Forms.PictureBox();
            this.PictureBoxZ = new System.Windows.Forms.PictureBox();
            this.ChartAcceleration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelMovePerformed = new System.Windows.Forms.Label();
            this.TextMovePerformed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAcceleration)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // TextAccelX
            // 
            this.TextAccelX.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAccelX.Location = new System.Drawing.Point(38, 38);
            this.TextAccelX.Name = "TextAccelX";
            this.TextAccelX.ReadOnly = true;
            this.TextAccelX.Size = new System.Drawing.Size(181, 29);
            this.TextAccelX.TabIndex = 0;
            // 
            // LabelAccelX
            // 
            this.LabelAccelX.AutoSize = true;
            this.LabelAccelX.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccelX.Location = new System.Drawing.Point(11, 41);
            this.LabelAccelX.Name = "LabelAccelX";
            this.LabelAccelX.Size = new System.Drawing.Size(21, 22);
            this.LabelAccelX.TabIndex = 3;
            this.LabelAccelX.Text = "X";
            // 
            // LabelAccelY
            // 
            this.LabelAccelY.AutoSize = true;
            this.LabelAccelY.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccelY.Location = new System.Drawing.Point(11, 76);
            this.LabelAccelY.Name = "LabelAccelY";
            this.LabelAccelY.Size = new System.Drawing.Size(21, 22);
            this.LabelAccelY.TabIndex = 5;
            this.LabelAccelY.Text = "Y";
            // 
            // TextAccelY
            // 
            this.TextAccelY.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAccelY.Location = new System.Drawing.Point(38, 73);
            this.TextAccelY.Name = "TextAccelY";
            this.TextAccelY.ReadOnly = true;
            this.TextAccelY.Size = new System.Drawing.Size(181, 29);
            this.TextAccelY.TabIndex = 4;
            // 
            // LabelAccelZ
            // 
            this.LabelAccelZ.AutoSize = true;
            this.LabelAccelZ.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccelZ.Location = new System.Drawing.Point(11, 111);
            this.LabelAccelZ.Name = "LabelAccelZ";
            this.LabelAccelZ.Size = new System.Drawing.Size(21, 22);
            this.LabelAccelZ.TabIndex = 7;
            this.LabelAccelZ.Text = "Z";
            // 
            // TextAccelZ
            // 
            this.TextAccelZ.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAccelZ.Location = new System.Drawing.Point(38, 108);
            this.TextAccelZ.Name = "TextAccelZ";
            this.TextAccelZ.ReadOnly = true;
            this.TextAccelZ.Size = new System.Drawing.Size(181, 29);
            this.TextAccelZ.TabIndex = 6;
            // 
            // LabelAccel
            // 
            this.LabelAccel.AutoSize = true;
            this.LabelAccel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccel.Location = new System.Drawing.Point(11, 12);
            this.LabelAccel.Name = "LabelAccel";
            this.LabelAccel.Size = new System.Drawing.Size(208, 22);
            this.LabelAccel.TabIndex = 8;
            this.LabelAccel.Text = "Acceleration (m/s)";
            // 
            // ProgressBarBuffer
            // 
            this.ProgressBarBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBarBuffer.Location = new System.Drawing.Point(254, 401);
            this.ProgressBarBuffer.Maximum = 4096;
            this.ProgressBarBuffer.Name = "ProgressBarBuffer";
            this.ProgressBarBuffer.Size = new System.Drawing.Size(72, 23);
            this.ProgressBarBuffer.TabIndex = 9;
            // 
            // LabelBuffer
            // 
            this.LabelBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBuffer.AutoSize = true;
            this.LabelBuffer.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBuffer.Location = new System.Drawing.Point(172, 401);
            this.LabelBuffer.Name = "LabelBuffer";
            this.LabelBuffer.Size = new System.Drawing.Size(76, 22);
            this.LabelBuffer.TabIndex = 10;
            this.LabelBuffer.Text = "Buffer";
            // 
            // TextProgressBar
            // 
            this.TextProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextProgressBar.AutoSize = true;
            this.TextProgressBar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProgressBar.Location = new System.Drawing.Point(332, 401);
            this.TextProgressBar.Name = "TextProgressBar";
            this.TextProgressBar.Size = new System.Drawing.Size(76, 22);
            this.TextProgressBar.TabIndex = 11;
            this.TextProgressBar.Text = "0/4096";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Avg. last 100";
            // 
            // TextAvgAccelZ
            // 
            this.TextAvgAccelZ.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAvgAccelZ.Location = new System.Drawing.Point(229, 108);
            this.TextAvgAccelZ.Name = "TextAvgAccelZ";
            this.TextAvgAccelZ.ReadOnly = true;
            this.TextAvgAccelZ.Size = new System.Drawing.Size(181, 29);
            this.TextAvgAccelZ.TabIndex = 14;
            // 
            // TextAvgAccelY
            // 
            this.TextAvgAccelY.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAvgAccelY.Location = new System.Drawing.Point(229, 73);
            this.TextAvgAccelY.Name = "TextAvgAccelY";
            this.TextAvgAccelY.ReadOnly = true;
            this.TextAvgAccelY.Size = new System.Drawing.Size(181, 29);
            this.TextAvgAccelY.TabIndex = 13;
            // 
            // TextAvgAccelX
            // 
            this.TextAvgAccelX.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAvgAccelX.Location = new System.Drawing.Point(229, 38);
            this.TextAvgAccelX.Name = "TextAvgAccelX";
            this.TextAvgAccelX.ReadOnly = true;
            this.TextAvgAccelX.Size = new System.Drawing.Size(181, 29);
            this.TextAvgAccelX.TabIndex = 12;
            // 
            // LabelOrientation
            // 
            this.LabelOrientation.AutoSize = true;
            this.LabelOrientation.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOrientation.Location = new System.Drawing.Point(11, 159);
            this.LabelOrientation.Name = "LabelOrientation";
            this.LabelOrientation.Size = new System.Drawing.Size(197, 22);
            this.LabelOrientation.TabIndex = 17;
            this.LabelOrientation.Text = "Board Orientation";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(15, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(181, 29);
            this.textBox6.TabIndex = 16;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F);
            this.ButtonConnect.Location = new System.Drawing.Point(12, 360);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(151, 31);
            this.ButtonConnect.TabIndex = 18;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ComboPortList
            // 
            this.ComboPortList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F);
            this.ComboPortList.FormattingEnabled = true;
            this.ComboPortList.Location = new System.Drawing.Point(12, 397);
            this.ComboPortList.Name = "ComboPortList";
            this.ComboPortList.Size = new System.Drawing.Size(151, 29);
            this.ComboPortList.TabIndex = 19;
            this.ComboPortList.SelectedIndexChanged += new System.EventHandler(this.ComboPortList_SelectedIndexChanged);
            this.ComboPortList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboPortList_MouseClick);
            // 
            // PictureLeft
            // 
            this.PictureLeft.Image = global::Lab1.Properties.Resources.mole;
            this.PictureLeft.Location = new System.Drawing.Point(761, 108);
            this.PictureLeft.Name = "PictureLeft";
            this.PictureLeft.Size = new System.Drawing.Size(89, 85);
            this.PictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLeft.TabIndex = 20;
            this.PictureLeft.TabStop = false;
            // 
            // PictureMiddle
            // 
            this.PictureMiddle.Image = ((System.Drawing.Image)(resources.GetObject("PictureMiddle.Image")));
            this.PictureMiddle.Location = new System.Drawing.Point(856, 108);
            this.PictureMiddle.Name = "PictureMiddle";
            this.PictureMiddle.Size = new System.Drawing.Size(89, 85);
            this.PictureMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMiddle.TabIndex = 21;
            this.PictureMiddle.TabStop = false;
            // 
            // PictureRight
            // 
            this.PictureRight.Image = global::Lab1.Properties.Resources.mole;
            this.PictureRight.Location = new System.Drawing.Point(951, 108);
            this.PictureRight.Name = "PictureRight";
            this.PictureRight.Size = new System.Drawing.Size(89, 85);
            this.PictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureRight.TabIndex = 22;
            this.PictureRight.TabStop = false;
            // 
            // PictureUp
            // 
            this.PictureUp.Image = ((System.Drawing.Image)(resources.GetObject("PictureUp.Image")));
            this.PictureUp.Location = new System.Drawing.Point(856, 15);
            this.PictureUp.Name = "PictureUp";
            this.PictureUp.Size = new System.Drawing.Size(89, 85);
            this.PictureUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUp.TabIndex = 23;
            this.PictureUp.TabStop = false;
            // 
            // PictureDown
            // 
            this.PictureDown.Image = ((System.Drawing.Image)(resources.GetObject("PictureDown.Image")));
            this.PictureDown.Location = new System.Drawing.Point(856, 199);
            this.PictureDown.Name = "PictureDown";
            this.PictureDown.Size = new System.Drawing.Size(89, 85);
            this.PictureDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureDown.TabIndex = 24;
            this.PictureDown.TabStop = false;
            // 
            // ButtonGameStart
            // 
            this.ButtonGameStart.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F);
            this.ButtonGameStart.Location = new System.Drawing.Point(906, 396);
            this.ButtonGameStart.Name = "ButtonGameStart";
            this.ButtonGameStart.Size = new System.Drawing.Size(139, 31);
            this.ButtonGameStart.TabIndex = 25;
            this.ButtonGameStart.Text = "Start Game";
            this.ButtonGameStart.UseVisualStyleBackColor = true;
            this.ButtonGameStart.Click += new System.EventHandler(this.ButtonGameStart_Click);
            // 
            // ListDialogue
            // 
            this.ListDialogue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F);
            this.ListDialogue.FormattingEnabled = true;
            this.ListDialogue.ItemHeight = 21;
            this.ListDialogue.Location = new System.Drawing.Point(454, 12);
            this.ListDialogue.Name = "ListDialogue";
            this.ListDialogue.Size = new System.Drawing.Size(284, 130);
            this.ListDialogue.TabIndex = 26;
            // 
            // PictureBoxX
            // 
            this.PictureBoxX.Location = new System.Drawing.Point(416, 38);
            this.PictureBoxX.Name = "PictureBoxX";
            this.PictureBoxX.Size = new System.Drawing.Size(32, 29);
            this.PictureBoxX.TabIndex = 27;
            this.PictureBoxX.TabStop = false;
            // 
            // PictureBoxY
            // 
            this.PictureBoxY.Location = new System.Drawing.Point(416, 71);
            this.PictureBoxY.Name = "PictureBoxY";
            this.PictureBoxY.Size = new System.Drawing.Size(32, 29);
            this.PictureBoxY.TabIndex = 28;
            this.PictureBoxY.TabStop = false;
            // 
            // PictureBoxZ
            // 
            this.PictureBoxZ.BackColor = System.Drawing.Color.Red;
            this.PictureBoxZ.Location = new System.Drawing.Point(416, 108);
            this.PictureBoxZ.Name = "PictureBoxZ";
            this.PictureBoxZ.Size = new System.Drawing.Size(32, 29);
            this.PictureBoxZ.TabIndex = 29;
            this.PictureBoxZ.TabStop = false;
            // 
            // ChartAcceleration
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartAcceleration.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartAcceleration.Legends.Add(legend1);
            this.ChartAcceleration.Location = new System.Drawing.Point(229, 159);
            this.ChartAcceleration.Name = "ChartAcceleration";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartAcceleration.Series.Add(series1);
            this.ChartAcceleration.Size = new System.Drawing.Size(509, 236);
            this.ChartAcceleration.TabIndex = 30;
            this.ChartAcceleration.Text = "Acceleration";
            // 
            // LabelMovePerformed
            // 
            this.LabelMovePerformed.AutoSize = true;
            this.LabelMovePerformed.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMovePerformed.Location = new System.Drawing.Point(11, 237);
            this.LabelMovePerformed.Name = "LabelMovePerformed";
            this.LabelMovePerformed.Size = new System.Drawing.Size(164, 22);
            this.LabelMovePerformed.TabIndex = 32;
            this.LabelMovePerformed.Text = "Move Performed";
            // 
            // TextMovePerformed
            // 
            this.TextMovePerformed.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMovePerformed.Location = new System.Drawing.Point(15, 262);
            this.TextMovePerformed.Name = "TextMovePerformed";
            this.TextMovePerformed.ReadOnly = true;
            this.TextMovePerformed.Size = new System.Drawing.Size(181, 29);
            this.TextMovePerformed.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 438);
            this.Controls.Add(this.LabelMovePerformed);
            this.Controls.Add(this.TextMovePerformed);
            this.Controls.Add(this.ChartAcceleration);
            this.Controls.Add(this.PictureBoxZ);
            this.Controls.Add(this.PictureBoxY);
            this.Controls.Add(this.PictureBoxX);
            this.Controls.Add(this.ListDialogue);
            this.Controls.Add(this.ButtonGameStart);
            this.Controls.Add(this.PictureDown);
            this.Controls.Add(this.PictureUp);
            this.Controls.Add(this.PictureRight);
            this.Controls.Add(this.PictureMiddle);
            this.Controls.Add(this.PictureLeft);
            this.Controls.Add(this.ComboPortList);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.LabelOrientation);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextAvgAccelZ);
            this.Controls.Add(this.TextAvgAccelY);
            this.Controls.Add(this.TextAvgAccelX);
            this.Controls.Add(this.TextProgressBar);
            this.Controls.Add(this.LabelBuffer);
            this.Controls.Add(this.ProgressBarBuffer);
            this.Controls.Add(this.LabelAccel);
            this.Controls.Add(this.LabelAccelZ);
            this.Controls.Add(this.TextAccelZ);
            this.Controls.Add(this.LabelAccelY);
            this.Controls.Add(this.TextAccelY);
            this.Controls.Add(this.LabelAccelX);
            this.Controls.Add(this.TextAccelX);
            this.Name = "MainForm";
            this.Text = "Lab 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAcceleration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.TextBox TextAccelX;
        private System.Windows.Forms.Label LabelAccelX;
        private System.Windows.Forms.Label LabelAccelY;
        private System.Windows.Forms.TextBox TextAccelY;
        private System.Windows.Forms.Label LabelAccelZ;
        private System.Windows.Forms.TextBox TextAccelZ;
        private System.Windows.Forms.Label LabelAccel;
        private System.Windows.Forms.ProgressBar ProgressBarBuffer;
        private System.Windows.Forms.Label LabelBuffer;
        private System.Windows.Forms.Label TextProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextAvgAccelZ;
        private System.Windows.Forms.TextBox TextAvgAccelY;
        private System.Windows.Forms.TextBox TextAvgAccelX;
        private System.Windows.Forms.Label LabelOrientation;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox ComboPortList;
        private System.Windows.Forms.PictureBox PictureLeft;
        private System.Windows.Forms.PictureBox PictureMiddle;
        private System.Windows.Forms.PictureBox PictureRight;
        private System.Windows.Forms.PictureBox PictureUp;
        private System.Windows.Forms.PictureBox PictureDown;
        private System.Windows.Forms.Button ButtonGameStart;
        private System.Windows.Forms.ListBox ListDialogue;
        private System.Windows.Forms.PictureBox PictureBoxX;
        private System.Windows.Forms.PictureBox PictureBoxY;
        private System.Windows.Forms.PictureBox PictureBoxZ;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAcceleration;
        private System.Windows.Forms.Label LabelMovePerformed;
        private System.Windows.Forms.TextBox TextMovePerformed;
    }
}

