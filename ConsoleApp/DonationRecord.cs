namespace ConsoleApp
{
    using System.Linq;

    public class DonationRecord
    {
        private string DonorNumber { get; set; }
        private uint DonationYear { get; set; }
        private float DonationAmount { get; set; }

        public DonationRecord(string line)
        {
            if (line.Split(';').Count() == 3)
            {
                this.DonorNumber = line.Split(';')[0];
                this.DonationYear = (uint)int.Parse(line.Split(';')[1]);
                this.DonationAmount = float.Parse(line.Split(';')[2].Replace(",","."));
            }
        }

        public override string ToString()
        {
            return this.DonationAmount.ToString();
        }
    }
}
