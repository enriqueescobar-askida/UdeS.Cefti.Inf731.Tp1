namespace ConsoleApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Data;
    using DataAccess;
    using BusinessLogic;

    class Program
    {
        static void Main(string[] args)
        {
            DonationReader dr = new DonationReader(@"..\..\..\d1.txt");
            List<DonationRecord> drList = dr.ReadFile();
            Console.Error.WriteLine(dr.ToString());

            DonationManager dm = new DonationManager(drList);
            Console.Out.WriteLine(dm.ToString());
            Console.In.ReadLine();

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList { "Hello", "World", "!", "!" };

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);
            Console.In.ReadLine();
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
