using System;
using System.Collections.Generic;

namespace KPOlaba1
{
    internal class SoftwareEngineer : Employee
    {

        public SoftwareEngineer(string name, string rank) : base(name, rank) 
        {
            rankDict = new Dictionary<String, double>() { { "junior", 2 }, { "middle", 2.5 }, { "senior", 4 } };
            SalaryRatio = rankDict[Rank];
            Salary = startSalary * SalaryRatio;
        }
        public SoftwareEngineer() : base() { }  

        public override void PrintInfo() // вывод информации о сотруднике
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Engineer info:");
            Console.WriteLine("Name: {0} Rank: {1} Salary {2}", Name, Rank, Salary);
            Console.WriteLine("--------------------\n");
        } 
    }
}
