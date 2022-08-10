using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Staff
    {
        // Attributes
        private int _idNumber;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _sex;
        private string _address;
        private bool _profilePictureTaken;
        private bool _staffDetailsPrinted;
        private string _dateCardIssued;

        // Constructors
        public Staff(int idNumber, string firstName, string lastName, int age, string sex, string address, bool profilePictureTaken, bool staffDetailsPrinted, string dateCardIssued)
        {
            _idNumber = idNumber;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _sex = sex;
            _address = address;
            _profilePictureTaken = profilePictureTaken;
            _staffDetailsPrinted = staffDetailsPrinted;
            _dateCardIssued = dateCardIssued;
        }

        public Staff()
        {

        }

        // Properties
        public int StaffId
        {
            get { return _idNumber; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        // Methods
        public Staff CreateEmployee()
        {
            Console.WriteLine("Insert id number of the staff:");
            _idNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert first name of the staff:");
            _firstName = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Insert last name of the staff:");
            _lastName = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Insert age of the staff:");
            _age = Validation.CheckStaffAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert sex of the staff:");
            _sex = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Insert address of the staff:");
            _address = Validation.CheckString(Console.ReadLine());
            Console.WriteLine("Has the photo been taken? Type 'true' or 'false':");
            _profilePictureTaken = Convert.ToBoolean(Console.ReadLine());
            TakePhoto();
            Console.WriteLine("Have the card printers been provided with the required employee details? Type 'true' or 'false':");
            _staffDetailsPrinted = Convert.ToBoolean(Console.ReadLine());
            DetailsProvided();
            Console.WriteLine("Please enter date card was issued:");
            _dateCardIssued = Validation.CheckString(Console.ReadLine());
            CardIssued();
            return new Staff(_idNumber, _firstName, _lastName, _age, _sex, _address, _profilePictureTaken,
            _staffDetailsPrinted, _dateCardIssued);
        }
        public string GetDetails()
        {
            return "Staff Id: " + _idNumber + "\nFirst Name: " + _firstName + "\nLast Name: " + _lastName +
                "\nAge: " + _age + "\nSex: " + _sex + "\nAddress: " + _address;
        }
        public void TakePhoto()
        {
            string pictureTaken;
            bool range = false;
            if (_profilePictureTaken == true)
            {
                Console.WriteLine("Photo has been taken.");
            }
            else if (_profilePictureTaken == false)
            {
                Console.WriteLine("Photo has not been taken.");
                Console.WriteLine("Take picture now?");
                pictureTaken = Console.ReadLine();
                while(range == false)
                {
                if (pictureTaken == "Yes" || pictureTaken == "yes" || pictureTaken == "y")
                {
                    range = true;
                    _profilePictureTaken = true;
                    Console.WriteLine("Photo has now been taken. Status: " + _profilePictureTaken);
                    
                }
                else
                    {
                        Console.WriteLine("Please take photo. Take picture now?");
                        pictureTaken = Console.ReadLine();
                    }
                }
            }
        }
        public void DetailsProvided()
        {
            bool range = false;
            if ((_profilePictureTaken == true) && (_staffDetailsPrinted == false))
            {
                Console.WriteLine("Staff details have not been printed.");
                Console.WriteLine("Send staff details to printer now?");
                string sendDetails = Console.ReadLine();
                while (range == false) {
                    if (sendDetails == "Yes" || sendDetails == "yes" || sendDetails == "y")
                    {
                        range = true;
                        _staffDetailsPrinted = true;
                        Console.WriteLine("Staff details have now been taken. Status: " + _staffDetailsPrinted);
                    }
                    else
                    {
                        Console.WriteLine("Please send staff details. Send staff details now?");
                        sendDetails = Console.ReadLine();
                    }
                }
            }
            else if ((_profilePictureTaken = true) && (_staffDetailsPrinted == true))
            {
                Console.WriteLine("Staff details have already been printed.");
            }
            else
            {
                Console.WriteLine("Picture hasn't been taken and staff details have not been printed.");
            }
        }
        public void CardIssued()
        {
            if ((_profilePictureTaken = true) && (_staffDetailsPrinted = true))
            {
                Console.WriteLine("The card has now been issued.");
            }
            else
            {
                Console.WriteLine("Can't issue card unless profile photo is taken and staff details are printed.");
            }
        }
    }
}