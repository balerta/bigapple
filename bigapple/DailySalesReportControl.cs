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

namespace bigapple
{
    public partial class DailySalesReportControl : UserControl
    {
        public DailySalesReportControl()
        {
            InitializeComponent();
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
                table.AddCell(new PdfPCell(new Phrase("NYC Exp full body 30 mins", font)));
                table.AddCell(new PdfPCell(new Phrase("195", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));
                table.AddCell(new PdfPCell(new Phrase("0", font)));

                // Total
                table.AddCell("");
                table.AddCell("");
                table.AddCell("");
                table.AddCell(new PdfPCell(new Phrase("0", font)));

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
