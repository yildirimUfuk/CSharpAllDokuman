using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace LinqQueryListAndGenericType
{
    public class LinqExamples
    {
        static int[] values = { 1, 2, 7, 3, 5, 1, 9, 5, 7 };
        /// <summary>
        /// select items with "where"
        /// </summary>
        public static void originalArr()
        {
            //var values = new[] { 1, 2, 7, 3, 5, 1, 9, 5, 7 };
            Console.Write("original arrays: \t");
            foreach (var item in values)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public static void linqWhere()
        {
            //originalArr();
            var filteredItems = from item in values where item > 4 select item; //select the items which grather than 4 and return an array to filteredItems. So filterekItems is an array.
            Console.Write("filtered array for 4 is: \t");
            foreach (var item in filteredItems)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        } 
        public static void linqOrderby()
        {
            //originalArr();
            //var orderedArr = from item in values orderby item select item; //smalest than biggest
            var orderedArr = from item in values orderby item descending select item; //biggest then smallest
            Console.Write("ordered arr is: \t");
            foreach (var item in orderedArr)
                Console.Write($"{item}");
            Console.WriteLine();
        }
        public static void linqWhereCustomClass()
        {
            var emp = new[] {
                new Employee("a", "aa", 2500),
                new Employee("b","bb",1500),
                new Employee("c","cc",5500),
                new Employee("d","dd",2000),
                new Employee("e","ee",7501),
                new Employee("f","ff",5900),
            };
            Console.WriteLine("all amployees are: ");
            foreach (var item in emp)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            var filteredEmployee = from item in emp
                                   where (item.MontlySalary >= 3000) && (item.MontlySalary <= 6000)
                                   //where item.MontlySalary%10==1//its possible.
                                   select item;
            //select item.MontlySalary;//just salary
            Console.WriteLine("all employees who has salary between 3000 and 6000 per month");
            foreach (var item in filteredEmployee)
                Console.WriteLine(item.ToString());//to string method has been overrided
        }
        public static void linqOrderbyCustomClass()
        {
            var emp = new[] {
                new Employee("a","aa", 2500),
                new Employee("b","bb",1500),
                new Employee("c","cc",5500),
                new Employee("a","dd",2000),
                new Employee("e","ee",7500),
                new Employee("a","ff",5900),
            };
            var orderedEmployee = from item in emp
                                  orderby item.firstName, item.lastName
                                  select item;
            //select new { item.firstName, item.lastName };//a new object which has 2 attiribute "name" and "surname". List has this objects.
            Console.WriteLine("ordered employee list is: ");
            foreach (var item in orderedEmployee)
            {
                Console.WriteLine(item.ToString());
            }

        }
        public static void linqGetJustLastElement()
        {
            var emp = new[] {
                new Employee("a","aa", 2500),
                new Employee("b","bb",1500),
                new Employee("c","cc",5500),
                new Employee("a","zz",9999),
                new Employee("e","ee",7500),
                new Employee("a","ff",5900),
            };
            Console.WriteLine("all emplotee are: ");
            foreach (var item in emp)
                Console.WriteLine(item.ToString());
            var filteredElements = from item in emp
                                  where item.firstName == "a"
                                  orderby item.lastName
                                  select item;
            Console.Write("the last element which is begining 'a' and sorted with lastname is: ");
            if (filteredElements.Any()) //if at least there is an element
                Console.WriteLine(filteredElements.Last());
            else
                Console.WriteLine("there is no element!");

        }
    }
}
