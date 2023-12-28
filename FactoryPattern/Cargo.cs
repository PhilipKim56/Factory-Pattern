using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Cargo : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string CargoArea { get; set; }

        public void Availability()
        {
            Console.WriteLine("We have 5 vans and 15 trucks to choos from.");
        }
    }
    
    
}
