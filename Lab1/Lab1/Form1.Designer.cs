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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.TextBoardOrientation = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ComboPortList = new System.Windows.Forms.ComboBox();
            this.PictureLeft = new System.Windows.Forms.PictureBox();
            this.PictureMiddle = new System.Windows.Forms.PictureBox();
            this.PictureRight = new System.Windows.Forms.PictureBox();
            this.PictureUp = new System.Windows.Forms.PictureBox();
            this.PictureDown = new System.Windows.Forms.PictureBox();
            this.ButtonGameStart = new System.Windows.Forms.Button();
            this.PictureBoxX = new System.Windows.Forms.PictureBox();
            this.PictureBoxY = new System.Windows.Forms.PictureBox();
            this.PictureBoxZ = new System.Windows.Forms.PictureBox();
            this.ChartAcceleration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelMovePerformed = new System.Windows.Forms.Label();
            this.TextMovePerformed = new System.Windows.Forms.TextBox();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.TextTimer = new System.Windows.Forms.TextBox();
            this.LabelScore = new System.Windows.Forms.Label();
            this.TextScore = new System.Windows.Forms.TextBox();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.ComboLevel = new System.Windows.Forms.ComboBox();
            this.LabelBytesToRead = new System.Windows.Forms.Label();
            this.TextBytesToRead = new System.Windows.Forms.TextBox();
            this.TextSerialQueueLength = new System.Windows.Forms.TextBox();
            this.LabelSerialReadQueueLength = new System.Windows.Forms.Label();
            this.TextxAvgList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextyAvgList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextzAvgList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelAvg50 = new System.Windows.Forms.Label();
            this.TextAvg50 = new System.Windows.Forms.TextBox();
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
            this.LabelAccel.Size = new System.Drawing.Size(142, 22);
            this.LabelAccel.TabIndex = 8;
            this.LabelAccel.Text = "Acceleration";
            // 
            // ProgressBarBuffer
            // 
            this.ProgressBarBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBarBuffer.Location = new System.Drawing.Point(93, 451);
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
            this.LabelBuffer.Location = new System.Drawing.Point(11, 451);
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
            this.TextProgressBar.Location = new System.Drawing.Point(171, 451);
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
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Max last 125";
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
            // TextBoardOrientation
            // 
            this.TextBoardOrientation.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoardOrientation.Location = new System.Drawing.Point(15, 184);
            this.TextBoardOrientation.Name = "TextBoardOrientation";
            this.TextBoardOrientation.ReadOnly = true;
            this.TextBoardOrientation.Size = new System.Drawing.Size(181, 29);
            this.TextBoardOrientation.TabIndex = 16;
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
            this.ComboPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.PictureLeft.Location = new System.Drawing.Point(1185, 108);
            this.PictureLeft.Name = "PictureLeft";
            this.PictureLeft.Size = new System.Drawing.Size(89, 85);
            this.PictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLeft.TabIndex = 20;
            this.PictureLeft.TabStop = false;
            // 
            // PictureMiddle
            // 
            this.PictureMiddle.Location = new System.Drawing.Point(1280, 108);
            this.PictureMiddle.Name = "PictureMiddle";
            this.PictureMiddle.Size = new System.Drawing.Size(89, 85);
            this.PictureMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMiddle.TabIndex = 21;
            this.PictureMiddle.TabStop = false;
            // 
            // PictureRight
            // 
            this.PictureRight.Location = new System.Drawing.Point(1375, 108);
            this.PictureRight.Name = "PictureRight";
            this.PictureRight.Size = new System.Drawing.Size(89, 85);
            this.PictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureRight.TabIndex = 22;
            this.PictureRight.TabStop = false;
            // 
            // PictureUp
            // 
            this.PictureUp.Location = new System.Drawing.Point(1280, 15);
            this.PictureUp.Name = "PictureUp";
            this.PictureUp.Size = new System.Drawing.Size(89, 85);
            this.PictureUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUp.TabIndex = 23;
            this.PictureUp.TabStop = false;
            // 
            // PictureDown
            // 
            this.PictureDown.Location = new System.Drawing.Point(1280, 199);
            this.PictureDown.Name = "PictureDown";
            this.PictureDown.Size = new System.Drawing.Size(89, 85);
            this.PictureDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureDown.TabIndex = 24;
            this.PictureDown.TabStop = false;
            // 
            // ButtonGameStart
            // 
            this.ButtonGameStart.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F);
            this.ButtonGameStart.Location = new System.Drawing.Point(1330, 396);
            this.ButtonGameStart.Name = "ButtonGameStart";
            this.ButtonGameStart.Size = new System.Drawing.Size(139, 31);
            this.ButtonGameStart.TabIndex = 25;
            this.ButtonGameStart.Text = "Start Game";
            this.ButtonGameStart.UseVisualStyleBackColor = true;
            this.ButtonGameStart.Click += new System.EventHandler(this.ButtonGameStart_Click);
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
            this.PictureBoxZ.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxZ.Location = new System.Drawing.Point(416, 108);
            this.PictureBoxZ.Name = "PictureBoxZ";
            this.PictureBoxZ.Size = new System.Drawing.Size(32, 29);
            this.PictureBoxZ.TabIndex = 29;
            this.PictureBoxZ.TabStop = false;
            // 
            // ChartAcceleration
            // 
            chartArea2.Name = "ChartAccelerationArea";
            this.ChartAcceleration.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartAcceleration.Legends.Add(legend2);
            this.ChartAcceleration.Location = new System.Drawing.Point(229, 159);
            this.ChartAcceleration.Name = "ChartAcceleration";
            series4.ChartArea = "ChartAccelerationArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "SeriesX";
            series5.ChartArea = "ChartAccelerationArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "SeriesY";
            series6.ChartArea = "ChartAccelerationArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "SeriesZ";
            this.ChartAcceleration.Series.Add(series4);
            this.ChartAcceleration.Series.Add(series5);
            this.ChartAcceleration.Series.Add(series6);
            this.ChartAcceleration.Size = new System.Drawing.Size(488, 236);
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
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimer.Location = new System.Drawing.Point(911, 111);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(65, 22);
            this.LabelTimer.TabIndex = 38;
            this.LabelTimer.Text = "Timer";
            // 
            // TextTimer
            // 
            this.TextTimer.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTimer.Location = new System.Drawing.Point(981, 108);
            this.TextTimer.Name = "TextTimer";
            this.TextTimer.ReadOnly = true;
            this.TextTimer.Size = new System.Drawing.Size(181, 29);
            this.TextTimer.TabIndex = 37;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(911, 76);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(65, 22);
            this.LabelScore.TabIndex = 36;
            this.LabelScore.Text = "Score";
            // 
            // TextScore
            // 
            this.TextScore.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextScore.Location = new System.Drawing.Point(981, 73);
            this.TextScore.Name = "TextScore";
            this.TextScore.ReadOnly = true;
            this.TextScore.Size = new System.Drawing.Size(181, 29);
            this.TextScore.TabIndex = 35;
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLevel.Location = new System.Drawing.Point(911, 41);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(65, 22);
            this.LabelLevel.TabIndex = 34;
            this.LabelLevel.Text = "Level";
            // 
            // ComboLevel
            // 
            this.ComboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLevel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F);
            this.ComboLevel.FormattingEnabled = true;
            this.ComboLevel.Location = new System.Drawing.Point(981, 38);
            this.ComboLevel.Name = "ComboLevel";
            this.ComboLevel.Size = new System.Drawing.Size(181, 29);
            this.ComboLevel.TabIndex = 39;
            // 
            // LabelBytesToRead
            // 
            this.LabelBytesToRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBytesToRead.AutoSize = true;
            this.LabelBytesToRead.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBytesToRead.Location = new System.Drawing.Point(843, 364);
            this.LabelBytesToRead.Name = "LabelBytesToRead";
            this.LabelBytesToRead.Size = new System.Drawing.Size(131, 22);
            this.LabelBytesToRead.TabIndex = 40;
            this.LabelBytesToRead.Text = "BytesToRead";
            // 
            // TextBytesToRead
            // 
            this.TextBytesToRead.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBytesToRead.Location = new System.Drawing.Point(992, 361);
            this.TextBytesToRead.Name = "TextBytesToRead";
            this.TextBytesToRead.ReadOnly = true;
            this.TextBytesToRead.Size = new System.Drawing.Size(74, 29);
            this.TextBytesToRead.TabIndex = 41;
            // 
            // TextSerialQueueLength
            // 
            this.TextSerialQueueLength.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSerialQueueLength.Location = new System.Drawing.Point(992, 184);
            this.TextSerialQueueLength.Name = "TextSerialQueueLength";
            this.TextSerialQueueLength.ReadOnly = true;
            this.TextSerialQueueLength.Size = new System.Drawing.Size(74, 29);
            this.TextSerialQueueLength.TabIndex = 43;
            // 
            // LabelSerialReadQueueLength
            // 
            this.LabelSerialReadQueueLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSerialReadQueueLength.AutoSize = true;
            this.LabelSerialReadQueueLength.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSerialReadQueueLength.Location = new System.Drawing.Point(734, 188);
            this.LabelSerialReadQueueLength.Name = "LabelSerialReadQueueLength";
            this.LabelSerialReadQueueLength.Size = new System.Drawing.Size(241, 22);
            this.LabelSerialReadQueueLength.TabIndex = 42;
            this.LabelSerialReadQueueLength.Text = "SerialReadQueueLength";
            // 
            // TextxAvgList
            // 
            this.TextxAvgList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextxAvgList.Location = new System.Drawing.Point(992, 230);
            this.TextxAvgList.Name = "TextxAvgList";
            this.TextxAvgList.ReadOnly = true;
            this.TextxAvgList.Size = new System.Drawing.Size(74, 29);
            this.TextxAvgList.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "xAvgListLength";
            // 
            // TextyAvgList
            // 
            this.TextyAvgList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextyAvgList.Location = new System.Drawing.Point(992, 276);
            this.TextyAvgList.Name = "TextyAvgList";
            this.TextyAvgList.ReadOnly = true;
            this.TextyAvgList.Size = new System.Drawing.Size(74, 29);
            this.TextyAvgList.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "yAvgListLength";
            // 
            // TextzAvgList
            // 
            this.TextzAvgList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextzAvgList.Location = new System.Drawing.Point(992, 318);
            this.TextzAvgList.Name = "TextzAvgList";
            this.TextzAvgList.ReadOnly = true;
            this.TextzAvgList.Size = new System.Drawing.Size(74, 29);
            this.TextzAvgList.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(810, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "zAvgListLength";
            // 
            // LabelAvg50
            // 
            this.LabelAvg50.AutoSize = true;
            this.LabelAvg50.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvg50.Location = new System.Drawing.Point(450, 12);
            this.LabelAvg50.Name = "LabelAvg50";
            this.LabelAvg50.Size = new System.Drawing.Size(175, 22);
            this.LabelAvg50.TabIndex = 53;
            this.LabelAvg50.Text = "Avg Last 50 (g)";
            // 
            // TextAvg50
            // 
            this.TextAvg50.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAvg50.Location = new System.Drawing.Point(454, 38);
            this.TextAvg50.Name = "TextAvg50";
            this.TextAvg50.ReadOnly = true;
            this.TextAvg50.Size = new System.Drawing.Size(181, 29);
            this.TextAvg50.TabIndex = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 482);
            this.Controls.Add(this.LabelAvg50);
            this.Controls.Add(this.TextAvg50);
            this.Controls.Add(this.TextzAvgList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextyAvgList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextxAvgList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSerialQueueLength);
            this.Controls.Add(this.LabelSerialReadQueueLength);
            this.Controls.Add(this.TextBytesToRead);
            this.Controls.Add(this.LabelBytesToRead);
            this.Controls.Add(this.ComboLevel);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.TextTimer);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.TextScore);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.LabelMovePerformed);
            this.Controls.Add(this.TextMovePerformed);
            this.Controls.Add(this.ChartAcceleration);
            this.Controls.Add(this.PictureBoxZ);
            this.Controls.Add(this.PictureBoxY);
            this.Controls.Add(this.PictureBoxX);
            this.Controls.Add(this.ButtonGameStart);
            this.Controls.Add(this.PictureDown);
            this.Controls.Add(this.PictureUp);
            this.Controls.Add(this.PictureRight);
            this.Controls.Add(this.PictureMiddle);
            this.Controls.Add(this.PictureLeft);
            this.Controls.Add(this.ComboPortList);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.LabelOrientation);
            this.Controls.Add(this.TextBoardOrientation);
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
        private System.Windows.Forms.TextBox TextBoardOrientation;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox ComboPortList;
        private System.Windows.Forms.PictureBox PictureLeft;
        private System.Windows.Forms.PictureBox PictureMiddle;
        private System.Windows.Forms.PictureBox PictureRight;
        private System.Windows.Forms.PictureBox PictureUp;
        private System.Windows.Forms.PictureBox PictureDown;
        private System.Windows.Forms.Button ButtonGameStart;
        private System.Windows.Forms.PictureBox PictureBoxX;
        private System.Windows.Forms.PictureBox PictureBoxY;
        private System.Windows.Forms.PictureBox PictureBoxZ;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAcceleration;
        private System.Windows.Forms.Label LabelMovePerformed;
        private System.Windows.Forms.TextBox TextMovePerformed;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.TextBox TextTimer;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.TextBox TextScore;
        private System.Windows.Forms.Label LabelLevel;
        private System.Windows.Forms.ComboBox ComboLevel;
        private System.Windows.Forms.Label LabelBytesToRead;
        private System.Windows.Forms.TextBox TextBytesToRead;
        private System.Windows.Forms.TextBox TextSerialQueueLength;
        private System.Windows.Forms.Label LabelSerialReadQueueLength;
        private System.Windows.Forms.TextBox TextxAvgList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextyAvgList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextzAvgList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelAvg50;
        private System.Windows.Forms.TextBox TextAvg50;
    }
}

