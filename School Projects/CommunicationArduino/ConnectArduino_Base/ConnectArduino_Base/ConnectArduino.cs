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

namespace ConnectArduino_Base
{
    class ConnectArduino
    {
        private SerialPort myport;
        private bool IsConnected;
        private string ReadArduino;

        public ConnectArduino()
        {
            IsConnected = false;
        }

        public bool connect(string COM)
        {
            if (!IsConnected && COM != "")
            {
                try
                {
                    myport = new SerialPort();
                    myport.BaudRate = 115200;
                    myport.PortName = "COM" + COM;
                    myport.Open();
                    IsConnected = true;
                }
                catch (System.IO.IOException)
                {
                }
            }
            return IsConnected;
        }

        public string ReadMessage()
        {
            if (myport.IsOpen
                && myport.BytesToRead > 0)
            {
                ReadArduino = myport.ReadLine();
                return ReadArduino;
            }
            return null;
        }

        public void SendMessage(string Message)
        {
            myport.Write("#" + Message + "%");
        }
    }
}
