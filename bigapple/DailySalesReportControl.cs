using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using bigapplelib;

namespace bigapple
{
    public partial class DailySalesReportControl : UserControl
    {
        List<DailySalesClientModel> dailySales = new List<DailySalesClientModel>();
        List<TotalSalesClientModel> totalSales = new List<TotalSalesClientModel>();
        List<ClientRecordModel> loadClientRecord = new List<ClientRecordModel>();
        public DailySalesReportControl()
        {
            InitializeComponent();
        }

        // // // // // 
        // Quantity
        // // // // //
        private string MEQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty1);
            }
            return total.ToString();
        }
  
        private string MEQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty2);
            }
            return total.ToString();
        }
        private string MEQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty3);
            }
            return total.ToString();
        }
        private string UNMWQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWQty1);
            }
            return total.ToString();
        }
        private string UNMWQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWQty2);
            }
            return total.ToString();
        }
        private string NYFPQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty1);
            }
            return total.ToString();
        }
        private string NYFPQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty2);
            }
            return total.ToString();
        }
        private string NYFPQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty3);
            }
            return total.ToString();
        }
        private string NYFPQty4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty4);
            }
            return total.ToString();
        }
        private string JAIQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.JAIQty1);
            }
            return total.ToString();
        }
        private string JAIQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.JAIQty2);
            }
            return total.ToString();
        }

        private string DRTNQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty1);
            }
            return total.ToString();
        }
        private string DRTNQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty2);
            }
            return total.ToString();
        }
        private string DRTNQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty3);
            }
            return total.ToString();
        }
        private string DRTNQty4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty4);
            }
            return total.ToString();
        }
        private string MDQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty1);
            }
            return total.ToString();
        }
        private string MDQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty2);
            }
            return total.ToString();
        }
        private string MDQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty3);
            }
            return total.ToString();
        }
        private string MDQty4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty4);
            }
            return total.ToString();
        }
        private string MDQty5()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty5);
            }
            return total.ToString();
        }
        private string MDQty6()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty6);
            }
            return total.ToString();
        }
        private string PRQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRQty1);
            }
            return total.ToString();
        }
        private string PRQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRQty2);
            }
            return total.ToString();
        }
        private string PRQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRQty3);
            }
            return total.ToString();
        }
        private string ATQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATQty1);
            }
            return total.ToString();
        }
        private string ATQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATQty2);
            }
            return total.ToString();
        }

        // // // // // 
        // Amount
        // // // // //
        private string MEAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MEAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MEAmount1));
                }
            }

            return total.ToString();
        }
        private string MEAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MEAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MEAmount2));
                }
            }

            return total.ToString();
        }
        private string MEAmount3()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MEAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MEAmount3));
                }
            }

            return total.ToString();
        }
        private string UNMWAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.UNMWAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.UNMWAmount1));
                }
            }

            return total.ToString();
        }
        private string UNMWAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.UNMWAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.UNMWAmount2));
                }
            }

            return total.ToString();
        }
        private string NYFPAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.NYFPAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.NYFPAmount1));
                }
            }

            return total.ToString();
        }
        private string NYFPAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.NYFPAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.NYFPAmount2));
                }
            }

            return total.ToString();
        }
        private string NYFPAmount3()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.NYFPAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.NYFPAmount3));
                }
            }

            return total.ToString();
        }
        private string NYFPAmount4()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.NYFPAmount4)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.NYFPAmount4));
                }
            }

            return total.ToString();
        }
        private string JAIAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.JAIAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.JAIAmount1));
                }
            }

            return total.ToString();
        }
        private string JAIAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.JAIAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.JAIAmount2));
                }
            }

            return total.ToString();
        }
        private string DRTNAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.DRTNAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.DRTNAmount1));
                }
            }

            return total.ToString();
        }
        private string DRTNAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.DRTNAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.DRTNAmount2));
                }
            }

            return total.ToString();
        }
        private string DRTNAmount3()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.DRTNAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.DRTNAmount3));
                }
            }

            return total.ToString();
        }
        private string DRTNAmount4()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.DRTNAmount4)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.DRTNAmount4));
                }
            }

            return total.ToString();
        }
        private string MDAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MDAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MDAmount1));
                }
            }

            return total.ToString();
        }
        private string MDAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MDAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MDAmount2));
                }
            }

            return total.ToString();
        }
        private string MDAmount3()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MDAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MDAmount3));
                }
            }

            return total.ToString();
        }
        private string MDAmount4()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MDAmount4)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MDAmount4));
                }
            }

            return total.ToString();
        }
        private string MDAmount5()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MDAmount5)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MDAmount5));
                }
            }

            return total.ToString();
        }
        private string MDAmount6()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.MDAmount6)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.MDAmount6));
                }
            }

            return total.ToString();
        }
        private string PRAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.PRAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.PRAmount1));
                }
            }

            return total.ToString();
        }
        private string PRAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.PRAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.PRAmount2));
                }
            }

            return total.ToString();
        }
        private string PRAmount3()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.PRAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.PRAmount3));
                }
            }

            return total.ToString();
        }
        private string ATAmount1()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.ATAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.ATAmount1));
                }
            }

            return total.ToString();
        }
        private string ATAmount2()
        {
            decimal total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                if (dSales.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(dSales.ATAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(dSales.ATAmount2));
                }
            }

            return total.ToString();
        }

        private void ToDateValidation(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = DateTime.Today;
                MessageBox.Show("Date To should not be less than Date From", "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void FromDateValidation(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker1.Value = DateTime.Today;
                MessageBox.Show("Date From should not be greater than Date To", "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private string DateMessage()
        {
            string message = "";
            if (dateTimePicker1.Value.Date.ToString("MM/dd/yyyy") == dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"))
            {
                message = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            }
            else
            {
                message = "From " + dateTimePicker1.Value.Date.ToString("MM/dd/yyyy") + " To " + dateTimePicker2.Value.Date.ToString("MM/dd/yyyy");
            }
            return message;
        }

        private string FirstShift()
        {
            string message = DatabaseClass.NumberSeries("09:00", "12:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            return message;
        }

        private string SecondShift()
        {
            string message = DatabaseClass.NumberSeries("12:01", "17:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            return message;
        }

        private string ThirdShift()
        {
            string message = DatabaseClass.NumberSeries("17:01", "23:59", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            return message;
        }
        private string FirstShiftTotal()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModels("09:00", "12:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private string SecondShiftTotal()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModels("12:01", "17:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private string ThirdShiftTotal()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModels("17:01", "23:59", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private string TotalAmount()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModel(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            int count = 1;
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Daily Sales Report as PDF",
                FileName = "DailySalesReport_" + dateTimePicker1.Value.Date.ToString("MMddyyyy"),
                DefaultExt = "pdf",
                AddExtension = true,
                Filter = "PDF (*.pdf)|*.pdf",
                OverwritePrompt = false

            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fullPath = saveFile.FileName;
                string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
                string extension = Path.GetExtension(fullPath);
                string path = Path.GetDirectoryName(fullPath);
                string newFullPath = fullPath;

                while (File.Exists(newFullPath))
                {
                    string lastFullPath = newFullPath;
                    string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                    newFullPath = Path.Combine(path, tempFileName + extension);
                    MessageBox.Show(lastFullPath + " already exist. Renaming to " + newFullPath, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Document document = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(newFullPath, FileMode.Create));
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 9);
                document.Open();
                PdfPCell header = new PdfPCell(new Phrase("Ika's Wellness Spa Daily Sales Report - " + DateMessage(), font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 1,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell manhattan = new PdfPCell(new Phrase("Manhattan Experience:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell unmessage = new PdfPCell(new Phrase("UN Message to the world:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell nyfoot = new PdfPCell(new Phrase("NY Foot paradise:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell justaddit = new PdfPCell(new Phrase("Just Add it:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell duration = new PdfPCell(new Phrase("Duration:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell medium = new PdfPCell(new Phrase("Medium:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell pressure = new PdfPCell(new Phrase("Pressure:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell additional = new PdfPCell(new Phrase("Additional time:", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 0,
                    BackgroundColor = BaseColor.LIGHT_GRAY
                };

                PdfPCell blank = new PdfPCell(new Phrase(" ", font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 1
                };

                PdfPTable table = new PdfPTable(4);
                table.AddCell(header);
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Price", font)));
                table.AddCell(new PdfPCell(new Phrase("Quantity", font)));
                table.AddCell(new PdfPCell(new Phrase("Amount", font)));
                // Manhattan
                table.AddCell(manhattan);
                // ME1
                table.AddCell(new PdfPCell(new Phrase("NYC Exp full body", font)));
                table.AddCell(new PdfPCell(new Phrase("250", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount1(), font)));
                // ME2
                table.AddCell(new PdfPCell(new Phrase("Manhattan full body", font)));
                table.AddCell(new PdfPCell(new Phrase("350", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount2(), font)));
                // ME3
                table.AddCell(new PdfPCell(new Phrase("Manhattan skin plus", font)));
                table.AddCell(new PdfPCell(new Phrase("450", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount3(), font)));
                // UN Message to the world
                table.AddCell(unmessage);
                // UNMW1 
                table.AddCell(new PdfPCell(new Phrase("Balinese full body massage 75 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("595", font)));
                table.AddCell(new PdfPCell(new Phrase(UNMWQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(UNMWAmount1(), font)));
                // UNMW2
                table.AddCell(new PdfPCell(new Phrase("Brazilian deep tissue 75 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("695", font)));
                table.AddCell(new PdfPCell(new Phrase(UNMWQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(UNMWAmount2(), font)));
                // NY Foot paradise
                table.AddCell(nyfoot);
                // NYFP1
                table.AddCell(new PdfPCell(new Phrase("Oriental foot relax 30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("299", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount1(), font)));
                // NYFP2
                table.AddCell(new PdfPCell(new Phrase("Bangkok foot therapy 30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("495", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount2(), font)));
                // NYFP3
                table.AddCell(new PdfPCell(new Phrase("Bangkok foot therapy 30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("399", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount3(), font)));
                // NYFP4
                table.AddCell(new PdfPCell(new Phrase("Bangkok foot therapy 60 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("595", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty4(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount4(), font)));
                // Just add it
                table.AddCell(justaddit);
                // JAI1
                table.AddCell(new PdfPCell(new Phrase("New Yorker's Foot Soak", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(JAIQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(JAIAmount1(), font)));
                // JAI2
                table.AddCell(new PdfPCell(new Phrase("New Yorker's Foot Soak", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(JAIQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(JAIAmount2(), font)));
                // Duration
                table.AddCell(duration);
                // DRTN1
                table.AddCell(new PdfPCell(new Phrase("5 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("50", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount1(), font)));
                // DRTN2
                table.AddCell(new PdfPCell(new Phrase("15 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("150", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount2(), font)));
                // DRTN3
                table.AddCell(new PdfPCell(new Phrase("30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("295", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount3(), font)));
                // DRTN4
                table.AddCell(new PdfPCell(new Phrase("60 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("495", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty4(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount4(), font)));
                // Medium
                table.AddCell(medium);
                // MD1
                table.AddCell(new PdfPCell(new Phrase("Dry oil", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase(MDQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(MDAmount1(), font)));
                // MD2
                table.AddCell(new PdfPCell(new Phrase("Unscented", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase(MDQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(MDAmount2(), font)));
                // MD3
                table.AddCell(new PdfPCell(new Phrase("Aromatherapy oil", font)));
                table.AddCell(new PdfPCell(new Phrase("50", font)));
                table.AddCell(new PdfPCell(new Phrase(MDQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(MDAmount3(), font)));
                // MD4
                table.AddCell(new PdfPCell(new Phrase("Glutawhite lotion", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(MDQty4(), font)));
                table.AddCell(new PdfPCell(new Phrase(MDAmount4(), font)));
                // MD5
                table.AddCell(new PdfPCell(new Phrase("Total moisture", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(MDQty5(), font)));
                table.AddCell(new PdfPCell(new Phrase(MDAmount5(), font)));

                // MD6
                table.AddCell(new PdfPCell(new Phrase("Nutralce lotion", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(MDQty6(), font)));
                table.AddCell(new PdfPCell(new Phrase(MDAmount6(), font)));
                // Pressure
                table.AddCell(pressure);
                // PR1
                table.AddCell(new PdfPCell(new Phrase("Gentle", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase(PRQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(PRAmount1(), font)));
                // PR2
                table.AddCell(new PdfPCell(new Phrase("Regular", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase(PRQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(PRAmount2(), font)));
                // PR3
                table.AddCell(new PdfPCell(new Phrase("Strong", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(PRQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(PRAmount3(), font)));
                // Additional time
                table.AddCell(additional);
                // AT1
                table.AddCell(new PdfPCell(new Phrase("10 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(ATQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(ATAmount1(), font)));
                // AT2
                table.AddCell(new PdfPCell(new Phrase("30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("200", font)));
                table.AddCell(new PdfPCell(new Phrase(ATQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(ATAmount2(), font)));

                // Blank
                table.AddCell(blank);

                // Total
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");
                table.AddCell(new PdfPCell(new Phrase("Total: " + TotalAmount(), font)));

                // Blank
                table.AddCell(blank);

                // Tabulation
                table.AddCell(new PdfPCell(new Phrase("09:00 - 12:00", font)));
                table.AddCell(new PdfPCell(new Phrase("No. of Series: " + FirstShift(), font)));
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Total: " + FirstShiftTotal(), font)));
                table.AddCell(new PdfPCell(new Phrase("12:01 - 17:00", font)));
                table.AddCell(new PdfPCell(new Phrase("No. of Series: " + SecondShift(), font)));
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Total: " + SecondShiftTotal(), font)));
                table.AddCell(new PdfPCell(new Phrase("17:01 - 23:59", font)));
                table.AddCell(new PdfPCell(new Phrase("No. of Series: " + ThirdShift(), font)));
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Total: " + ThirdShiftTotal(), font)));

                document.Add(table);
                document.Close();

                MessageBox.Show("Daily Sales Report created in " + newFullPath, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int MEQty1Report(string date1)
        {
            int rtotal = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(date1, date1);
            foreach (var dSales in dailySales)
            {
                rtotal = Int32.Parse(dSales.MEQty1);
            }
            return rtotal;
        }

        private int MEAmount1Report(string date1)
        {
            int rtotal = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(date1, date1);
            foreach (var dSales in dailySales)
            {
                rtotal = Int32.Parse(dSales.MEQty1);
            }
            return rtotal;
        }

        private string ComputeDiscount(int compute)
        {
            double netvat = (double)compute / 1.12;
            double vat = netvat * 0.12;
            double scd = netvat * 0.20;
            double discount = (netvat + vat) - scd;
            
            float ComputeDiscount = float.Parse(Math.Round(discount, 2).ToString());

            return ComputeDiscount.ToString();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            int count = 1;
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Daily Sales Report as Excel",
                FileName = "DailySalesReport_" + dateTimePicker1.Value.Date.ToString("MMddyyyy"),
                DefaultExt = "pdf",
                AddExtension = true,
                Filter = "Excel (*.xlsx)|*.xlsx",
                OverwritePrompt = false

            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fullPath = saveFile.FileName;
                string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
                string extension = Path.GetExtension(fullPath);
                string path = Path.GetDirectoryName(fullPath);
                string newFullPath = fullPath;

                while (File.Exists(newFullPath))
                {
                    string lastFullPath = newFullPath;
                    string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                    newFullPath = Path.Combine(path, tempFileName + extension);
                    MessageBox.Show(lastFullPath + " already exist. Renaming to " + newFullPath, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Excel.Application application;
                Excel.Worksheet worksheet;
                Excel.Workbook workbook;

                application = new Excel.Application();
                workbook = application.Workbooks.Add();
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

                worksheet.Cells[2, 2] = "Price";
                worksheet.Cells[3, 1] = "Manhattan exp:";
                worksheet.Cells[4, 1] = "NYC Exp full body";
                worksheet.Cells[5, 1] = "Manhattan full body";
                worksheet.Cells[6, 1] = "Manhattan skin plus";

                worksheet.Cells[4, 2] = "250";
                worksheet.Cells[5, 2] = "350";
                worksheet.Cells[6, 2] = "450";

                worksheet.Cells[8, 1] = "UN Massages of the world:";
                worksheet.Cells[9, 1] = "Balinese full body massage 75 mins";
                worksheet.Cells[10, 1] = "Brazilian deep tissue 75 mins";

                worksheet.Cells[9, 2] = "595";
                worksheet.Cells[10, 2] = "695";

                worksheet.Cells[12, 1] = "NY Foot paradise:";
                worksheet.Cells[13, 1] = "Oriental foot relax 30 mins";
                worksheet.Cells[14, 1] = "Oriental foot relax 60 mins";
                worksheet.Cells[15, 1] = "Bangkok foot therapy 30 mins";
                worksheet.Cells[16, 1] = "Bangkok foot therapy 60 mins";

                worksheet.Cells[13, 2] = "299";
                worksheet.Cells[14, 2] = "495";
                worksheet.Cells[15, 2] = "399";
                worksheet.Cells[16, 2] = "595";

                worksheet.Cells[18, 1] = "Just Add it:";
                worksheet.Cells[19, 1] = "New Yorker's Foot Soak";
                worksheet.Cells[20, 1] = "New Yorker's Foot Scrub";

                worksheet.Cells[19, 2] = "100";
                worksheet.Cells[20, 2] = "100";

                worksheet.Cells[22, 1] = "Duration:";
                worksheet.Cells[23, 1] = "5 mins";
                worksheet.Cells[24, 1] = "15 mins";
                worksheet.Cells[25, 1] = "30 mins";
                worksheet.Cells[26, 1] = "60 mins";

                worksheet.Cells[23, 2] = "50";
                worksheet.Cells[24, 2] = "150";
                worksheet.Cells[25, 2] = "295";
                worksheet.Cells[26, 2] = "495";

                worksheet.Cells[28, 1] = "Medium:";
                worksheet.Cells[29, 1] = "Dry oil";
                worksheet.Cells[30, 1] = "Unscented";
                worksheet.Cells[31, 1] = "Aromatherapy oil";
                worksheet.Cells[32, 1] = "Glutawhite lotion";
                worksheet.Cells[33, 1] = "Total moisture";
                worksheet.Cells[34, 1] = "Nutralce lotion";

                worksheet.Cells[29, 2] = "0";
                worksheet.Cells[30, 2] = "0";
                worksheet.Cells[31, 2] = "50";
                worksheet.Cells[32, 2] = "100";
                worksheet.Cells[33, 2] = "100";
                worksheet.Cells[34, 2] = "100";

                worksheet.Cells[36, 1] = "Pressure:";
                worksheet.Cells[37, 1] = "Gentle";
                worksheet.Cells[38, 1] = "Regular";
                worksheet.Cells[39, 1] = "Strong";

                worksheet.Cells[37, 2] = "0";
                worksheet.Cells[38, 2] = "0";
                worksheet.Cells[39, 2] = "100";

                worksheet.Cells[41, 1] = "Additional time:";
                worksheet.Cells[42, 1] = "10 mins";
                worksheet.Cells[43, 1] = "30 mins";

                worksheet.Cells[42, 2] = "100";
                worksheet.Cells[43, 2] = "200";
                

                int x = 3;
                int xx = 4;

                DateTime datefrom = dateTimePicker1.Value.Date;
                DateTime dateto = dateTimePicker2.Value.Date;

                var dates = new List<string>();

                for (DateTime date = datefrom; date <= dateto; date = date.AddDays(1))
                {
                    string d = date.ToString("MM/dd/yyyy");
                    dates.Add(d);
                }

                foreach (var date in dates)
                {
                    worksheet.Cells[1, x] = date;
                    worksheet.Range[worksheet.Cells[1, x], worksheet.Cells[1, xx]].Merge();
                    worksheet.Cells[2, x] = "Qty";
                    worksheet.Cells[2, xx] = "Amount";

                    int qty1 = 0;
                    int qty2 = 0;
                    int qty3 = 0;
                    int qty4 = 0;
                    int qty5 = 0;
                    int qty6 = 0;
                    int qty7 = 0;
                    int qty8 = 0;
                    int qty9 = 0;
                    int qty10 = 0;
                    int qty11 = 0;
                    int qty12 = 0;
                    int qty13 = 0;
                    int qty14 = 0;
                    int qty15 = 0;
                    int qty16 = 0;
                    int qty17 = 0;
                    int qty18 = 0;
                    int qty19 = 0;
                    int qty20 = 0;
                    int qty21 = 0;
                    int qty22 = 0;
                    int qty23 = 0;
                    int qty24 = 0;
                    int qty25 = 0;
                    int qty26 = 0;

                    decimal amt1 = 0;
                    decimal amt2 = 0;
                    decimal amt3 = 0;
                    decimal amt4 = 0;
                    decimal amt5 = 0;
                    decimal amt6 = 0;
                    decimal amt7 = 0;
                    decimal amt8 = 0;
                    decimal amt9 = 0;
                    decimal amt10 = 0;
                    decimal amt11 = 0;
                    decimal amt12 = 0;
                    decimal amt13 = 0;
                    decimal amt14 = 0;
                    decimal amt15 = 0;
                    decimal amt16 = 0;
                    decimal amt17 = 0;
                    decimal amt18 = 0;
                    decimal amt19 = 0;
                    decimal amt20 = 0;
                    decimal amt21 = 0;
                    decimal amt22 = 0;
                    decimal amt23 = 0;
                    decimal amt24 = 0;
                    decimal amt25 = 0;
                    decimal amt26 = 0;

                    decimal total = 0;
                    
                    foreach (var clientRecord in DatabaseClass.LoadClientRecord(date, date))
                    {
                        qty1 += Convert.ToInt32(clientRecord.MEQty1);
                        qty2 += Convert.ToInt32(clientRecord.MEQty2);
                        qty3 += Convert.ToInt32(clientRecord.MEQty3);
                        qty4 += Convert.ToInt32(clientRecord.UNMWQty1);
                        qty5 += Convert.ToInt32(clientRecord.UNMWQty2);
                        qty6 += Convert.ToInt32(clientRecord.NYFPQty1);
                        qty7 += Convert.ToInt32(clientRecord.NYFPQty2);
                        qty8 += Convert.ToInt32(clientRecord.NYFPQty3);
                        qty9 += Convert.ToInt32(clientRecord.NYFPQty4);
                        qty10 += Convert.ToInt32(clientRecord.DRTNQty1);
                        qty11 += Convert.ToInt32(clientRecord.DRTNQty2);
                        qty12 += Convert.ToInt32(clientRecord.DRTNQty3);
                        qty13 += Convert.ToInt32(clientRecord.DRTNQty4);
                        qty14 += Convert.ToInt32(clientRecord.MDQty1);
                        qty15 += Convert.ToInt32(clientRecord.MDQty2);
                        qty16 += Convert.ToInt32(clientRecord.MDQty3);
                        qty17 += Convert.ToInt32(clientRecord.MDQty4);
                        qty18 += Convert.ToInt32(clientRecord.MDQty5);
                        qty19 += Convert.ToInt32(clientRecord.MDQty6);
                        qty20 += Convert.ToInt32(clientRecord.PRQty1);
                        qty21 += Convert.ToInt32(clientRecord.PRQty2);
                        qty22 += Convert.ToInt32(clientRecord.PRQty3);
                        qty23 += Convert.ToInt32(clientRecord.ATQty1);
                        qty24 += Convert.ToInt32(clientRecord.ATQty2);
                        qty25 += Convert.ToInt32(clientRecord.JAIQty1);
                        qty26 += Convert.ToInt32(clientRecord.JAIQty2);

                        if (clientRecord.SeniorCitizen == "True")
                        {
                            amt1 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MEAmount1)));
                            amt2 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MEAmount2)));
                            amt3 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MEAmount3)));
                            amt4 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.UNMWAmount1)));
                            amt5 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.UNMWAmount2)));
                            amt6 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.NYFPAmount1)));
                            amt7 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.NYFPAmount2)));
                            amt8 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.NYFPAmount3)));
                            amt9 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.NYFPAmount4)));
                            amt10 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.DRTNAmount1)));
                            amt11 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.DRTNAmount2)));
                            amt12 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.DRTNAmount3)));
                            amt13 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.DRTNAmount4)));
                            amt14 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MDAmount1)));
                            amt15 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MDAmount2)));
                            amt16 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MDAmount3)));
                            amt17 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MDAmount4)));
                            amt18 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MDAmount5)));
                            amt19 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.MDAmount6)));
                            amt20 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.PRAmount1)));
                            amt21 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.PRAmount2)));
                            amt22 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.PRAmount3)));
                            amt23 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.ATAmount1)));
                            amt24 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.ATAmount2)));
                            amt25 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.JAIAmount1)));
                            amt26 += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.JAIAmount2)));
                            total += Convert.ToDecimal(ComputeDiscount(Convert.ToInt32(clientRecord.Total)));
                        }
                        else
                        {
                            amt1 += Convert.ToInt32(clientRecord.MEAmount1);
                            amt2 += Convert.ToInt32(clientRecord.MEAmount2);
                            amt3 += Convert.ToInt32(clientRecord.MEAmount3);
                            amt4 += Convert.ToInt32(clientRecord.UNMWAmount1);
                            amt5 += Convert.ToInt32(clientRecord.UNMWAmount2);
                            amt6 += Convert.ToInt32(clientRecord.NYFPAmount1);
                            amt7 += Convert.ToInt32(clientRecord.NYFPAmount2);
                            amt8 += Convert.ToInt32(clientRecord.NYFPAmount3);
                            amt9 += Convert.ToInt32(clientRecord.NYFPAmount4);
                            amt10 += Convert.ToInt32(clientRecord.DRTNAmount1);
                            amt11 += Convert.ToInt32(clientRecord.DRTNAmount2);
                            amt12 += Convert.ToInt32(clientRecord.DRTNAmount3);
                            amt13 += Convert.ToInt32(clientRecord.DRTNAmount4);
                            amt14 += Convert.ToInt32(clientRecord.MDAmount1);
                            amt15 += Convert.ToInt32(clientRecord.MDAmount2);
                            amt16 += Convert.ToInt32(clientRecord.MDAmount3);
                            amt17 += Convert.ToInt32(clientRecord.MDAmount4);
                            amt18 += Convert.ToInt32(clientRecord.MDAmount5);
                            amt19 += Convert.ToInt32(clientRecord.MDAmount6);
                            amt20 += Convert.ToInt32(clientRecord.PRAmount1);
                            amt21 += Convert.ToInt32(clientRecord.PRAmount2);
                            amt22 += Convert.ToInt32(clientRecord.PRAmount3);
                            amt23 += Convert.ToInt32(clientRecord.ATAmount1);
                            amt24 += Convert.ToInt32(clientRecord.ATAmount2);
                            amt25 += Convert.ToInt32(clientRecord.JAIAmount1);
                            amt26 += Convert.ToInt32(clientRecord.JAIAmount2);
                            total += Convert.ToInt32(clientRecord.Total);
                        }

                        //Generating Excel report starts here

                        worksheet.Cells[4, x] = qty1.ToString();
                        worksheet.Cells[4, xx] = amt1.ToString();
                        worksheet.Cells[5, x] = qty2.ToString();
                        worksheet.Cells[5, xx] = amt2.ToString();
                        worksheet.Cells[6, x] = qty3.ToString();
                        worksheet.Cells[6, xx] = amt3.ToString();

                        worksheet.Cells[9, x] = qty4.ToString();
                        worksheet.Cells[9, xx] = amt4.ToString();
                        worksheet.Cells[10, x] = qty5.ToString();
                        worksheet.Cells[10, xx] = amt5.ToString();

                        worksheet.Cells[13, x] = qty6.ToString();
                        worksheet.Cells[13, xx] = amt6.ToString();
                        worksheet.Cells[14, x] = qty7.ToString();
                        worksheet.Cells[14, xx] = amt7.ToString();
                        worksheet.Cells[15, x] = qty8.ToString();
                        worksheet.Cells[15, xx] = amt8.ToString();
                        worksheet.Cells[16, x] = qty9.ToString();
                        worksheet.Cells[16, xx] = amt9.ToString();

                        worksheet.Cells[19, x] = qty25.ToString();
                        worksheet.Cells[19, xx] = amt25.ToString();
                        worksheet.Cells[20, x] = qty26.ToString();
                        worksheet.Cells[20, xx] = amt26.ToString();

                        worksheet.Cells[23, x] = qty10.ToString();
                        worksheet.Cells[23, xx] = amt10.ToString();
                        worksheet.Cells[24, x] = qty11.ToString();
                        worksheet.Cells[24, xx] = amt11.ToString();
                        worksheet.Cells[25, x] = qty12.ToString();
                        worksheet.Cells[25, xx] = amt12.ToString();
                        worksheet.Cells[26, x] = qty13.ToString();
                        worksheet.Cells[26, xx] = amt13.ToString();

                        worksheet.Cells[29, x] = qty14.ToString();
                        worksheet.Cells[29, xx] = amt14.ToString();
                        worksheet.Cells[30, x] = qty15.ToString();
                        worksheet.Cells[30, xx] = amt15.ToString();
                        worksheet.Cells[31, x] = qty16.ToString();
                        worksheet.Cells[31, xx] = amt16.ToString();
                        worksheet.Cells[32, x] = qty17.ToString();
                        worksheet.Cells[32, xx] = amt17.ToString();
                        worksheet.Cells[33, x] = qty18.ToString();
                        worksheet.Cells[33, xx] = amt18.ToString();
                        worksheet.Cells[34, x] = qty19.ToString();
                        worksheet.Cells[34, xx] = amt19.ToString();

                        worksheet.Cells[37, x] = qty20.ToString();
                        worksheet.Cells[37, xx] = amt20.ToString();
                        worksheet.Cells[38, x] = qty21.ToString();
                        worksheet.Cells[38, xx] = amt21.ToString();
                        worksheet.Cells[39, x] = qty22.ToString();
                        worksheet.Cells[39, xx] = amt22.ToString();

                        worksheet.Cells[42, x] = qty23.ToString();
                        worksheet.Cells[42, xx] = amt23.ToString();
                        worksheet.Cells[43, x] = qty24.ToString();
                        worksheet.Cells[43, xx] = amt24.ToString();

                        worksheet.Cells[44, xx] = total.ToString();
                    }

                    x += 2;
                    xx += 2;
                }

                workbook.SaveAs(newFullPath);
                workbook.Close();
                application.Quit();

                MessageBox.Show("Daily Sales Report created in " + newFullPath, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
