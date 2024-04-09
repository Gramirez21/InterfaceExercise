using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            Car car = new Car();   
            Truck truck = new Truck();
            SUV suv = new SUV();

            suv.Make = "Subaru";
            suv.Model = "Crosstek";
            suv.Year = 2023;
            suv.NumberOfWheels = 4;
            suv.NumberOfSeats = 6;
            suv.NumberOfWindows = 0;
            suv.Name = "Subaru";
            suv.Country = "Japan";

            truck.Make = "Ford";
            truck.Model = "F150";
            truck.Year = 2020;
            truck.NumberOfWheels = 4;
            truck.TireSize = "Large";
            truck.IsThisATruck = true;
            truck.Name = "Ford";
            truck.Country = "USA";

            car.Make = "Honda";
            car.Model = "Civic";
            car.Year = 2000;
            car.NumberOfWheels = 4;
            car.IsThisACar = true;
            car.HasTrunk = true;
            car.Name = "Honda";
            car.Country = "Japan";


            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(suv);
            vehicles.Add(truck);

            Console.WriteLine("Please Select type of vehicle");
            String customerSelection = Console.ReadLine();
            if (customerSelection.ToLower() == "car")
            {
                car.CarDetails(car);
            }
            else if (customerSelection.ToLower() == "truck")
            {
                truck.CarDetails(truck);
            }
            else if (customerSelection.ToUpper() == "Suv")
            {
                suv.CarDetails(suv);
            }
           

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }

       
    }
}
