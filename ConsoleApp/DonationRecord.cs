namespace ConsoleApp
{
    using System;
    using System.Linq;

    public class DonationRecord
    {
        private const string FloatFormat = "0.00";
        public bool IsValid { get; internal set; }

        private string DonationString { get; set; }

        private string DonorNumber { get; set; }

        private uint DonationYear { get; set; }

        private float DonationAmount { get; set; }

        public DonationRecord(string line)
        {
            this.DonationString = line;
            this.IsValid = true;

            if (line.Split(';').Count() == 3)
            {
                this.DonorNumber = this.FetchDonorNumber(line.Split(';')[0]);
                this.DonationYear = this.FetchDonationYear(line.Split(';')[1]);
                this.DonationAmount = float.Parse(line.Split(';')[2].Replace(",","."));
                this.DonationAmount = (float)Math.Round(this.DonationAmount, 2);
            }
        }

        private float FetchDonationAmount(string amountString)
        {
            float f = float.Parse(amountString.Split(';')[2].Replace(",", "."));
            f = (float)Math.Round(f, 2);

            return f;
        }

        #region PrivateMethodsDonorNumber
        private string FetchDonorNumber(string numberString)
        {
            string s = String.Empty;

            if (this.IsNumberValid(numberString)) s = numberString;

            return s;
        }

        private bool IsNumberValid(string input)
        {
            bool isValid = input.Contains("-");
            this.IsValid = this.IsValid && isValid;

            return isValid;
        }
        #endregion

        #region PrivateMethodsDonationYear
        private uint FetchDonationYear(string yearString)
        {
            uint u = 0;

            if (this.IsYearValid(yearString)) u = (uint)int.Parse(yearString);

            return u;
        }

        private bool IsYearValid(string yearString)
        {
            bool isValid = false;

            if (yearString.Length == 4)
            {
                uint year = (uint)int.Parse(yearString);
                isValid = (year >= 1996 && year <= 2017);
            }

            this.IsValid = this.IsValid && isValid;

            return isValid;
        }
        #endregion

        public override string ToString()
        {
            return this.DonationAmount.ToString("0.00");
        }
    }
}
