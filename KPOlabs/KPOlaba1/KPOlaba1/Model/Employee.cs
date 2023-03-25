using System;
using System.Collections.Generic;

namespace KPOlaba1
{
    abstract class Employee
    {
        private string name;
        private double salary;
        private string rank;
        private double salaryRatio;
        protected static double startSalary = 500;
        public static Dictionary<String, double> rankDict = new Dictionary<string, double>{ { "junior", 0 }, { "middle", 0 }, { "senior", 0 } };

        public string Name
        {
            get => name;
            set => name = value;
        }
        public virtual double Salary
        {
            get => salary;
            set => salary = value;
        }

        public virtual double SalaryRatio
        {
            get => salaryRatio;
            set => salaryRatio = value;
        }

        public string Rank
        {
            get => rank; 
            set => rank = value;
        }

        public static double StartSalary
        {
            get => startSalary;
            set => startSalary = value;
        }

        public Employee(string name, string rank)
        {
            Name = name;
            Rank = rank;
        }
        
        public Employee() { }

        public abstract void PrintInfo(); // вывод информации о сотруднике




    }
}
