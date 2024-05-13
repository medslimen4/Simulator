using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Entities
{
    internal class Vehicule
    {
        private string _matricule;
        private string _modele;
        private string _couleur;
        private string _marque;
        private string _connectionstring;
        private Coordonnees _coordinates;






        public Vehicule(string Connectionstring,string Matricule , string Modele , string Couleur , string Marque )
        {
            _connectionstring = Connectionstring;
            _matricule = Matricule;
            _modele = Modele;
            _couleur = Couleur;
            _marque = Marque;


        }

        public String Marque
        {
            get { return _marque; }
        }


        public Coordonnees GetCoordinates()
        {
            
                return _coordinates= GenerateRandomCoordinates();
            
        }
        private Coordonnees GenerateRandomCoordinates()
        {
            Random rnd = new Random();
            double longitude = rnd.NextDouble() * 360 - 180;
            double latitude = rnd.NextDouble() * 180 - 90;
            return new Coordonnees(longitude, latitude);
        }




        public string GetConnectionInfo()
        {
            return _connectionstring;
        }
    }
}
