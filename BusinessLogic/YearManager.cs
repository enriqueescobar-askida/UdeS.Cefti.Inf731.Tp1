namespace BusinessLogic
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using Data;

    internal class YearManager
    {
        private SortedList<uint, float> sortedList;
        public YearManager(List<DonationRecord> drList)
        {
            SortedList<uint, float> sList = new SortedList<uint, float>();

            foreach (DonationRecord donationRecord in drList)
            {
                if (!sList.ContainsKey(donationRecord.DonationYear))
                    sList.Add(donationRecord.DonationYear, donationRecord.DonationAmount);
                else
                    sList[donationRecord.DonationYear] = donationRecord.DonationAmount +
                        sList.ElementAtOrDefault(sList.IndexOfKey(donationRecord.DonationYear)).Value;
            }

            this.sortedList = sList;
        }

        public override string ToString()
        {
            string s = String.Empty;
            int nbElements = this.sortedList.Count;

            for (int i = 0; i < nbElements; i++)
            {
                KeyValuePair<uint, float> sortedKeyValuePair = this.sortedList.ElementAt(nbElements - i - 1);
                s += sortedKeyValuePair.Key.ToString(CultureInfo.CurrentCulture).PadRight(5) + sortedKeyValuePair.Value.ToString(CultureInfo.CurrentCulture).PadLeft(12) + "\n";
            }

            return s;
        }
    }
}
