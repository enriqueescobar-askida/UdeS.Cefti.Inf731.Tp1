namespace ConsoleApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Data;
    using DataAccess;

    class Program
    {
        static void Main(string[] args)
        {
            DonationReader dr = new DonationReader(@"..\..\..\d1.txt");
            List<DonationRecord> drList = dr.ReadFile();
            Console.Out.WriteLine(dr.ToString());

            //DonationManager dm = new DonationManager(drList);

            SortedList<uint, float> sortedList = new SortedList<uint,float>();
            foreach (DonationRecord donationRecord in drList)
            {
                Console.Out.WriteLine("-" + donationRecord.DonationYear + "_" + donationRecord.DonationAmount);

                if (!sortedList.ContainsKey(donationRecord.DonationYear))
                {
                    Console.Out.WriteLine("--yes");
                    sortedList.Add(donationRecord.DonationYear, donationRecord.DonationAmount);
                }
                else
                {
                    int i = sortedList.IndexOfKey(donationRecord.DonationYear);
                    float oldAmount = sortedList.ElementAtOrDefault(i).Value;
                    sortedList[donationRecord.DonationYear] = donationRecord.DonationAmount + oldAmount;
                    Console.Out.WriteLine("--nope:" + i);
                }
            }

            foreach (var f in sortedList)
            {
                Console.Out.WriteLine(f.Key + " " + f.Value);
            }
            Console.In.ReadLine();

            // Creates and initializes a new SortedList.
            SortedList mySL = new SortedList { { "Third", "!" }, { "Second", "World" }, { "First", "Hello" } };

            // Displays the properties and values of the SortedList.
            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");
            PrintKeysAndValues(mySL);
            Console.In.ReadLine();

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList { "Hello", "World", "!" };

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);
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
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
