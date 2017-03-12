namespace ConsoleApp
{
    using System;
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

            DonationWriter dw = new DonationWriter(dr.ToString());
            dw.WriteFile(dm);

            Console.In.ReadLine();
        }
    }
}
