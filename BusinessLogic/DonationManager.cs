namespace BusinessLogic
{
    using System.Collections.Generic;

    using Data;

    public class DonationManager
    {
        private List<DonationRecord> drList;

        public DonationManager(List<DonationRecord> drList)
        {
            this.drList = drList;
        }
    }
}
