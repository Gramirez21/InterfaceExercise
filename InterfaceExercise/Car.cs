using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car: IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool IsThisACar {  get; set; }
        public int NumberOfWheels {get; set;}
        public int Year {get; set;}
        public string Model {get; set;}
        public string Make {get; set;}
        public string Name {get; set;}
        public string Country {get; set;}

        public void CarDetails(Car car)
        {
                
            Console.WriteLine("You have selected car");
            Console.WriteLine($"Car Details Make:{car.Make}");
            Console.WriteLine($"Model:{car.Model}");
            Console.WriteLine($"Year:{car.Year}");
            Console.WriteLine($"Number of Wheel:{car.NumberOfWheels} ");
            Console.WriteLine($"Does it have a trunk {car.HasTrunk}");
            Console.WriteLine($"Is this a car:{car.IsThisACar}");
            Console.WriteLine($"Company Name: {car.Name}");
            Console.WriteLine($"Country of orgin: {car.Country}");
           


        }

        public void CarDetails()
        {
           Console.WriteLine();
        }
    }
}
