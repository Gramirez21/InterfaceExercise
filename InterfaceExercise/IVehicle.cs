using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }

        public  int Year { get; set; }
        public string Model { get; set; }   
        public string Make { get; set; }

        
    }

    
}
