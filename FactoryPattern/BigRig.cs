using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public string Color { get; set; }

        public bool HasMoreThenTenGeers { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving the big rig up the road and burn so much fuel");
        }

    }
}
