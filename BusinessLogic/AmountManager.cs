namespace BusinessLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Data;

    internal class AmountManager
    {
        private readonly SortedList<float, string> sortedList;

        private readonly SortedList<float, string> doubleList;
        public AmountManager(List<DonationRecord> drList)
        {
            SortedList<float, string> sList = new SortedList<float, string>();
            SortedList<float, string> dList = new SortedList<float, string>();

            foreach (DonationRecord donationRecord in drList)
            {
                string s = donationRecord.DonorNumber.PadRight(17) + donationRecord.DonationYear;

                if (!sList.ContainsKey(donationRecord.DonationAmount))
                    sList.Add(donationRecord.DonationAmount, s);
                else
                    dList.Add(donationRecord.DonationAmount, s);
            }

            this.sortedList = sList;
            this.doubleList = dList;
        }

        public override string ToString()
        {
            string s = String.Empty;
            int nbElements = this.sortedList.Count;

            for (int i = 0; i < nbElements; i++)
            {
                KeyValuePair<float, string> sortedKeyValuePair = this.sortedList.ElementAt(nbElements - i - 1);
                s += sortedKeyValuePair.Value + sortedKeyValuePair.Key.ToString("0.00").PadLeft(9) + "\n";

                if (this.doubleList.ContainsKey(sortedKeyValuePair.Key))
                {
                    int j = this.doubleList.IndexOfKey(sortedKeyValuePair.Key);
                    KeyValuePair<float, string> doublKeyValuePair = this.doubleList.ElementAt(j);
                    s += doublKeyValuePair.Value + doublKeyValuePair.Key.ToString("0.00").PadLeft(9) + "\n";
                }
            }

            return s;
        }
    }
}
