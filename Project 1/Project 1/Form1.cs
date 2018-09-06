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
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void timerMoveDelayCounter_Tick(object sender, EventArgs e)
        {

        }
    }
}
