using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class SearchStaff
    {
        // Attributes
        public List<Staff> _staffList = new List<Staff>();

        // Constructors
        public SearchStaff()
        {
            _staffList = new List<Staff>();
        }

        // Methods
        public void AddStaffMember(Staff member)
        {
            _staffList.Add(member);
        }

        public Staff FindByStaffId(int idNumber)
        {
            foreach(Staff staff in _staffList)
            {
                Console.WriteLine("Checking {0}", staff.StaffId);
                if(staff.StaffId == idNumber)
                {
                    return staff;
                }
            }
            return null;
        }
        public Staff FindByStaffLastName(string lastName)
        {
            foreach (Staff staff in _staffList)
            {
                Console.WriteLine("Checking {0}", staff.LastName);
                if (staff.LastName == lastName)
                {
                    return staff;
                }
            }
            return null;
        }
        
        public void SearchIdOrLN() {
        string search;
        Console.WriteLine("Do you want to search by last name or ID number?");
            search = Console.ReadLine();
            if (search == "Last Name" || search == "last name" || search == "ln" || search == "name")
            {
                Console.WriteLine("Enter last name:");
                string lastNameSearch = Console.ReadLine();
                SSValidation(FindByStaffLastName(lastNameSearch));
            }
            else if (search == "Id Number" || search == "id number" || search == "id" || search == "id no")
            {
                Console.WriteLine("Enter id number:");
                int idSearch = int.Parse(Console.ReadLine());
                SSValidation(FindByStaffId(idSearch));
            }
        }
        public void SSValidation(Staff myStaff)
        {
            if (myStaff != null)
            {
                Console.WriteLine("Found {0}", myStaff.GetDetails());
            }
            else
            {
                Console.WriteLine("No staff member found");
            }
        }
    }
}