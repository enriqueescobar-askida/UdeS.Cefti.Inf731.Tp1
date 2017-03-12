namespace BusinessLogic
{
    using System.Collections.Generic;

    using Data;

    public class DonationManager
    {
        private readonly YearManager yearManager;

        private readonly AmountManager amountManager;

        public DonationManager(List<DonationRecord> drList)
        {
            this.yearManager = new YearManager(drList);
            this.amountManager = new AmountManager(drList);
        }

        public override string ToString()
        {
            return this.amountManager.ToString();
        }
    }
}
