using System;
using System.Collections.Generic;


namespace KPOlaba1
{
    internal class QAengineer : Employee
    {
        public QAengineer(string name, string rank) : base(name,rank) 
        {
            rankDict = new Dictionary<String, double>() { { "junior", 1 }, { "middle", 1.5 }, { "senior", 2 } };
            SalaryRatio = rankDict[Rank];
            Salary = startSalary * SalaryRatio;
        }
        public QAengineer() : base() { }

        public override void PrintInfo() // вывод информации о сотруднике
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("QA Engineer info:");
            Console.WriteLine("Name: {0} Rank: {1} Salary {2}", Name, Rank, Salary);
            Console.WriteLine("--------------------\n");
        }
    }
}
