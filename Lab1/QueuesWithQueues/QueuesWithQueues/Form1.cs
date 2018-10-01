using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuesWithQueues
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<UInt32> dataQueue = new ConcurrentQueue<UInt32>();

        public Form1()
        {
            InitializeComponent();  
        }

        private void ButtonAddToQueue_Click(object sender, EventArgs e)
        {
            UInt32 numToAdd;
            if (UInt32.TryParse(TextAddToQueue.Text, out numToAdd))
            {
                dataQueue.Enqueue(numToAdd);
            }
            else
            {
                Console.WriteLine("There is no number to add");
            }
        }

        private void ButtonGetFromQueue_Click(object sender, EventArgs e)
        {
            UInt32 numToGet;
            if (dataQueue.TryDequeue(out numToGet))
            {
                TextGetFromQueue.Text = numToGet.ToString();
            }
            else
            {
                Console.WriteLine("Empty queue, nothing to get");
            }
        }

        private void ButtonQueueItems_Click(object sender, EventArgs e)
        {
            TextQueueItems.Text = (dataQueue.Count).ToString();
        }

        private void ButtonAvg_Click(object sender, EventArgs e)
        {
            UInt32 numN;
            double sum = 0;
            UInt32[] dataArray = dataQueue.ToArray();

            if (UInt32.TryParse(TextN.Text, out numN) && numN <= dataArray.Length)
            {
                int startIndex = dataArray.Length - 1;
                int endIndex = startIndex - (int)numN;
                for (int i = startIndex; i > endIndex; i--)
                {
                    sum += dataArray[i];
                }
                TextAvg.Text = Math.Round((sum / numN), 4).ToString();
            }
            else
            {
                Console.WriteLine("N is either too large or not an integer");
            }

        }

        private void TimerQueueList_Tick(object sender, EventArgs e)
        {
            ListQueueContents.Items.Clear();
            foreach(UInt32 i in dataQueue)
            {
                ListQueueContents.Items.Add(i.ToString());
            }
            
        }
    }
}
