namespace ConsoleApp
{
    using System.IO;

    public class DonationReader
    {
        private string filePath;

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

        public override string ToString()
        {
            return this.filePath;
        }
    }
}
