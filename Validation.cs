using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    static class Validation
    {
        public static string CheckString(string input)
        {
            while (true)
            {
                if (input == "")
                {
                    Console.WriteLine("Wrong input. Try again.");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return input;
        }

        public static int CheckInt(int input)
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out input))
                {

                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                    CheckInt(input);
                }
            return input;
            }
        }

    public static int CheckStaffAge(int input)
        {
            bool range = false;
            while(range == false)
            {
                if (input < 18 || input > 70)
                {
                    Console.WriteLine("Please enter an age between 18 to 70");
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    range = true;
                }
            }
            return input;
        }

        public static int CheckRangeDoors(int input)
        {
            bool range = false;
            while (range == false)
            {
                if (input == 3 || input == 5 || input == 7)
                {
                    range = true;
                }
                else
                {
                    Console.WriteLine("Please enter amount of doors as either 3, 5 or 7");
                    input = int.Parse(Console.ReadLine());
                }
            }
            return input;
        }
    }
}