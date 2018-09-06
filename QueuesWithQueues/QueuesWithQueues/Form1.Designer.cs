namespace QueuesWithQueues
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
            this.ButtonAddToQueue = new System.Windows.Forms.Button();
            this.ButtonGetFromQueue = new System.Windows.Forms.Button();
            this.ButtonQueueItems = new System.Windows.Forms.Button();
            this.ButtonAvg = new System.Windows.Forms.Button();
            this.TextAddToQueue = new System.Windows.Forms.TextBox();
            this.TextGetFromQueue = new System.Windows.Forms.TextBox();
            this.TextN = new System.Windows.Forms.TextBox();
            this.TextQueueItems = new System.Windows.Forms.TextBox();
            this.TextAvg = new System.Windows.Forms.TextBox();
            this.LabelN = new System.Windows.Forms.Label();
            this.LabelAvg = new System.Windows.Forms.Label();
            this.ListQueueContents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonAddToQueue
            // 
            this.ButtonAddToQueue.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.ButtonAddToQueue.Location = new System.Drawing.Point(12, 12);
            this.ButtonAddToQueue.Name = "ButtonAddToQueue";
            this.ButtonAddToQueue.Size = new System.Drawing.Size(172, 30);
            this.ButtonAddToQueue.TabIndex = 0;
            this.ButtonAddToQueue.Text = "Add to Queue";
            this.ButtonAddToQueue.UseVisualStyleBackColor = true;
            // 
            // ButtonGetFromQueue
            // 
            this.ButtonGetFromQueue.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.ButtonGetFromQueue.Location = new System.Drawing.Point(12, 51);
            this.ButtonGetFromQueue.Name = "ButtonGetFromQueue";
            this.ButtonGetFromQueue.Size = new System.Drawing.Size(172, 30);
            this.ButtonGetFromQueue.TabIndex = 1;
            this.ButtonGetFromQueue.Text = "Get from Queue";
            this.ButtonGetFromQueue.UseVisualStyleBackColor = true;
            // 
            // ButtonQueueItems
            // 
            this.ButtonQueueItems.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.ButtonQueueItems.Location = new System.Drawing.Point(12, 90);
            this.ButtonQueueItems.Name = "ButtonQueueItems";
            this.ButtonQueueItems.Size = new System.Drawing.Size(172, 30);
            this.ButtonQueueItems.TabIndex = 2;
            this.ButtonQueueItems.Text = "Items in Queue";
            this.ButtonQueueItems.UseVisualStyleBackColor = true;
            // 
            // ButtonAvg
            // 
            this.ButtonAvg.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.ButtonAvg.Location = new System.Drawing.Point(12, 129);
            this.ButtonAvg.Name = "ButtonAvg";
            this.ButtonAvg.Size = new System.Drawing.Size(172, 30);
            this.ButtonAvg.TabIndex = 3;
            this.ButtonAvg.Text = "Avg of Last N";
            this.ButtonAvg.UseVisualStyleBackColor = true;
            // 
            // TextAddToQueue
            // 
            this.TextAddToQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextAddToQueue.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.TextAddToQueue.Location = new System.Drawing.Point(190, 11);
            this.TextAddToQueue.Name = "TextAddToQueue";
            this.TextAddToQueue.Size = new System.Drawing.Size(308, 31);
            this.TextAddToQueue.TabIndex = 5;
            // 
            // TextGetFromQueue
            // 
            this.TextGetFromQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextGetFromQueue.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.TextGetFromQueue.Location = new System.Drawing.Point(190, 50);
            this.TextGetFromQueue.Name = "TextGetFromQueue";
            this.TextGetFromQueue.Size = new System.Drawing.Size(308, 31);
            this.TextGetFromQueue.TabIndex = 6;
            // 
            // TextN
            // 
            this.TextN.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.TextN.Location = new System.Drawing.Point(221, 129);
            this.TextN.Name = "TextN";
            this.TextN.Size = new System.Drawing.Size(83, 31);
            this.TextN.TabIndex = 7;
            // 
            // TextQueueItems
            // 
            this.TextQueueItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextQueueItems.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.TextQueueItems.Location = new System.Drawing.Point(190, 89);
            this.TextQueueItems.Name = "TextQueueItems";
            this.TextQueueItems.Size = new System.Drawing.Size(308, 31);
            this.TextQueueItems.TabIndex = 8;
            // 
            // TextAvg
            // 
            this.TextAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextAvg.Font = new System.Drawing.Font("Consolas", 11.8F);
            this.TextAvg.Location = new System.Drawing.Point(367, 129);
            this.TextAvg.Name = "TextAvg";
            this.TextAvg.Size = new System.Drawing.Size(131, 31);
            this.TextAvg.TabIndex = 9;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.LabelN.Location = new System.Drawing.Point(190, 130);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(25, 28);
            this.LabelN.TabIndex = 10;
            this.LabelN.Text = "N";
            // 
            // LabelAvg
            // 
            this.LabelAvg.AutoSize = true;
            this.LabelAvg.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.LabelAvg.Location = new System.Drawing.Point(310, 130);
            this.LabelAvg.Name = "LabelAvg";
            this.LabelAvg.Size = new System.Drawing.Size(51, 28);
            this.LabelAvg.TabIndex = 11;
            this.LabelAvg.Text = "Avg";
            // 
            // ListQueueContents
            // 
            this.ListQueueContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListQueueContents.FormattingEnabled = true;
            this.ListQueueContents.ItemHeight = 16;
            this.ListQueueContents.Location = new System.Drawing.Point(12, 165);
            this.ListQueueContents.Name = "ListQueueContents";
            this.ListQueueContents.Size = new System.Drawing.Size(486, 228);
            this.ListQueueContents.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 403);
            this.Controls.Add(this.ListQueueContents);
            this.Controls.Add(this.LabelAvg);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.TextAvg);
            this.Controls.Add(this.TextQueueItems);
            this.Controls.Add(this.TextN);
            this.Controls.Add(this.TextGetFromQueue);
            this.Controls.Add(this.TextAddToQueue);
            this.Controls.Add(this.ButtonAvg);
            this.Controls.Add(this.ButtonQueueItems);
            this.Controls.Add(this.ButtonGetFromQueue);
            this.Controls.Add(this.ButtonAddToQueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddToQueue;
        private System.Windows.Forms.Button ButtonGetFromQueue;
        private System.Windows.Forms.Button ButtonQueueItems;
        private System.Windows.Forms.Button ButtonAvg;
        private System.Windows.Forms.TextBox TextAddToQueue;
        private System.Windows.Forms.TextBox TextGetFromQueue;
        private System.Windows.Forms.TextBox TextN;
        private System.Windows.Forms.TextBox TextAvg;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label LabelAvg;
        private System.Windows.Forms.ListBox ListQueueContents;
        private System.Windows.Forms.TextBox TextQueueItems;
    }
}

