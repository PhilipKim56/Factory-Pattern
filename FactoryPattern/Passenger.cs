using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    
    public class Passenger : IVehicle
    {
        public string BodyType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Availability()
        {
            Console.WriteLine("We have 20 vehicles to choose from.");
        }
    }
}
