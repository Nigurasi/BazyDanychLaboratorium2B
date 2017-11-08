using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanych_TydzienB
{
    public class CustomersHistory
    {
        public int HistoryID { get; set; }
        public string CompanyName { get; set; }
        public int BoughtProductID { get; set; }

        public DateTime BoughtDate { get; set; }

    }
}
