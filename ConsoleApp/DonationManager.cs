using System.Collections.Generic;

namespace ConsoleApp
{
    class DonationManager
    {
        private List<DonationRecord> drList;

        public DonationManager(List<DonationRecord> drList)
        {
            this.drList = drList;
        }
    }
}
