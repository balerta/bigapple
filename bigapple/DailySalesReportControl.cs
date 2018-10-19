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
    public partial class DailySalesReportControl : UserControl
    {
        List<DailySalesClientModel> dailySales = new List<DailySalesClientModel>();
        int TotalAmount = 0;
        public DailySalesReportControl()
        {
            InitializeComponent();
        }

        // Quantity
        private string MEQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty1);
            }
            return total.ToString();
        }
  
        private string MEQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty2);
            }
            return total.ToString();
        }
        private string MEQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty3);
            }
            return total.ToString();
        }
        private string UNMWQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWQty1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string UNMWQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWQty2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPQty4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPQty4);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNQty4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNQty4);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDQty4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty4);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDQty5()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty5);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDQty6()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDQty6);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string PRQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRQty1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string PRQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRQty2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string PRQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRQty3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string ATQty1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATQty1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string ATQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATQty2);
            }
            TotalAmount += total;
            return total.ToString();
        }


        // Amount
        private string MEAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }

        private string MEAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MEAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string UNMWAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string UNMWAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.UNMWAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string NYFPAmount4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.NYFPAmount4);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string DRTNAmount4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.DRTNAmount4);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDAmount4()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount4);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDAmount5()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount5);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string MDAmount6()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MDAmount6);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string PRAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string PRAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string PRAmount3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.PRAmount3);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string ATAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATAmount1);
            }
            TotalAmount += total;
            return total.ToString();
        }
        private string ATAmount2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(dateTimePicker1.Value.Date.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.ATAmount2);
            }
            TotalAmount += total;
            return total.ToString();
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Daily Sales Report as PDF",
                FileName = "BigApple_DailySalesReport_" + DateTime.Now.ToString("yyyyMMdd"),
                DefaultExt = "pdf",
                AddExtension = true,
                Filter = "PDF (*.pdf)|*.pdf"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(saveFile.FileName, FileMode.Create));
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 9);
                document.Open();
                PdfPCell cell = new PdfPCell(new Phrase("Big Apple Daily Sales Report " + DateTime.Now.ToString("MM/dd/yyyy"), font))
                {
                    Colspan = 4,
                    HorizontalAlignment = 1
                };

                PdfPTable table = new PdfPTable(4);
                table.AddCell(cell);
                // Manhattan
                table.AddCell("");
                table.AddCell(new PdfPCell(new Phrase("Price", font)));
                table.AddCell(new PdfPCell(new Phrase("Quantity", font)));
                table.AddCell(new PdfPCell(new Phrase("Amount", font)));
                table.AddCell(new PdfPCell(new Phrase("Manhattan Experience:", font)));
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");
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

                // Total
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");
                table.AddCell(new PdfPCell(new Phrase(TotalAmount.ToString(), font)));

                // Blank
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");

                // Tabulation
                table.AddCell(new PdfPCell(new Phrase("10:00 AM to 01:00 PM", font)));
                table.AddCell(new PdfPCell(new Phrase("Number of Series: 0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase("01:01 PM to 05:00 PM", font)));
                table.AddCell(new PdfPCell(new Phrase("Number of Series: 0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase("05:01 PM to 09:00 PM", font)));
                table.AddCell(new PdfPCell(new Phrase("Number of Series: 0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));

                document.Add(table);
                document.Close();

                MessageBox.Show("Daily Sales Report created in " + saveFile.FileName, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Daily Sales Report as Microsoft Excel",
                FileName = "BigApple_DailySalesReport_" + DateTime.Now.ToString("yyyyMMdd"),
                DefaultExt = "xlsx",
                AddExtension = true,
                Filter = "Microsoft Excel (*.xlsx )|*.xlsx"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Daily Sales Report created in " + saveFile.FileName, "Daily Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
