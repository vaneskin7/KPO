using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Xml.Linq;

namespace KPOlaba1
{
    abstract class ListOfEmployeers
    {

        public static List<Employee> empoyees = new List<Employee>();

        public static void AddEmployee() // добавить сотрудника
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Rank(junior, middle, senior): ");
            string rank = Console.ReadLine();
            
            if (Employee.rankDict.ContainsKey(rank) == false)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.Write("Speciality(QA, Engineer): ");
            string speciality = Console.ReadLine();

            switch (speciality)
            {
                case "Engineer":
                    empoyees.Add(new SoftwareEngineer(name, rank));
                    break;
                case "QA":
                    empoyees.Add(new QAengineer(name, rank));
                    break;
                default:
                    Console.WriteLine("Invalid input\n");
                    break;
            }
        }

        public static void DeleteEmployee() // удалить сотрудника
        {
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();
            if (empoyees.Count != 0)
            {
                foreach (Employee empoyee in empoyees)
                {
                    if (empoyee.Name == name)
                    {
                        empoyees.RemoveAll(x => x.Name == name);
                        Console.WriteLine("Success\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("There is no employee with this name\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("List of emloyeers is empty\n");
            }
        }

        public static Pair FindMaxMinSalary() // поиск максимальной и минимальной зарплаты
        {
            List<int> min = new List<int>();
            List<int> max = new List<int>();
            Pair pair = new Pair();
            int indexMin = 0, indexMax = 0;
            for (int i = 0; i < empoyees.Count; i++)
            {
                if (empoyees[indexMax].Salary < empoyees[i].Salary)
                {
                    max.Clear();
                    indexMax = i;
                    max.Add(indexMax);
                    continue;
                }
                else
                {
                    if (empoyees[indexMax].Salary == empoyees[i].Salary)
                    {
                        max.Add(i);
                        continue;
                    }
                } 
            }
            for (int i = 0; i < empoyees.Count; i++)
            {
                if (empoyees[indexMin].Salary > empoyees[i].Salary)
                {
                    min.Clear();
                    indexMin = i;
                    min.Add(indexMin);
                    continue;
                }
                else
                {
                    if (empoyees[indexMin].Salary == empoyees[i].Salary)
                    {
                        min.Add(i);
                        continue;
                    }
                }
            }
            pair.First = min; 
            pair.Second = max;
            return pair;
        }

        public static void PrintMinMax() // вывести людей с максимальной и минимальной зарплатой
        {
            Console.WriteLine("Info about employeers with max and min salary:");
            Pair pair = FindMaxMinSalary();
            List<int> min = (List<int>)pair.First;
            List<int> max = (List<int>)pair.Second;
            Console.WriteLine("Minimum salary: ");
            foreach (int indexMin in min)
            {
                empoyees[indexMin].PrintInfo();
            }
            Console.WriteLine("---------");
            Console.WriteLine("Maximum salary: ");
            foreach (int indexMax in max)
            {
                empoyees[indexMax].PrintInfo();
            }
            Console.WriteLine("---------");
        }

        public static void RaiseSalary() // увеличить/уменьшить зарплату
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter amount of money: ");
            double.TryParse(Console.ReadLine(), out double amount);
            foreach (Employee empoyee in empoyees)
            {
                if (empoyee.Name == name)
                {
                    empoyee.Salary += amount;
                }
            }
        }

        public static void PrintEmployeersInfo() // вывести всех сотрудников
        {
            Console.WriteLine("List of employeers:\n");
            double employeeMonthSalary = 0;
            foreach (Employee empoyee in empoyees)
            {
                employeeMonthSalary += empoyee.Salary;
                empoyee.PrintInfo();
            }
            Console.WriteLine("\n\nEmployees salary for a month: {0}", employeeMonthSalary);
        }

        public static void ChangeStartSalary() // изменить стартовую зарплату
        {
            bool isCorrect = true;
            Console.WriteLine("Enter new start salary: ");
            isCorrect = double.TryParse(Console.ReadLine(), out double newStartSalary);
            if (isCorrect == true)
            {
                foreach (Employee employee in empoyees)
                {
                    employee.Salary = employee.Salary * (newStartSalary / Employee.StartSalary);
                }
                Employee.StartSalary = newStartSalary;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
            
        }

    }
}
