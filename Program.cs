using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Staff employee = new Staff();
            SearchStaff searchStaff = new SearchStaff();

            int endProgram = 1;
            do
            {
                Console.WriteLine("Do you want to: \n" +
                    "1. Enter more staff details \n" +
                    "2. Search for an employee \n" +
                    "3. Add a vehicle \n" +
                    "4. Display vehicle details \n" +
                    "5. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Staff staff = employee.CreateEmployee();
                        searchStaff.AddStaffMember(staff);
                        break;
                    case 2:
                        searchStaff.SearchIdOrLN();
                        break;
                    case 3:
                        Console.WriteLine("Which vehicle do you want to add?\n" +
                        "1. Car\n" +
                        "2. Van\n" +
                        "3. Motorcycle");
                        string vehicleChoice = Console.ReadLine();
                        if(vehicleChoice == "Car" || vehicleChoice == "car" || vehicleChoice == "1")
                        {
                            Car newCar = new Car();
                            newCar.CreateVehicle();
                            vehicles.Add(newCar);
                        }
                        if(vehicleChoice == "Van" || vehicleChoice == "van" || vehicleChoice == "2")
                        {
                            Van newVan = new Van();
                            newVan.CreateVehicle();
                            vehicles.Add(newVan);
                        }
                        if(vehicleChoice == "Motorcycle" || vehicleChoice == "motorcycle" || vehicleChoice == "3")
                        {
                            Motorcycle newMotorcycle = new Motorcycle();
                            newMotorcycle.CreateVehicle();
                            vehicles.Add(newMotorcycle);
                        }
                        break;
                    case 4:
                        foreach (var vehicle in vehicles)
                        {
                            vehicle.DisplayDetails();
                        }
                        break;
                    case 5:
                        endProgram = 0;
                        break;
                    default:
                        break;
                }
            } while (endProgram == 1);
        }
    }
}