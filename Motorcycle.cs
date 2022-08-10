using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string licencePlate, string type, string manufacturer, string colour)
            :base(licencePlate, type, manufacturer, colour)
        {

        }

        public Motorcycle() { }

        public override Vehicle CreateVehicle()
        {
            Console.WriteLine("The licence plate: ");
            _licencePlate = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Type: ");
            _type = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Manufacturer: ");
            _manufacturer = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Colour: ");
            _colour = Validation.CheckString(Console.ReadLine());
            return new Motorcycle(_licencePlate, _type, _manufacturer, _colour);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\nType of Vehicle: Motorcycle" + "\nLicence Plate: " + _licencePlate + "\nType: "
                + _type + "\nManufacturer: " + _manufacturer + "\nColour: " + _colour + "\n");
        }
    }
}