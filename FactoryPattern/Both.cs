using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Both : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfPassengers { get; set; }

        public void Availability()
        {
            Console.WriteLine("Sorry we do not have any SUVs at this time.");
        }
    }
}
