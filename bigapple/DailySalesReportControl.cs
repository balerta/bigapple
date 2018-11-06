﻿using System;
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
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount1);
            }
            
            return total.ToString();
        }

        private string MEAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount2);
            }
            
            return total.ToString();
        }
        private string MEAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount3);
            }
            
            return total.ToString();
        }
        private string UNMWAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWAmount1);
            }
            
            return total.ToString();
        }
        private string UNMWAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWAmount2);
            }
            
            return total.ToString();
        }
        private string NYFPAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount1);
            }
            
            return total.ToString();
        }
        private string NYFPAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount2);
            }
            
            return total.ToString();
        }
        private string NYFPAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount3);
            }
            
            return total.ToString();
        }
        private string NYFPAmount4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount4);
            }
            
            return total.ToString();
        }
        private string DRTNAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount1);
            }
            
            return total.ToString();
        }
        private string DRTNAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount2);
            }
            
            return total.ToString();
        }
        private string DRTNAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount3);
            }
            
            return total.ToString();
        }
        private string DRTNAmount4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount4);
            }
            
            return total.ToString();
        }
        private string MDAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount1);
            }
            
            return total.ToString();
        }
        private string MDAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount2);
            }
            
            return total.ToString();
        }
        private string MDAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount3);
            }
            
            return total.ToString();
        }
        private string MDAmount4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount4);
            }
            
            return total.ToString();
        }
        private string MDAmount5()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount5);
            }
            
            return total.ToString();
        }
        private string MDAmount6()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount6);
            }
            
            return total.ToString();
        }
        private string PRAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRAmount1);
            }
            
            return total.ToString();
        }
        private string PRAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRAmount2);
            }
            
            return total.ToString();
        }
        private string PRAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRAmount3);
            }
            
            return total.ToString();
        }
        private string ATAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATAmount1);
            }
            
            return total.ToString();
        }
        private string ATAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATAmount2);
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
            string message = DatabaseClass.NumberSeries("10:00 AM", "12:59 PM", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            return message;
        }

        private string SecondShift()
        {
            string message = DatabaseClass.NumberSeries("01:00 PM", "04:59 PM", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            return message;
        }

        private string ThirdShift()
        {
            string message = DatabaseClass.NumberSeries("05:00 PM", "09:00 PM", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            return message;
        }
        private string FirstShiftTotal()
        {
            int total = 0;
            totalSales = DatabaseClass.TotalSalesClientModels("10:00 AM", "12:59 PM", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Int32.Parse(tSales.Total);
            }
            return total.ToString();
        }

        private string SecondShiftTotal()
        {
            int total = 0;
            totalSales = DatabaseClass.TotalSalesClientModels("01:00 PM", "04:59 PM", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Int32.Parse(tSales.Total);
            }
            return total.ToString();
        }

        private string ThirdShiftTotal()
        {
            int total = 0;
            totalSales = DatabaseClass.TotalSalesClientModels("05:01 PM", "09:00 PM", dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Int32.Parse(tSales.Total);
            }
            return total.ToString();
        }

        private string TotalAmount()
        {
            int total = 0;
            totalSales = DatabaseClass.TotalSalesClientModel(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var tSales in totalSales)
            {
                total += Int32.Parse(tSales.Total);
            }
            return total.ToString();
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            int count = 1;
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Daily Sales Report as PDF",
                FileName = "BigApple_DailySalesReport_" + dateTimePicker1.Value.Date.ToString("MMddyyyy"),
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
                PdfPCell header = new PdfPCell(new Phrase("Big Apple Daily Sales Report - " + DateMessage(), font))
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
                table.AddCell(new PdfPCell(new Phrase("NYC Exp full body 30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("195", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount1(), font)));
                // ME2
                table.AddCell(new PdfPCell(new Phrase("Manhattan full body 60 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("299", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount2(), font)));
                // ME3
                table.AddCell(new PdfPCell(new Phrase("Manhattan skin plus 60 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("499", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount3(), font)));
                // ME3
                table.AddCell(new PdfPCell(new Phrase("Manhattan skin plus 60 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("499", font)));
                table.AddCell(new PdfPCell(new Phrase(MEQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(MEAmount3(), font)));
                // UN Message to the world
                table.AddCell(unmessage);
                // UNMW1 
                table.AddCell(new PdfPCell(new Phrase("Balinese full body massage 75 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("499", font)));
                table.AddCell(new PdfPCell(new Phrase(UNMWQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(UNMWAmount1(), font)));
                // UNMW2
                table.AddCell(new PdfPCell(new Phrase("Brazilian deep tissue 75 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("599", font)));
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
                table.AddCell(new PdfPCell(new Phrase("399", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount2(), font)));
                // NYFP3
                table.AddCell(new PdfPCell(new Phrase("Addtl: NY Foot soak", font)));
                table.AddCell(new PdfPCell(new Phrase("50", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount3(), font)));
                // NYFP4
                table.AddCell(new PdfPCell(new Phrase("Addtl: NY Foot scrub", font)));
                table.AddCell(new PdfPCell(new Phrase("100", font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPQty4(), font)));
                table.AddCell(new PdfPCell(new Phrase(NYFPAmount4(), font)));
                // Duration
                table.AddCell(duration);
                // DRTN1
                table.AddCell(new PdfPCell(new Phrase("5 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("49", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty1(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount1(), font)));
                // DRTN2
                table.AddCell(new PdfPCell(new Phrase("15 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("149", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty2(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount2(), font)));
                // DRTN3
                table.AddCell(new PdfPCell(new Phrase("30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("249", font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNQty3(), font)));
                table.AddCell(new PdfPCell(new Phrase(DRTNAmount3(), font)));
                // DRTN4
                table.AddCell(new PdfPCell(new Phrase("60 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("399", font)));
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
                table.AddCell(new PdfPCell(new Phrase("10:00 AM - 12:59 PM", font)));
                table.AddCell(new PdfPCell(new Phrase("No. of Series: " + FirstShift(), font)));
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Total: " + FirstShiftTotal(), font)));
                table.AddCell(new PdfPCell(new Phrase("01:00 PM - 04:59 PM", font)));
                table.AddCell(new PdfPCell(new Phrase("No. of Series: " + SecondShift(), font)));
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Total: " + SecondShiftTotal(), font)));
                table.AddCell(new PdfPCell(new Phrase("05:00 PM - 09:00 PM", font)));
                table.AddCell(new PdfPCell(new Phrase("No. of Series: " + ThirdShift(), font)));
                table.AddCell(new PdfPCell(new Phrase("", font)));
                table.AddCell(new PdfPCell(new Phrase("Total: " + ThirdShiftTotal(), font)));

                document.Add(table);
                document.Close();

                MessageBox.Show("Daily Sales Report created in " + newFullPath, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            int count = 1;
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Daily Sales Report as Excel",
                FileName = "BigApple_DailySalesReport_" + dateTimePicker1.Value.Date.ToString("MMddyyyy"),
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

                loadClientRecord = DatabaseClass.LoadClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), dateTimePicker2.Value.Date.ToString("MM/dd/yyyy"));


                Excel.Application application;
                Excel.Worksheet worksheet;
                Excel.Workbook workbook;

                application = new Excel.Application();
                workbook = application.Workbooks.Add();
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

                int x = 3;
                int xx = 4;

                worksheet.Cells[3, 1] = "Manhattan exp:";
                worksheet.Cells[4, 1] = "NYC Exp full body 30 mins";
                worksheet.Cells[5, 1] = "Manhattan full body 60 mins";
                worksheet.Cells[6, 1] = "Manhattan skin plus 60 mins";

                worksheet.Cells[4, 2] = "195";
                worksheet.Cells[5, 2] = "299";
                worksheet.Cells[6, 2] = "499";

                worksheet.Cells[8, 1] = "UN Massages of the world:";
                worksheet.Cells[9, 1] = "Balinese full body massage 75 mins";
                worksheet.Cells[10, 1] = "Brazilian deep tissue 75 mins";

                worksheet.Cells[9, 2] = "499";
                worksheet.Cells[10, 2] = "599";

                worksheet.Cells[12, 1] = "NY Foot paradise:";
                worksheet.Cells[13, 1] = "Oriental foot relax 30 mins";
                worksheet.Cells[14, 1] = "Bangkok foot theraoy 30 mins";
                worksheet.Cells[15, 1] = "Addtl: NY Foot soak";
                worksheet.Cells[16, 1] = "Addtl: NY Foot scrub";

                worksheet.Cells[13, 2] = "299";
                worksheet.Cells[14, 2] = "399";
                worksheet.Cells[15, 2] = "50";
                worksheet.Cells[16, 2] = "100";

                worksheet.Cells[18, 1] = "Duration:";
                worksheet.Cells[19, 1] = "5 mins";
                worksheet.Cells[20, 1] = "15 mins";
                worksheet.Cells[21, 1] = "30 mins";
                worksheet.Cells[22, 1] = "60 mins";

                worksheet.Cells[19, 2] = "299";
                worksheet.Cells[20, 2] = "399";
                worksheet.Cells[21, 2] = "50";
                worksheet.Cells[22, 2] = "100";

                worksheet.Cells[24, 1] = "Medium:";
                worksheet.Cells[25, 1] = "Dry oil";
                worksheet.Cells[26, 1] = "Unscented";
                worksheet.Cells[27, 1] = "Aromatherapy oil";
                worksheet.Cells[28, 1] = "Glutawhite lotion";
                worksheet.Cells[29, 1] = "Total moisture";
                worksheet.Cells[30, 1] = "Nutralce lotion";

                worksheet.Cells[25, 2] = "299";
                worksheet.Cells[26, 2] = "399";
                worksheet.Cells[27, 2] = "50";
                worksheet.Cells[28, 2] = "100";
                worksheet.Cells[29, 2] = "50";
                worksheet.Cells[30, 2] = "100";

                worksheet.Cells[32, 1] = "Pressure:";
                worksheet.Cells[33, 1] = "Gentle";
                worksheet.Cells[34, 1] = "Regular";
                worksheet.Cells[35, 1] = "Strong";

                worksheet.Cells[33, 2] = "299";
                worksheet.Cells[34, 2] = "399";
                worksheet.Cells[35, 2] = "50";

                worksheet.Cells[37, 1] = "Additional time:";
                worksheet.Cells[38, 1] = "10 mins";
                worksheet.Cells[39, 1] = "30 mins";

                worksheet.Cells[38, 2] = "299";
                worksheet.Cells[39, 2] = "399";

                foreach (var clientRecord in loadClientRecord)
                {
                    worksheet.Cells[1, x] = clientRecord.SeriesNumber;
                    worksheet.Range[worksheet.Cells[1, x], worksheet.Cells[1, xx]].Merge();
                    worksheet.Cells[2, x] = "Qty";
                    worksheet.Cells[2, xx] = "Amount";

                    worksheet.Cells[4, x] = clientRecord.MEQty1;
                    worksheet.Cells[4, xx] = clientRecord.MEAmount1;
                    worksheet.Cells[5, x] = clientRecord.MEQty2;
                    worksheet.Cells[5, xx] = clientRecord.MEAmount2;
                    worksheet.Cells[6, x] = clientRecord.MEQty3;
                    worksheet.Cells[6, xx] = clientRecord.MEAmount3;

                    worksheet.Cells[9, x] = clientRecord.UNMWQty1;
                    worksheet.Cells[9, xx] = clientRecord.UNMWAmount1;
                    worksheet.Cells[10, x] = clientRecord.UNMWQty2;
                    worksheet.Cells[10, xx] = clientRecord.UNMWAmount2;

                    worksheet.Cells[13, x] = clientRecord.NYFPQty1;
                    worksheet.Cells[13, xx] = clientRecord.NYFPAmount1;
                    worksheet.Cells[14, x] = clientRecord.NYFPQty2;
                    worksheet.Cells[14, xx] = clientRecord.NYFPAmount2;
                    worksheet.Cells[15, x] = clientRecord.NYFPQty3;
                    worksheet.Cells[15, xx] = clientRecord.NYFPAmount3;
                    worksheet.Cells[16, x] = clientRecord.NYFPQty4;
                    worksheet.Cells[16, xx] = clientRecord.NYFPAmount4;

                    worksheet.Cells[19, x] = clientRecord.DRTNQty1;
                    worksheet.Cells[19, xx] = clientRecord.DRTNAmount1;
                    worksheet.Cells[20, x] = clientRecord.DRTNQty2;
                    worksheet.Cells[20, xx] = clientRecord.DRTNAmount2;
                    worksheet.Cells[21, x] = clientRecord.DRTNQty3;
                    worksheet.Cells[21, xx] = clientRecord.DRTNAmount3;
                    worksheet.Cells[22, x] = clientRecord.DRTNQty4;
                    worksheet.Cells[22, xx] = clientRecord.DRTNAmount4;

                    worksheet.Cells[25, x] = clientRecord.MDQty1;
                    worksheet.Cells[25, xx] = clientRecord.MDAmount1;
                    worksheet.Cells[26, x] = clientRecord.MDQty2;
                    worksheet.Cells[26, xx] = clientRecord.MDAmount2;
                    worksheet.Cells[27, x] = clientRecord.MDQty3;
                    worksheet.Cells[27, xx] = clientRecord.MDAmount3;
                    worksheet.Cells[28, x] = clientRecord.MDQty4;
                    worksheet.Cells[28, xx] = clientRecord.MDAmount4;
                    worksheet.Cells[29, x] = clientRecord.MDQty5;
                    worksheet.Cells[29, xx] = clientRecord.MDAmount5;
                    worksheet.Cells[30, x] = clientRecord.MDQty6;
                    worksheet.Cells[30, xx] = clientRecord.MDAmount6;

                    worksheet.Cells[33, x] = clientRecord.PRQty1;
                    worksheet.Cells[33, xx] = clientRecord.PRAmount1;
                    worksheet.Cells[34, x] = clientRecord.PRQty2;
                    worksheet.Cells[34, xx] = clientRecord.PRAmount2;
                    worksheet.Cells[35, x] = clientRecord.PRQty3;
                    worksheet.Cells[35, xx] = clientRecord.PRAmount3;

                    worksheet.Cells[38, x] = clientRecord.ATQty1;
                    worksheet.Cells[38, xx] = clientRecord.ATAmount1;
                    worksheet.Cells[39, x] = clientRecord.ATQty2;
                    worksheet.Cells[39, xx] = clientRecord.ATAmount2;

                    worksheet.Cells[40, xx] = clientRecord.Total;

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
