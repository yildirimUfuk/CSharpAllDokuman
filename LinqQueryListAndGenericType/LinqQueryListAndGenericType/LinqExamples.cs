using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
    }
}
