using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; }
        public int NumberOfWindows { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Product { get; set; }
        public int NumberOfWheels { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public void CarDetails(SUV suv)
        {
            Console.WriteLine("You have selected SUV");
            Console.WriteLine($"SUV Details Make:{suv.Make}");
            Console.WriteLine($"Model:{suv.Model}");
            Console.WriteLine($"Year:{suv.Year}");
            Console.WriteLine($"Number of Wheel:{suv.NumberOfWheels} ");
            Console.WriteLine($"Does it have a trunk {suv.NumberOfWindows}");
            Console.WriteLine($"Is this a suv:{suv.NumberOfSeats}");
            Console.WriteLine($"Company Name: {suv.Name}");
            Console.WriteLine($"Country of orgin: {suv.Country}");
        }
    }
}
