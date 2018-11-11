using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bigapplelib;

namespace bigapple
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get
            {
                return this.lblSeriesNumber.Text;
            }
            set
            {
                this.lblSeriesNumber.Text = value;
            }
        }

        private void btnVoidSale_MouseClick(object sender, MouseEventArgs e)
        {
            if (Environment.GetEnvironmentVariable("BAES", EnvironmentVariableTarget.User) == null)
            {
                MessageBox.Show("Admin Password is not yet setup. Please setup an Admin Password to Void Sales and try again.", "Void Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            if (txtPassword.Text == Environment.GetEnvironmentVariable("BAES", EnvironmentVariableTarget.User))
            {

                VoidModel voidModel = new VoidModel
                {
                    SeriesNumber = lblSeriesNumber.Text,
                    Void = "TRUE"
                };

                DatabaseClass.UpdateVoidSaleRecord(voidModel);
                MessageBox.Show("Series Number '" + lblSeriesNumber.Text + " is successfully voided.", "Void Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Admin Password.", "Void Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
