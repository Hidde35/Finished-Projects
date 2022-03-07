using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ControllerApp
{
    public partial class Form1 : Form
    {
        private int PortCheck = 0;

        ConnectArduino Arduino = new ConnectArduino();
        sensor mkr1000 = new sensor("mkr1000", "de code opslaan en runnen vanaf dit apparaat");
        sensor Mpu6050 = new sensor("MPU6050", "het meten van de bewegingen");
        sensor speaker = new sensor("Speaker", "het maken van geluidjes op bepaalde momenten in het spel");

        public Form1()
        {
            InitializeComponent();
        }

        //informatie over sensoren
        private void ShowData_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("de " + mkr1000.getNaam() + " heeft als nut: " + mkr1000.getNut);
            MessageBox.Show("de " + Mpu6050.getNaam() + " heeft als nut: " + Mpu6050.getNut);
            MessageBox.Show("de " + speaker.getNaam() + " heeft als nut: " + speaker.getNut);
        }

        //Connect met de arduino
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string ComString = "COM" + textComString.Text;
            Arduino.setCOM(ComString);
            bool IsConnected2 = Arduino.connect();
            if (IsConnected2 == true && PortCheck != 1)
            {
                PortCheck = 1;
                textReadConnected.Visible = true;
                textColorConnected.Visible = true;
                textColorNotConnected.Visible = false;
                textReadNotConnected.Visible = false;
                buttonPlayDeadMelodie.Enabled = true;
            }
            else if(IsConnected2 == false && PortCheck != 1)
            {
                MessageBox.Show("Kan niet verbinden, kijk of uw apparaat goed is aangesloten!");
            }
        }

        //Leest de arduino
        private void buttonReadArduino_Click(object sender, EventArgs e)
        {
            PictureHandschoen.Visible = false;
            if (PortCheck == 1)
            {
                timerReadArduino.Enabled = true;
            }
            else if(PortCheck == 0)
            {
                MessageBox.Show("U moet eerst verbinden voordat u dit kan doen!");
            }
        }


        private void TimerTickReadArduino(object sender, EventArgs e)
        {
                //haalt informatie op uit de arduino
                string InfoArduino = Arduino.Read();
                //roept de beweging.set op vervormd de message
                Mpu6050.beweging = InfoArduino;
                //roept de beweging.get op en laat de vervormde message zien
                ShowArduinoText.Text = Mpu6050.beweging;
                //verandert de arrow
                ClearArrows();
                switch (Mpu6050.beweging)
                {
                    case "voor":
                        ArrowUp.Visible = true;
                        break;
                    case "achter":
                        ArrowDown.Visible = true;
                        break;
                    case "rechts":
                        ArrowRight.Visible = true;
                        break;
                    case "links":
                        ArrowLeft.Visible = true;
                        break;
                }
        }

        private void ButtonStopArduino_Click(object sender, EventArgs e)
        {
            timerReadArduino.Enabled = false;
            ClearArrows();
            ShowArduinoText.Text = "";
            PictureHandschoen.Visible = true;
        }

        private void textComString_TextChanged(object sender, EventArgs e)
        {
        }

        private void ClearArrows()
        {
            ArrowUp.Visible = false;
            ArrowDown.Visible = false;
            ArrowRight.Visible = false;
            ArrowLeft.Visible = false;
        }

        private void buttonPlayDeadMelodie_Click(object sender, EventArgs e)
        {
            Arduino.PlayDeadMelodie();
        }
    }
}
