namespace ConsoleApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            DonationReader dr = new DonationReader();
            Console.Out.WriteLine(dr.SetFile(@"..\..\..\d1.txt"));
            Console.Out.WriteLine(dr.ToString());
            dr.ReadFile();
            Console.In.ReadLine();

            // Creates and initializes a new SortedList.
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            // Displays the properties and values of the SortedList.
            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");
            PrintKeysAndValues(mySL);
            Console.In.ReadLine();
        }
        public static void PrintKeysAndValues(SortedList myList)
        {
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
            }
            Console.WriteLine();
        }
    }
}
