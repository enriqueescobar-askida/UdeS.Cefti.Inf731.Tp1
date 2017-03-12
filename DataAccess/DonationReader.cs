namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Data;

    public class DonationReader
    {
        private readonly string filePath;

        public DonationReader(string aFilePath)
        {
            if (new FileInfo(aFilePath).Exists) this.filePath = aFilePath;
            else throw new FileNotFoundException("File path cannot be found");
        }

        public List<DonationRecord> ReadFile()
        {
            List<DonationRecord> aList = new List<DonationRecord>();
            FileStream fileStream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream)) //, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    DonationRecord dr = new DonationRecord(line);
                    Console.Out.WriteLine(dr.ToString());
                    if (dr.IsValid) aList.Add(dr);
                }
            }

            return aList;
        }

        public override string ToString()
        {
            return this.filePath;
        }
    }
}
