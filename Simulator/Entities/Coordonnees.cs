using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Entities
{
    internal class Coordonnees
    {
        private double _longitude;
        private double _latitude;

        public Coordonnees(double longitude, double latitude)
        {
            _longitude = longitude;
            _latitude = latitude;
        }
        public double Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

    }
}