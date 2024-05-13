using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Entities
{
    internal class InfoConnexionAzure
    {
        private static string _connectionstring;
        private static string _iothubname;

        public InfoConnexionAzure(string Connectionstring,string Iothubname)
        {
            _connectionstring = Connectionstring;
            _iothubname = Iothubname;
        }




        public string GetConnectionString()
        {
            return _connectionstring;
        }
        public string GetIoTHubName()
        {
            return _iothubname;
        }
    }
}
