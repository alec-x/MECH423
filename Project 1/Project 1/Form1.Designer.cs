namespace Project_1
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
            this.xCoordTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yCoordTextBox = new System.Windows.Forms.TextBox();
            this.deltaTListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drawingWindow = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerMoveDelayCounter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // xCoordTextBox
            // 
            this.xCoordTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCoordTextBox.Location = new System.Drawing.Point(56, 12);
            this.xCoordTextBox.Name = "xCoordTextBox";
            this.xCoordTextBox.Size = new System.Drawing.Size(131, 34);
            this.xCoordTextBox.TabIndex = 0;
            this.xCoordTextBox.TextChanged += new System.EventHandler(this.xCoordTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // yCoordTextBox
            // 
            this.yCoordTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCoordTextBox.Location = new System.Drawing.Point(56, 52);
            this.yCoordTextBox.Name = "yCoordTextBox";
            this.yCoordTextBox.Size = new System.Drawing.Size(131, 34);
            this.yCoordTextBox.TabIndex = 2;
            this.yCoordTextBox.TextChanged += new System.EventHandler(this.yCoordTextBox_TextChanged);
            // 
            // deltaTListBox
            // 
            this.deltaTListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deltaTListBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaTListBox.FormattingEnabled = true;
            this.deltaTListBox.ItemHeight = 27;
            this.deltaTListBox.Location = new System.Drawing.Point(12, 120);
            this.deltaTListBox.Name = "deltaTListBox";
            this.deltaTListBox.Size = new System.Drawing.Size(175, 247);
            this.deltaTListBox.Sorted = true;
            this.deltaTListBox.TabIndex = 4;
            this.deltaTListBox.SelectedIndexChanged += new System.EventHandler(this.deltaTListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "DeltaT";
            // 
            // drawingWindow
            // 
            this.drawingWindow.AcceptsReturn = true;
            this.drawingWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingWindow.Location = new System.Drawing.Point(193, 12);
            this.drawingWindow.Multiline = true;
            this.drawingWindow.Name = "drawingWindow";
            this.drawingWindow.ReadOnly = true;
            this.drawingWindow.Size = new System.Drawing.Size(330, 357);
            this.drawingWindow.TabIndex = 8;
            this.drawingWindow.Text = "Drawing Window";
            this.drawingWindow.TextChanged += new System.EventHandler(this.drawingWindow_TextChanged);
            this.drawingWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingWindow_MouseMove);
            // 
            // timerMoveDelayCounter
            // 
            this.timerMoveDelayCounter.Enabled = true;
            this.timerMoveDelayCounter.Interval = 50;
            this.timerMoveDelayCounter.Tick += new System.EventHandler(this.timerMoveDelayCounter_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 386);
            this.Controls.Add(this.drawingWindow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deltaTListBox);
            this.Controls.Add(this.yCoordTextBox);
            this.Controls.Add(this.xCoordTextBox);
            this.MinimumSize = new System.Drawing.Size(379, 298);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xCoordTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox yCoordTextBox;
        private System.Windows.Forms.ListBox deltaTListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drawingWindow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerMoveDelayCounter;
    }
}

