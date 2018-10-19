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
            dailySales = DatabaseClass.LoadDailySalesClientRecord(DateTime.Now.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty1);
            }
            return total.ToString();
        }
  
        private string MEQty2()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(DateTime.Now.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty2);
            }
            return total.ToString();
        }
        private string MEQty3()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(DateTime.Now.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEQty3);
            }
            return total.ToString();
        }

        // Amount
        private string MEAmount1()
        {
            int total = 0;
            dailySales = DatabaseClass.LoadDailySalesClientRecord(DateTime.Now.ToString("MM/dd/yyyy"));
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
            dailySales = DatabaseClass.LoadDailySalesClientRecord(DateTime.Now.ToString("MM/dd/yyyy"));
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
            dailySales = DatabaseClass.LoadDailySalesClientRecord(DateTime.Now.ToString("MM/dd/yyyy"));
            foreach (var dSales in dailySales)
            {
                total += Int32.Parse(dSales.MEAmount3);
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
