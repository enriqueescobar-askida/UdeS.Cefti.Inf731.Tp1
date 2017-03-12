namespace ConsoleApp
{
    using System;
    using System.Linq;

    public class DonationRecord
    {
        private const string FloatFormat = "0.00";
        public bool IsValid { get; internal set; }

        private string DonationString { get; }

        private string DonorNumber { get; }

        private uint DonationYear { get; }

        private float DonationAmount { get; }

        public DonationRecord(string line)
        {
            this.DonationString = line;
            this.IsValid = true;

            if (line.Split(';').Count() == 3)
            {
                this.DonorNumber = this.FetchDonorNumber(line.Split(';')[0]);
                this.DonationYear = this.FetchDonationYear(line.Split(';')[1]);
                this.DonationAmount = this.FetchDonationAmount(line.Split(';')[2]);
            }
            else throw new ArgumentOutOfRangeException("Arguments passed are not between parameters");
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
                isValid = (year >= 1996 && year <= DateTime.Now.Year);
            }

            this.IsValid = this.IsValid && isValid;

            return isValid;
        }
        #endregion

        #region PrivateMethodsDonationAmount
        private float FetchDonationAmount(string amountString)
        {
            float f = float.Parse(amountString.Replace(",", "."));
            f = (float)Math.Round(f, 2);

            if (this.IsAmountValid(f)) return f;
            else return float.NaN;
        }

        private bool IsAmountValid(float input)
        {
            bool isValid = (input > 0.00f);
            this.IsValid = this.IsValid && isValid;

            return isValid;
        }
        #endregion

        public override string ToString()
        {
            string s = this.DonorNumber.PadRight(15);
            s += this.DonationYear.ToString().PadRight(8);
            s += this.DonationAmount.ToString("0.00").PadLeft(5);

            return s;
        }
    }
}
