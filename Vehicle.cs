using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    abstract class Vehicle
    {
        public List<Vehicle> _vehicleList = new List<Vehicle>();

        protected string _licencePlate;
        protected string _type;
        protected string _manufacturer;
        protected string _colour;

        public Vehicle(string licencePlate, string type, string manufacturer, string colour)
        {
            _licencePlate = licencePlate;
            _type = type;
            _manufacturer = manufacturer;
            _colour = colour;
        }

        public Vehicle() { }

        public abstract Vehicle CreateVehicle();

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicleList.Add(vehicle);
        }

        public abstract void DisplayDetails();
    }
}