using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Truck : IVehicle
    {
        public string Color { get; set; }

        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {

            if (HasFourWheelDrive == true)
                Console.WriteLine("taken the truck mudding");
            else
                Console.WriteLine("taking the truck to the store and crying inside");
        }


    }
}
