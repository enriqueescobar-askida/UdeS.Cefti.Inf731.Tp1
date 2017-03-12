namespace Data
{
    using System;
    using System.Linq;

    public class DonationRecord
    {
        private const string FloatFormat = "0.00";
        public bool IsValid { get; internal set; }

        private string DonationString { get; }

        public string DonorNumber { get; }

        public uint DonationYear { get; internal set; }

        public float DonationAmount { get; internal set; }

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
            bool isValid = false;

            if (input.Contains("-"))
            {
                isValid = true;
                this.IsValid = this.IsValid && isValid;

                return isValid;
            }
            throw new ArgumentException("The parameter 'Number' does not contain '-':" + input);
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

                if (year >= 1996 && year <= DateTime.Now.Year)
                {
                    isValid = true;
                    this.IsValid = this.IsValid && isValid;

                    return isValid;
                }
                throw new ArgumentOutOfRangeException("The argument 'Year' is outside bounds [1996;" + DateTime.Now.Year + "]:" + yearString);
            }
            throw new ArgumentException("The argument 'Year' has not 4 digits:" + yearString);
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
            bool isValid = false;

            if (input > 0.00f)
            {
                isValid = true;
                this.IsValid = this.IsValid && isValid;

                return isValid;
            }
            throw new ArgumentOutOfRangeException("The parameter 'Amount' is out off limits:" + input);
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
