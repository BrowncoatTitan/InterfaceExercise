using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public bool Runs { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string BrandName { get; set; }
        public string WebSite { get; set; }
        public int SeatNum { get; set; }
        public bool HasThirdRow { get; set; }
    }
}
