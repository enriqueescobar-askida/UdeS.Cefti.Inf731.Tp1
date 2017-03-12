namespace BusinessLogic
{
    using System.Collections.Generic;

    using Data;

    public class DonationManager
    {
        private readonly YearManager yearManager;

        private readonly AmountManager amountManager;

        private readonly DonorManager donorManager;

        public DonationManager(List<DonationRecord> drList)
        {
            this.yearManager = new YearManager(drList);
            this.amountManager = new AmountManager(drList);
            this.donorManager = new DonorManager(drList);
        }

        public override string ToString()
        {
            string s = this.amountManager + "\n";
            s += this.donorManager + "\n";
            s += this.yearManager + "\n";

            return s;
        }
    }
}
