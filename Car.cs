using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Car : Vehicle
    {
        private int _noOfDoors;
        
        public Car(string licencePlate, string type, string manufacturer, int noOfDoors, string colour)
            :base(licencePlate, type, manufacturer, colour)
        {
            _noOfDoors = noOfDoors;
        }

        public Car() { }

        public override Vehicle CreateVehicle()
        {
            Console.WriteLine("The licence plate: ");
            _licencePlate = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Type: ");
            _type = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Manufacturer");
            _manufacturer = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Number of doors:");
            _noOfDoors = Validation.CheckRangeDoors(int.Parse(Console.ReadLine()));
            Console.WriteLine("Colour:");
            _colour = Validation.CheckString(Console.ReadLine());
            return new Car(_licencePlate, _type, _manufacturer, _noOfDoors, _colour);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\nType of Vehicle: Car" + "\nLicence Plate: " + _licencePlate + "\nType: "
                + _type + "\nManufacturer: " + _manufacturer + "\nColour: " + _colour + "\nNo of doors: " + _noOfDoors + "\nColour: "
                + _colour + "\n");
        }
    }
}