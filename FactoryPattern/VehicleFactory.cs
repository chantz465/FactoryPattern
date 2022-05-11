using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(string input)
        {
            switch (input.ToLower())
            {
                case "4":
                    return new Car() { Color = "Blue", IsDriveable = true };
                    
                case "2":
                    return new Motorcycle() { Color = "Black", HasFootShifter = true};
                case "18":
                    return new BigRig() { Color = "White", HasMoreThenTenGeers = true };
                 
                default:
                    return new Truck() { Color = "tan" , HasFourWheelDrive = true};
                    
            }


        }



    }
}
