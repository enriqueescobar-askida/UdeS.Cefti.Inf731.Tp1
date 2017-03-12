namespace BusinessLogic
{
    using System.Collections.Generic;

    using Data;

    public class DonationManager
    {
        private readonly YearManager yearManager;

        public DonationManager(List<DonationRecord> drList)
        {
            this.yearManager = new YearManager(drList);
        }

        public override string ToString()
        {
            return this.yearManager.ToString();
        }
    }
}
