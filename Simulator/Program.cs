using Simulator.Entities;
using Simulator.Metier;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicule> Vehicules = new List<Vehicule>();
        
        for (int i = 0; i < 2; i++)
        {
       
        Console.WriteLine("Enter the Azure connection string:");
        string connectionString = Console.ReadLine();

        Console.WriteLine("Enter the IoT Hub name:");
        string ioTHubName = Console.ReadLine();

        Console.WriteLine("Enter the vehicle matricule:");
        string matricule = Console.ReadLine();

        Console.WriteLine("Enter the vehicle model:");
        string modele = Console.ReadLine();

        Console.WriteLine("Enter the vehicle Couleur:");
        string couleur = Console.ReadLine();

        Console.WriteLine("Enter the vehicle marque :");
        string marque = Console.ReadLine();





            InfoConnexionAzure info = new InfoConnexionAzure(connectionString, ioTHubName);
            
            Vehicule vehicle = new Vehicule(info.GetConnectionString(), matricule, modele, couleur, marque);
            Vehicules.Add(vehicle);
        }

        foreach (Vehicule v in Vehicules)
        {
            GererVehicule g = new GererVehicule(v);
            g.demarrervehicule();  
        }

    }
 }
            