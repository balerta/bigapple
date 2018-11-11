using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigapplelib
{
    public class TotalSalesClientModel
    {
        public string Total { get; set; }

        public string TotalAmountDue { get; set; }

        public string TotalSalesClientRecord
        {
            get
            {
                return $"{ Total } { TotalAmountDue }";
            }
        }
    }
}
