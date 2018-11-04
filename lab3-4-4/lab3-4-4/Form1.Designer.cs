﻿namespace lab3_4_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.positionLabel = new System.Windows.Forms.Label();
            this.speedRPMLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.baudRateText = new System.Windows.Forms.TextBox();
            this.comCombo = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.positionText = new System.Windows.Forms.TextBox();
            this.speedRPMText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.speedHzText = new System.Windows.Forms.TextBox();
            this.speedHzLabel = new System.Windows.Forms.Label();
            this.pwmText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.directionCheck = new System.Windows.Forms.CheckBox();
            this.commandButton = new System.Windows.Forms.Button();
            this.positionModCheck = new System.Windows.Forms.CheckBox();
            this.speedModCheck = new System.Windows.Forms.CheckBox();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.speedModText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posModText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // speedChart
            // 
            chartArea3.AxisY.Crossing = 0D;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY2.Crossing = 0D;
            chartArea3.AxisY2.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea3);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Name = "Legend1";
            this.speedChart.Legends.Add(legend3);
            this.speedChart.Location = new System.Drawing.Point(12, 72);
            this.speedChart.Name = "speedChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "encoderPosition";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "motorSpeed";
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.speedChart.Series.Add(series5);
            this.speedChart.Series.Add(series6);
            this.speedChart.Size = new System.Drawing.Size(536, 392);
            this.speedChart.TabIndex = 0;
            this.speedChart.Text = "speedChart";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.positionLabel.Location = new System.Drawing.Point(554, 72);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(188, 26);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Encoder Position:";
            // 
            // speedRPMLabel
            // 
            this.speedRPMLabel.AutoSize = true;
            this.speedRPMLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.speedRPMLabel.Location = new System.Drawing.Point(554, 142);
            this.speedRPMLabel.Name = "speedRPMLabel";
            this.speedRPMLabel.Size = new System.Drawing.Size(230, 26);
            this.speedRPMLabel.TabIndex = 2;
            this.speedRPMLabel.Text = "Encoder Speed (RPM)";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateLabel.Location = new System.Drawing.Point(139, 9);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(125, 26);
            this.baudRateLabel.TabIndex = 11;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // baudRateText
            // 
            this.baudRateText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateText.Location = new System.Drawing.Point(279, 6);
            this.baudRateText.Name = "baudRateText";
            this.baudRateText.Size = new System.Drawing.Size(131, 32);
            this.baudRateText.TabIndex = 10;
            this.baudRateText.Text = "9600";
            // 
            // comCombo
            // 
            this.comCombo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCombo.FormattingEnabled = true;
            this.comCombo.Location = new System.Drawing.Point(10, 5);
            this.comCombo.Name = "comCombo";
            this.comCombo.Size = new System.Drawing.Size(121, 34);
            this.comCombo.TabIndex = 9;
            this.comCombo.SelectedIndexChanged += new System.EventHandler(this.comCombo_SelectedIndexChanged);
            this.comCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comCombo_MouseClick);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(425, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(167, 34);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // positionText
            // 
            this.positionText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionText.Location = new System.Drawing.Point(559, 102);
            this.positionText.Name = "positionText";
            this.positionText.Size = new System.Drawing.Size(183, 32);
            this.positionText.TabIndex = 12;
            // 
            // speedRPMText
            // 
            this.speedRPMText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedRPMText.Location = new System.Drawing.Point(559, 171);
            this.speedRPMText.Name = "speedRPMText";
            this.speedRPMText.Size = new System.Drawing.Size(183, 32);
            this.speedRPMText.TabIndex = 13;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // speedHzText
            // 
            this.speedHzText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedHzText.Location = new System.Drawing.Point(559, 244);
            this.speedHzText.Name = "speedHzText";
            this.speedHzText.Size = new System.Drawing.Size(183, 32);
            this.speedHzText.TabIndex = 15;
            // 
            // speedHzLabel
            // 
            this.speedHzLabel.AutoSize = true;
            this.speedHzLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.speedHzLabel.Location = new System.Drawing.Point(554, 215);
            this.speedHzLabel.Name = "speedHzLabel";
            this.speedHzLabel.Size = new System.Drawing.Size(213, 26);
            this.speedHzLabel.TabIndex = 14;
            this.speedHzLabel.Text = "Encoder Speed (Hz)";
            // 
            // pwmText
            // 
            this.pwmText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwmText.Location = new System.Drawing.Point(921, 187);
            this.pwmText.Name = "pwmText";
            this.pwmText.Size = new System.Drawing.Size(183, 32);
            this.pwmText.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(916, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "PWM %:";
            // 
            // directionCheck
            // 
            this.directionCheck.AutoSize = true;
            this.directionCheck.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.directionCheck.Location = new System.Drawing.Point(921, 234);
            this.directionCheck.Name = "directionCheck";
            this.directionCheck.Size = new System.Drawing.Size(213, 30);
            this.directionCheck.TabIndex = 22;
            this.directionCheck.Text = "Reverse Direction";
            this.directionCheck.UseVisualStyleBackColor = true;
            // 
            // commandButton
            // 
            this.commandButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandButton.Location = new System.Drawing.Point(921, 270);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(213, 34);
            this.commandButton.TabIndex = 23;
            this.commandButton.Text = "Send Command";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // positionModCheck
            // 
            this.positionModCheck.AutoSize = true;
            this.positionModCheck.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.positionModCheck.Location = new System.Drawing.Point(921, 434);
            this.positionModCheck.Name = "positionModCheck";
            this.positionModCheck.Size = new System.Drawing.Size(212, 30);
            this.positionModCheck.TabIndex = 24;
            this.positionModCheck.Text = "Modulate position";
            this.positionModCheck.UseVisualStyleBackColor = true;
            this.positionModCheck.CheckedChanged += new System.EventHandler(this.positionModCheck_CheckedChanged);
            // 
            // speedModCheck
            // 
            this.speedModCheck.AutoSize = true;
            this.speedModCheck.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.speedModCheck.Location = new System.Drawing.Point(921, 398);
            this.speedModCheck.Name = "speedModCheck";
            this.speedModCheck.Size = new System.Drawing.Size(191, 30);
            this.speedModCheck.TabIndex = 25;
            this.speedModCheck.Text = "Modulate speed";
            this.speedModCheck.UseVisualStyleBackColor = true;
            this.speedModCheck.CheckedChanged += new System.EventHandler(this.speedModCheck_CheckedChanged);
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Enabled = true;
            this.feedbackTimer.Interval = 1000;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // speedModText
            // 
            this.speedModText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedModText.Location = new System.Drawing.Point(559, 417);
            this.speedModText.Name = "speedModText";
            this.speedModText.Size = new System.Drawing.Size(183, 32);
            this.speedModText.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(554, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Diff";
            // 
            // posModText
            // 
            this.posModText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posModText.Location = new System.Drawing.Point(559, 353);
            this.posModText.Name = "posModText";
            this.posModText.Size = new System.Drawing.Size(183, 32);
            this.posModText.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(554, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Target";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 482);
            this.Controls.Add(this.posModText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedModText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedModCheck);
            this.Controls.Add(this.positionModCheck);
            this.Controls.Add(this.commandButton);
            this.Controls.Add(this.directionCheck);
            this.Controls.Add(this.pwmText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedHzText);
            this.Controls.Add(this.speedHzLabel);
            this.Controls.Add(this.speedRPMText);
            this.Controls.Add(this.positionText);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.baudRateText);
            this.Controls.Add(this.comCombo);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.speedRPMLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.speedChart);
            this.Name = "Form1";
            this.Text = "Lab 3 Encoder Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label speedRPMLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.TextBox baudRateText;
        private System.Windows.Forms.ComboBox comCombo;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox positionText;
        private System.Windows.Forms.TextBox speedRPMText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox speedHzText;
        private System.Windows.Forms.Label speedHzLabel;
        private System.Windows.Forms.TextBox pwmText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox directionCheck;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.CheckBox positionModCheck;
        private System.Windows.Forms.CheckBox speedModCheck;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.TextBox speedModText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox posModText;
        private System.Windows.Forms.Label label2;
    }
}

