using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */


            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car1 = new Car()
            {
                BrandName = "Birmingham Honda",
                WebSite = "www.bhamhonda.com",
                Runs = true,
                TrunkSize = "Big",
                Make = "Honda",
                Model = "Accord",
                Year = 2013,
                Coupe = true
            };
            Truck truck1 = new Truck()
            {
                TireNum = 6,
                BedDimensions = "6.5 x 4",
                Runs = true,
                Make= "Ford",
                Model = "F-150",
                Year = 2016,
                BrandName = "Texas Ford",
                WebSite = "www.texasford.com"
            };
            SUV suv1 = new SUV()
            {
                Runs = false,
                Make = "GMC",
                Model = "Jimmy",
                Year = 1985,
                BrandName = "GMC of Ontario",
                WebSite = "www.ontariogmc",
                SeatNum = 5,
                HasThirdRow = false,
            };
            Methods.VehicleDetailDisplay(car1);
            Methods.VehicleDetailDisplay(suv1);
            Methods.VehicleDetailDisplay(truck1);
        }
    }
}
