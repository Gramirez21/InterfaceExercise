using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck: IVehicle,ICompany
    {
        public string TireSize {  get; set; }
        public bool IsThisATruck { get; set; }
        public int NumberOfWheels { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public void CarDetails(Truck truck)
        {
            Console.WriteLine("You have selected Truck");
            Console.WriteLine($"Truck Details Make:{truck.Make}");
            Console.WriteLine($"Model:{truck.Model}");
            Console.WriteLine($"Year:{truck.Year}");
            Console.WriteLine($"Number of Wheel:{truck.NumberOfWheels} ");
            Console.WriteLine($"Does it have a trunk {truck.TireSize}");
            Console.WriteLine($"Is this a truck:{truck.IsThisATruck}");
            Console.WriteLine($"Company Name: {truck.Name}");
            Console.WriteLine($"Country of orgin: {truck.Country}");
        }

        
    }
}
