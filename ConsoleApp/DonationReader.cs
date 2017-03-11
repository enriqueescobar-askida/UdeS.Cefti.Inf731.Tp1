namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DonationReader
    {
        private string filePath;

        private List<string> LineList { get; set; }

        private StringBuilder StringBuilder { get; set; }

        public bool SetFile(string aFilePath)
        {
            if (new FileInfo(aFilePath).Exists)
            {
                this.filePath = aFilePath;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReadFile()
        {
            FileStream fileStream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream)) //, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Console.Out.WriteLine(line);
                    DonationRecord dr = new DonationRecord(line);
                    Console.Out.WriteLine(dr.ToString());
                    //this.StringBuilder.Append(line);
                    //this.LineList.Add(line);
                }
            }
        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}
