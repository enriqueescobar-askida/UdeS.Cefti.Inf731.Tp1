namespace ConsoleApp
{
    using System;
    using System.Linq;

    public class DonationRecord
    {
        private const string FloatFormat = "0.00";

        private string DonationString { get; set; }

        private string DonorNumber { get; set; }

        private uint DonationYear { get; set; }

        private float DonationAmount { get; set; }

        public DonationRecord(string line)
        {
            this.DonationString = line;

            if (line.Split(';').Count() == 3)
            {
                this.DonorNumber = line.Split(';')[0];
                this.DonationYear = (uint)int.Parse(line.Split(';')[1]);
                this.DonationAmount = float.Parse(line.Split(';')[2].Replace(",","."));
                this.DonationAmount = (float)Math.Round(this.DonationAmount, 2);
            }
            else
            {
                this.DonorNumber = "NA";
                this.DonationYear = 0;
                this.DonationAmount = -1.00f;
                this.DonationString = "NA;0000;-1,00";
            }
        }

        public override string ToString()
        {
            return this.DonationString; //this.DonationAmount.ToString(FloatFormat);
        }
    }
}
