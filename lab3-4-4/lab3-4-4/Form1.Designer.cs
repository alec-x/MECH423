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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // speedChart
            // 
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY2.Crossing = 0D;
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Name = "Legend1";
            this.speedChart.Legends.Add(legend2);
            this.speedChart.Location = new System.Drawing.Point(12, 72);
            this.speedChart.Name = "speedChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "encoderPosition";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "motorSpeed";
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.speedChart.Series.Add(series3);
            this.speedChart.Series.Add(series4);
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
            this.speedRPMLabel.Location = new System.Drawing.Point(554, 137);
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
            this.speedRPMText.Location = new System.Drawing.Point(559, 166);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
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
    }
}

