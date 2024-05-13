using Microsoft.Azure.Devices.Client;
using Simulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulator.Metier
{
    internal class GererVehicule
    {
        private Vehicule _Vehicule;
        private readonly DeviceClient _deviceClient;





        public GererVehicule(Vehicule Vehicule)
        {
            _Vehicule = Vehicule;
            _deviceClient = DeviceClient.CreateFromConnectionString(_Vehicule.GetConnectionInfo().ToString(), TransportType.Mqtt);

        }
        public void demarrervehicule() {
            Thread tracking = new Thread(new ThreadStart(suivirevehicule));
            tracking.Start();


        }


        private async void suivirevehicule()
        {

            while (true)
            {

                Coordonnees co = _Vehicule.GetCoordinates();
                string messageString = $"{{\"Longitude\": {co.Longitude}, \"Latitude\": {co.Latitude}}}";
                Message message = new Message(Encoding.UTF8.GetBytes(messageString));

                _deviceClient.SendEventAsync(message).GetAwaiter().GetResult();

                Console.WriteLine(_Vehicule.Marque+"  Vehicle coordinates sent to IoT Hub.");


                Thread.Sleep(5000);

            }

        }
       
    }
}
