namespace ConsoleApp
{
    using System;
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
        }
    }
}
