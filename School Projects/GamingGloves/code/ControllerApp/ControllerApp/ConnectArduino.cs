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
    class ConnectArduino
    {
        private SerialPort myport;

        private bool IsConnected;
        private bool ConnectCheck;
        private string ReadArduino;
        private string COM;

        public ConnectArduino()
        {
            IsConnected = false;
            ConnectCheck = true;
        }

        public bool connect()
        {
            if (ConnectCheck == true)
            {
                try
                {
                    myport = new SerialPort();
                    myport.BaudRate = 115200;
                    myport.PortName = COM;
                    myport.Open();
                    IsConnected = true;
                    ConnectCheck = false;
                }
                catch (System.IO.IOException)
                {
                }
            }
            else
            {
                MessageBox.Show("Je bent al verbonden");
            }
            return IsConnected;
        }

        public string Read()
        {
            if (myport.IsOpen
                && myport.BytesToRead > 0)
            {
                ReadArduino = myport.ReadLine();
                return ReadArduino;
            }
            return null;
        }

        public void PlayDeadMelodie()
        {
            myport.Write("#D%");
        }

        public void setCOM(string newCOM)
        {
            if (newCOM != "")
            {
                COM = newCOM;
            }
        }
    }
}
