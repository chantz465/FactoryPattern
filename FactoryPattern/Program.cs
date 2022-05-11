using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make?");
            string input = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(input);

            myVehicle.Drive();

            
        }
    }
}
