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
using bigapplelib;

namespace bigapple
{
    public partial class TherapistReport : UserControl
    {
        List<DailySalesClientModel> therapistReport = new List<DailySalesClientModel>();
        List<TotalSalesClientModel> totalSales = new List<TotalSalesClientModel>();
        public TherapistReport()
        {
            InitializeComponent();
            RefreshCBList();
        }

        public void RefreshCBList()
        {
            StreamReader reader = new StreamReader(@".\Therapist.txt");
            string x = reader.ReadToEnd();
            string[] y = x.Split('\n');
            foreach (string data in y)
            {
                data.Trim();
                TherapistListCB.Items.Add(data);
            }
        }

        // // // // // 
        // Quantity
        // // // // //
        private string MEQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MEQty1);
            }
            return total.ToString();
        }

        private string MEQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MEQty2);
            }
            return total.ToString();
        }
        private string MEQty3()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MEQty3);
            }
            return total.ToString();
        }
        private string UNMWQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.UNMWQty1);
            }
            
            return total.ToString();
        }
        private string UNMWQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.UNMWQty2);
            }
            
            return total.ToString();
        }
        private string NYFPQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.NYFPQty1);
            }
            
            return total.ToString();
        }
        private string NYFPQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.NYFPQty2);
            }
            
            return total.ToString();
        }
        private string NYFPQty3()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.NYFPQty3);
            }
            
            return total.ToString();
        }
        private string NYFPQty4()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.NYFPQty4);
            }
            
            return total.ToString();
        }
        private string JAIQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.JAIQty1);
            }

            return total.ToString();
        }
        private string JAIQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.JAIQty2);
            }

            return total.ToString();
        }
        private string DRTNQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.DRTNQty1);
            }
            
            return total.ToString();
        }
        private string DRTNQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.DRTNQty2);
            }
            
            return total.ToString();
        }
        private string DRTNQty3()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.DRTNQty3);
            }
            
            return total.ToString();
        }
        private string DRTNQty4()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.DRTNQty4);
            }
            
            return total.ToString();
        }
        private string MDQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MDQty1);
            }
            
            return total.ToString();
        }
        private string MDQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MDQty2);
            }
            
            return total.ToString();
        }
        private string MDQty3()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MDQty3);
            }
            
            return total.ToString();
        }
        private string MDQty4()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MDQty4);
            }
            
            return total.ToString();
        }
        private string MDQty5()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MDQty5);
            }
            
            return total.ToString();
        }
        private string MDQty6()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.MDQty6);
            }
            
            return total.ToString();
        }
        private string PRQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.PRQty1);
            }
            
            return total.ToString();
        }
        private string PRQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.PRQty2);
            }
            
            return total.ToString();
        }
        private string PRQty3()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.PRQty3);
            }
            
            return total.ToString();
        }
        private string ATQty1()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.ATQty1);
            }
            
            return total.ToString();
        }
        private string ATQty2()
        {
            int total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                total += Int32.Parse(tReport.ATQty2);
            }
            
            return total.ToString();
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

        // // // // // 
        // Amount
        // // // // //
        private string MEAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MEAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MEAmount1));
                }
            }
            
            return total.ToString();
        }

        private string MEAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MEAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MEAmount2));
                }
            }
            
            return total.ToString();
        }
        private string MEAmount3()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MEAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MEAmount3));
                }
            }
            
            return total.ToString();
        }
        private string UNMWAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.UNMWAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.UNMWAmount1));
                }
            }
            
            return total.ToString();
        }
        private string UNMWAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.UNMWAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.UNMWAmount2));
                }
            }
            
            return total.ToString();
        }
        private string NYFPAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.NYFPAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.NYFPAmount1));
                }
            }
            
            return total.ToString();
        }
        private string NYFPAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.NYFPAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.NYFPAmount2));
                }
            }
            
            return total.ToString();
        }
        private string NYFPAmount3()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.NYFPAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.NYFPAmount3));
                }
            }
            
            return total.ToString();
        }
        private string NYFPAmount4()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.NYFPAmount4)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.NYFPAmount4));
                }
            }
            
            return total.ToString();
        }
        private string JAIAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.JAIAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.JAIAmount1));
                }
            }

            return total.ToString();
        }
        private string JAIAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.JAIAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.JAIAmount2));
                }
            }

            return total.ToString();
        }
        private string DRTNAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.DRTNAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.DRTNAmount1));
                }
            }
            
            return total.ToString();
        }
        private string DRTNAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.DRTNAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.DRTNAmount2));
                }
            }
            
            return total.ToString();
        }
        private string DRTNAmount3()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.DRTNAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.DRTNAmount3));
                }
            }
            
            return total.ToString();
        }
        private string DRTNAmount4()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.DRTNAmount4)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.DRTNAmount4));
                }
            }
            
            return total.ToString();
        }
        private string MDAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MDAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MDAmount1));
                }
            }
            
            return total.ToString();
        }
        private string MDAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MDAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MDAmount2));
                }
            }
            
            return total.ToString();
        }
        private string MDAmount3()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MDAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MDAmount3));
                }
            }
            
            return total.ToString();
        }
        private string MDAmount4()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MDAmount4)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MDAmount4));
                }
            }
            
            return total.ToString();
        }
        private string MDAmount5()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MDAmount5)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MDAmount5));
                }
            }
            
            return total.ToString();
        }
        private string MDAmount6()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.MDAmount6)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.MDAmount6));
                }
            }
            
            return total.ToString();
        }
        private string PRAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.PRAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.PRAmount1));
                }
            }
            
            return total.ToString();
        }
        private string PRAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.PRAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.PRAmount2));
                }
            }
            
            return total.ToString();
        }
        private string PRAmount3()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.PRAmount3)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.PRAmount3));
                }
            }
            
            return total.ToString();
        }
        private string ATAmount1()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.ATAmount1)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.ATAmount1));
                }
            }
            
            return total.ToString();
        }
        private string ATAmount2()
        {
            decimal total = 0;
            therapistReport = DatabaseClass.LoadTherapistRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tReport in therapistReport)
            {
                if (tReport.SeniorCitizen == "True")
                {
                    total += Convert.ToDecimal(ComputeDiscount(Int32.Parse(tReport.ATAmount2)));
                }
                else
                {
                    total += Convert.ToDecimal(Int32.Parse(tReport.ATAmount2));
                }
            }
            
            return total.ToString();
        }

        private void ToDateValidation(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Date To should not be less than Date From", "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker2.Value = DateTime.Today;
                return;
            }
        }

        private void FromDateValidation(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Date From should not be greater than Date To", "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Value = DateTime.Today;
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
            string message = DatabaseClass.NumberSeriesWithTherapist("09:00", "12:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            return message;
        }

        private string SecondShift()
        {
            string message = DatabaseClass.NumberSeriesWithTherapist("12:01", "17:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            return message;
        }

        private string ThirdShift()
        {
            string message = DatabaseClass.NumberSeriesWithTherapist("17:01", "23:59", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            return message;
        }
        private string FirstShiftTotal()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModelsWithTherapist("09:00", "12:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private string SecondShiftTotal()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModelsWithTherapist("12:01", "17:00", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private string ThirdShiftTotal()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModelsWithTherapist("17:01", "23:59", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private string TotalAmount()
        {
            decimal total = 0;
            totalSales = DatabaseClass.TotalSalesClientModelWithTherapist(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"), TherapistListCB.Text.Trim());
            foreach (var tSales in totalSales)
            {
                total += Convert.ToDecimal(tSales.TotalAmountDue);
            }
            return total.ToString();
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            int count = 1;
            if (TherapistListCB.Text.Trim() == "")
            {
                MessageBox.Show("Please select a Therapist to generate a report.", "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Therapist Sales Report as PDF",
                FileName = "TherapistSalesReport_" + TherapistListCB.Text.Trim() + "_" + dateTimePicker1.Value.Date.ToString("MMddyyyy"),
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
                    MessageBox.Show(lastFullPath + " already exist. Renaming to " + newFullPath, "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Document document = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(newFullPath, FileMode.Create));
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 9);
                document.Open();
                PdfPCell header = new PdfPCell(new Phrase("Ika's Wellness Spa Therapist Sales Report for " + TherapistListCB.Text.Trim() + " - " + DateMessage(), font))
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

                // Total
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");
                table.AddCell(new PdfPCell(new Phrase("Total: " + TotalAmount(), font)));

                // Blank
                table.AddCell(blank);
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

                MessageBox.Show("Therapist Sales Report created in " + newFullPath, "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
