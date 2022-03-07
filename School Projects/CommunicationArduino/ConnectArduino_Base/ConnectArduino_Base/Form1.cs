using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectArduino_Base
{
    public partial class Form1 : Form
    {
        ConnectArduino Arduino = new ConnectArduino();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            bool result = Arduino.connect(textComString.Text);
            if (result)
            {
                textReadConnected.Visible = true;
                textColorConnected.Visible = true;
                textColorNotConnected.Visible = false;
                textReadNotConnected.Visible = false;
            }
            else
            {
                MessageBox.Show("Kan niet verbinden, kijk of uw apparaat goed is aangesloten!");
            }
        }

        private void buttonReadArduino_Click(object sender, EventArgs e)
        {
            timerReadArduino.Enabled = true;
        }

        private void ButtonStopArduino_Click(object sender, EventArgs e)
        {
            timerReadArduino.Enabled = false;
            ShowArduinoText.Text = "";
        }

        private void timerReadArduino_Tick(object sender, EventArgs e)
        {
            string InfoArduino = Arduino.ReadMessage();
            ShowArduinoText.Text = InfoArduino;
        }
    }
}

