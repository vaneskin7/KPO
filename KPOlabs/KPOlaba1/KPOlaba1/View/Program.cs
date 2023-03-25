using System;
using System.Collections.Generic;
using System.Web.UI;

/*
 * Console application "IT Company"
 * CEO - Kachan Ivan, CTO - Dlussky Kirill. Group 10701121
 * 23.03.2023
 * version 1.0
 */

namespace KPOlaba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            while (isExit == false)
            {
                Console.WriteLine("Select an action:");
                Console.WriteLine("1. Add new Employee\n2. Delete employee\n3. Raise employee salary\n4. Print list of employees\n5. Find employee with MAX and MIN salary" +
                    "\n6. Change start salary\n7. Exit");
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        ListOfEmployeers.AddEmployee();
                        break;
                    case 2:
                        ListOfEmployeers.DeleteEmployee();
                        break;
                    case 3:
                        ListOfEmployeers.RaiseSalary();
                        break;
                    case 4:
                        ListOfEmployeers.PrintEmployeersInfo();
                        break;
                    case 5:
                        ListOfEmployeers.PrintMinMax();
                        break;
                    case 6:
                        ListOfEmployeers.ChangeStartSalary();
                        break;
                    case 7:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input! Try again\n");
                        break;
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
