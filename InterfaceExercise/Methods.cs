using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Methods
    {
        public static void VehicleDetailDisplay(Car car)
        {
            Console.WriteLine($"This car has the following properties:");
            Console.WriteLine(car.TrunkSize);
            Console.WriteLine(car.BrandName);
            Console.WriteLine(car.WebSite);
            Console.WriteLine($"Runs Well: {car.Runs}");
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
            Console.WriteLine($"Coupe: {car.Coupe}");
            Console.WriteLine();
        }
        public static void VehicleDetailDisplay(SUV suv)
        {
            Console.WriteLine($"This SUV has the following properties:");
            Console.WriteLine(suv.SeatNum);
            Console.WriteLine(suv.BrandName);
            Console.WriteLine(suv.WebSite);
            Console.WriteLine($"Runs Well: {suv.Runs}");
            Console.WriteLine(suv.Make);
            Console.WriteLine(suv.Model);
            Console.WriteLine(suv.Year);
            Console.WriteLine($"Has a third Row: {suv.HasThirdRow}");
            Console.WriteLine();
        }
        public static void VehicleDetailDisplay(Truck truck)
        {
            Console.WriteLine($"This truck has the following properties:");
            Console.WriteLine(truck.BedDimensions);
            Console.WriteLine(truck.BrandName);
            Console.WriteLine(truck.WebSite);
            Console.WriteLine($"Runs Well: {truck.Runs}");
            Console.WriteLine(truck.Make);
            Console.WriteLine(truck.Model);
            Console.WriteLine(truck.Year);
            Console.WriteLine(truck.TireNum);
            Console.WriteLine();
        }
    }
}
