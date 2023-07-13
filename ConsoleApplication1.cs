using System;
using System.Linq;

namespace ConsoleApplication1
{
    class ConsoleApplication1
    {
        public static void Main(string[] args)
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            // a. Show the common elements in both lists
            var commonElements = list1.Intersect(list2);
            Console.WriteLine("Common elements: " + string.Join(" ", commonElements));

            // b. Show the elements from list 1 that are not found in list 2
            var elementsOnlyInList1 = list1.Except(list2);
            Console.WriteLine("Elements only in list 1: " + string.Join(" ", elementsOnlyInList1));

            // c. Show the elements from list 2 that are not found in list 1
            var elementsOnlyInList2 = list2.Except(list1);
            Console.WriteLine("Elements only in list 2: " + string.Join(" ", elementsOnlyInList2));

        }
    }
}
