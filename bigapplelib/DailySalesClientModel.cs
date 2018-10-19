using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigapplelib
{
    public class DailySalesClientModel
    {
        public string MEQty1 { get; set; }
        public string MEAmount1 { get; set; }
        public string MEQty2 { get; set; }
        public string MEAmount2 { get; set; }
        public string MEQty3 { get; set; }
        public string MEAmount3 { get; set; }
        public string UNMWQty1 { get; set; }
        public string UNMWAmount1 { get; set; }
        public string UNMWQty2 { get; set; }
        public string UNMWAmount2 { get; set; }
        public string NYFPQty1 { get; set; }
        public string NYFPAmount1 { get; set; }
        public string NYFPQty2 { get; set; }
        public string NYFPAmount2 { get; set; }
        public string NYFPQty3 { get; set; }
        public string NYFPAmount3 { get; set; }
        public string NYFPQty4 { get; set; }
        public string NYFPAmount4 { get; set; }
        public string DRTNQty1 { get; set; }
        public string DRTNAmount1 { get; set; }
        public string DRTNQty2 { get; set; }
        public string DRTNAmount2 { get; set; }
        public string DRTNQty3 { get; set; }
        public string DRTNAmount3 { get; set; }
        public string DRTNQty4 { get; set; }
        public string DRTNAmount4 { get; set; }
        public string MDQty1 { get; set; }
        public string MDAmount1 { get; set; }
        public string MDQty2 { get; set; }
        public string MDAmount2 { get; set; }
        public string MDQty3 { get; set; }
        public string MDAmount3 { get; set; }
        public string MDQty4 { get; set; }
        public string MDAmount4 { get; set; }
        public string MDQty5 { get; set; }
        public string MDAmount5 { get; set; }
        public string MDQty6 { get; set; }
        public string MDAmount6 { get; set; }
        public string PRQty1 { get; set; }
        public string PRAmount1 { get; set; }
        public string PRQty2 { get; set; }
        public string PRAmount2 { get; set; }
        public string PRQty3 { get; set; }
        public string PRAmount3 { get; set; }
        public string ATQty1 { get; set; }
        public string ATAmount1 { get; set; }
        public string ATQty2 { get; set; }
        public string ATAmount2 { get; set; }

        public string DailySalesClientRecord
        {
            get
            {
                return $"{ MEQty1 } { MEAmount1 } { MEQty2 } { MEAmount2 } { MEQty3 } { MEAmount3 } " +
                    $"{ UNMWQty1 } { UNMWAmount1 } { UNMWQty2 } { UNMWAmount2 } " +
                    $"{ NYFPQty1 } { NYFPAmount1 } { NYFPQty2 } { NYFPAmount2 } { NYFPQty3 } { NYFPAmount3 } { NYFPQty4 } { NYFPAmount4 } " +
                    $"{ DRTNQty1 } { DRTNAmount1 } { DRTNQty2 } { DRTNAmount2 } { DRTNQty3 } { DRTNAmount3 } { DRTNQty4 } { DRTNAmount4 } " +
                    $"{ MDQty1 } { MDAmount1 } { MDQty2 } { MDAmount2 } { MDQty3 } { MDAmount3 } { MDQty4 } { MDAmount4 } { MDQty5 } { MDAmount5 } { MDQty6 } { MDAmount6 }" +
                    $"{ PRQty1 } { PRAmount1 } { PRQty2 } { PRAmount2 } { PRQty3 } { PRAmount3 } " +
                    $"{ ATQty1 } { ATAmount1 } { ATQty2 } { ATAmount2 } ";
            }
        }
    }
}
