using System;
using System.Collections.Generic;

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
            Car tesla = new Car()
            {
                Trunk = "big",
                LowToGround = "yes",
                Year = "2020",
                Make = "Tesla",
                Model = "Model 3",
                FourTires = true,
                Founder = "Elon Musk",
                Origin = "California"
            };
            Truck dodge = new Truck()
            {
                BedSize = "big",
                Lifted = "yes",
                Year = "2020",
                Make = "dodge",
                Model = "1500",
                FourTires = true,
                Founder = "John dodge",
                Origin = "Michigan"
            };
            SUV jeep = new SUV()
            {
                CargoHold = "small",
                SUVtype = "midsize",
                Year = "2020",
                Make = "jeep",
                Model = "Grand Cherokee",
                FourTires = true,
                Founder = "Karl Probst",
                Origin = "Ohio"
            };

            //Creatively display and organize their values
            List<IVehicle> Vehicles = new List<IVehicle>();
            Vehicles.Add(tesla);
            Vehicles.Add(dodge);
            Vehicles.Add(jeep);

            foreach(IVehicle vehicle in Vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}, Has 4 tires?: {vehicle.FourTires}");
            }
            Console.WriteLine($"\nFounders: {tesla.Founder}, {dodge.Founder}, {jeep.Founder}");
            Console.WriteLine($"Origins: {tesla.Origin}, {dodge.Origin}, {jeep.Origin}\n");

            Console.WriteLine($"What is the size of the cars trunk? - {tesla.Trunk}. Is tesla car low to the ground? - {tesla.LowToGround}.");

            Console.WriteLine($"Is the truck lifted? - {dodge.Lifted}. What is the size of the bed? - {dodge.BedSize}.");

            Console.WriteLine($"What is the size of the cargo hold for the SUV? - {jeep.CargoHold}. What type of SUV is it? - {jeep.SUVtype}.");
        }
    }
}
