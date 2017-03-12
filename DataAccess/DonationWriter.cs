namespace DataAccess
{
    using System;
    using System.IO;

    using BusinessLogic;

    public class DonationWriter
    {
        private readonly string outputFile;
        public DonationWriter(string inputPath)
        {
            string file = Path.GetFileNameWithoutExtension(inputPath);
            this.outputFile = inputPath.Replace(file, "Rapports - " + file);
            Console.WriteLine(this.outputFile);
        }

        public void WriteFile(DonationManager donationManager)
        {
            using (StreamWriter writer = new StreamWriter(this.outputFile))
            {
                writer.Write(donationManager);
            }
        }
    }
}
