using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Van : Vehicle
    {
        private double _heightInMetres;

        public Van(string licencePlate, string type, string manufacturer, string colour, double heightInMetres)
            :base(licencePlate, type, manufacturer, colour)
        {
            _heightInMetres = heightInMetres;
        }

        public Van()
        {

        }

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
            Console.WriteLine("Height in metres: ");
            _heightInMetres = double.Parse(Console.ReadLine());
            return new Van(_licencePlate, _type, _manufacturer, _colour, _heightInMetres);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\nType of Vehicle: Van" + "\nLicence Plate: " + _licencePlate + "\nType: "
                + _type + "\nManufacturer: " + _manufacturer + "\nColour: " + _colour + "\nHeight in metres:" + _heightInMetres + "\n");
        }
    }
}