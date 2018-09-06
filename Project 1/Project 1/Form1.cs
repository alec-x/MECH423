using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class formMainWindow : Form
    {
        //class vars
        int timeCounter;
        int currentTime;
        int itemLimit = 20;

        public formMainWindow()
        {
            InitializeComponent();
        }

        private void deltaTListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yCoordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void xCoordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawingWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawingWindow_MouseMove(object sender, MouseEventArgs e)
        {
            xCoordTextBox.Text = e.X.ToString("0000");
            yCoordTextBox.Text = e.Y.ToString("0000");

            //calculate time delay between moves
            currentTime = timeCounter * TimerMoveDelayCounter.Interval;
            deltaTListBox.Items.Add(currentTime.ToString("000000"));
            timeCounter = 0; //restart counter

            while (deltaTListBox.Items.Count > itemLimit)
            {
                deltaTListBox.Items.RemoveAt(0);
            }

            deltaTListBox.SelectedIndex = deltaTListBox.Items.Count - 1;
        }

        private void TimerMoveDelayCounter_Tick(object sender, EventArgs e)
        {
            timeCounter++;
        }
    }
}
