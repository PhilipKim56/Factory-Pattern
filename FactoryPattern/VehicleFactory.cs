using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle Create(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "passenger":
                    return new Passenger();

                case "cargo":
                    return new Cargo();

                case "both":
                    return new Both();

                default:
                    return new Passenger();
                    

            }
        }
    }
}
