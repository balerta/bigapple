using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigapple
{
    public partial class TherapistReport : UserControl
    {
        public TherapistReport()
        {
            InitializeComponent();
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            if (TherapistListCB.Text == "")
            {
                MessageBox.Show("Please select a Therapist to generate a report.", "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Save Therapist Sales Report as PDF",
                FileName = "BigApple_TherapistSalesReport_" + TherapistListCB.Text + "_" + DateTime.Now.ToString("yyyyMMdd"),
                DefaultExt = "pdf",
                AddExtension = true,
                Filter = "PDF (*.pdf)|*.pdf"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Therapist Sales Report created in " + saveFile.FileName, "Therapist Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
