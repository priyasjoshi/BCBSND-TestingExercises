using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExercises_Sorting
{
    class Program
    { 
        // Mehod To print a list of First Name and Last Name
        public static void PrintList(List<ListElements> ele) {
            for (int i = 0; i < ele.Count; i++)
                Console.WriteLine(ele[i].FirstName + "   " + ele[i].LastName);
        }
        static void Main(string[] args)
        {
            var nameList = new List<ListElements>();
            // Some Sample List elements added
            nameList.Add(new ListElements("James", "Smith"));
            nameList.Add(new ListElements("John", "Williams"));
            nameList.Add(new ListElements("David", "Thomas"));
            nameList.Add(new ListElements("Edward", "Clark"));
            Console.WriteLine("Original List\n");
            Console.WriteLine("FirstName LastName");
            // Print function call to print the original List
            PrintList(nameList);
            // Instance of the Class SortByFirstName 
            SortMethods f = new SortByFirstName();
            // Instance of the Class SortByLasttName 
            SortMethods l = new SortByLastName();
            // BubbleSort class Instance
            BubbleSort S= new BubbleSort();
            Console.WriteLine("\nAfter First names sorted\n");
            Console.WriteLine("FirstName LastName");
            S.Sort(nameList, f);
            // Print function call to print the sorted First names List
            PrintList(nameList);
            Console.WriteLine("\nAfter Last names sorted\n");
            Console.WriteLine("FirstName LastName");
            S.Sort(nameList, l);
            // Print function call to print the sorted Last names List
            PrintList(nameList);
            Console.ReadKey();
        }
    }
}

