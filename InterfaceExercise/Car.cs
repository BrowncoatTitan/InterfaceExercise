using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public string TrunkSize { get; set; }
        public string BrandName { get; set; }
        public string WebSite { get; set; }
        public bool Runs { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public bool Coupe { get; set; }
    }
}
