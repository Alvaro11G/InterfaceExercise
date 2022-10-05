using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        //Cars memebers
        public string Trunk { get; set; }
        public string LowToGround { get; set; }
        //IVehicle memebrs
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool FourTires { get; set; }
        //ICompany members
        public string Founder { get; set; }
        public string Origin { get; set; }
    }
}
