namespace ConsoleApp
{
    using System.Collections.Generic;

    using Data;

    class DonationManager
    {
        private List<DonationRecord> drList;

        public DonationManager(List<DonationRecord> drList)
        {
            this.drList = drList;
        }
    }
}
