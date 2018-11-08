using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bigapplelib;
namespace bigapple
{
    public partial class VoidSaleControl : UserControl
    {
        public VoidSaleControl()
        {
            InitializeComponent();
            LoadVoidModeRecord();
        }

        public void LoadVoidModeRecord()
        {
            dataGridView1.DataSource = DatabaseClass.LoadVoidModelRecord();
            dataGridView1.ClearSelection();
            lblSeriesNumber.Text = "";
            lblName.Text = "";
            lblTherapistAssigned.Text = "";
            lblDate.Text = "";
            lblTime.Text = "";
            lblTotalAmountDue.Text = "";
            btnVoidSale.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnVoidSale.Enabled = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lblSeriesNumber.Text = row.Cells[0].Value.ToString();
                lblName.Text = row.Cells[1].Value.ToString();
                lblTherapistAssigned.Text = row.Cells[2].Value.ToString();
                lblDate.Text = row.Cells[3].Value.ToString();
                lblTime.Text = row.Cells[4].Value.ToString();
                lblTotalAmountDue.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnVoidSale_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.LabelText = lblSeriesNumber.Text;
            inputForm.ShowDialog(this);
            LoadVoidModeRecord();
        }
    }
}
