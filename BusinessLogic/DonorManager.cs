namespace BusinessLogic
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using Data;

    class DonorManager
    {
        private readonly SortedList<float, string> finalList;

        public DonorManager(List<DonationRecord> drList)
        {
            SortedList<string, float> sList = new SortedList<string, float>();

            foreach (DonationRecord donationRecord in drList)
            {
                if (!sList.ContainsKey(donationRecord.DonorNumber))
                    sList.Add(donationRecord.DonorNumber, donationRecord.DonationAmount);
                else
                    sList[donationRecord.DonorNumber] = donationRecord.DonationAmount +
                        sList.ElementAtOrDefault(sList.IndexOfKey(donationRecord.DonorNumber)).Value;
            }

            SortedList <float, string> fList = new SortedList<float, string>(sList.Count);

            foreach (KeyValuePair<string, float> keyValuePair in sList)
            {
                if (!fList.ContainsKey(keyValuePair.Value))
                    fList.Add(keyValuePair.Value, keyValuePair.Key);
            }

            this.finalList = fList;
        }

        public override string ToString()
        {
            string s = String.Empty;
            int nbElements = this.finalList.Count;

            for (int i = 0; i < nbElements; i++)
            {
                KeyValuePair<float, string> sortedKeyValuePair = this.finalList.ElementAt(nbElements - i - 1);
                s += sortedKeyValuePair.Value.PadRight(15) + sortedKeyValuePair.Key.ToString("00.00").PadLeft(6) + "\n";
            }

            return s;
        }
    }
}
