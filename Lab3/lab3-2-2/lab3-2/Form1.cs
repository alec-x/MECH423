using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        byte[] TxBytes = new Byte[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            toggleConnect();
        }

        private void comCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changePort();
        }

        private void comCombo_Click(object sender, EventArgs e)
        {
            updatePortList();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendBytes();
        }

        private void duty1Text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(duty1Text.Text, "[^0-9]"))
            {
                Console.WriteLine("Please enter only numbers.");
                duty1Text.Text = duty1Text.Text.Remove(duty1Text.Text.Length - 1);
            }
        }

        private void duty2Text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(duty2Text.Text, "[^0-9]"))
            {
                Console.WriteLine("Please enter only numbers.");
                duty2Text.Text = duty2Text.Text.Remove(duty2Text.Text.Length - 1);
            }
        }

        private void directionText_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(directionText.Text, "[^0-1]"))
            {
                Console.WriteLine("Please enter only binary.");
                directionText.Text = directionText.Text.Remove(directionText.Text.Length - 1);
            }
        }

        private void escapeText_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(escapeText.Text, "[^0-9]"))
            {
                Console.WriteLine("Please enter only numbers.");
                escapeText.Text = escapeText.Text.Remove(escapeText.Text.Length - 1);
            }
        }
    }
}
