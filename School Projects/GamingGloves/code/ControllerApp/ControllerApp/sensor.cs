using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerApp
{
    class sensor
    {
        private string naam;
        private string nut;
        private string _bewegingOntcijferd = "";

        public sensor(string _naam, string _nut)
        {
            naam = _naam;
            nut = _nut;
        }

        public string beweging
        {
            get { return _bewegingOntcijferd; }
            set
            {
                switch (value)
                {
                    case "#A%\r":
                        _bewegingOntcijferd = "achter";
                        break;
                    case "#V%\r":
                        _bewegingOntcijferd = "voor";
                        break;
                    case "#L%\r":
                        _bewegingOntcijferd = "links";
                        break;
                    case "#R%\r":
                        _bewegingOntcijferd = "rechts";
                        break;
                    default:
                        _bewegingOntcijferd = "Geen beweging gevonden";
                        break;
                }
            }
        }

        public string getNaam()
        {
            return naam;
        }
        public string getNut
        {
            get { return nut; }
        }
    }
}
    