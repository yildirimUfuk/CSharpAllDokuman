using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LinqQueryListAndGenericType
{
    class Employee
    {
        public string firstName { get; }
        public string lastName { get; }
        private decimal monthlySalary;
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.monthlySalary = monthlySalary;
        }
        public decimal MontlySalary
        {
            get { return monthlySalary; }
            set { if (MontlySalary >= 0M) monthlySalary = MontlySalary; }
        }
        //public override string ToString()
        //{
        //    return $"{firstName,-10}{lastName,-10}{monthlySalary,10:C}";
        //}
        public override string ToString() => $"{firstName,-10}{lastName,-10}{monthlySalary,10:C}";
    }
    
}
