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
    public partial class ClientReceiptControl : UserControl
    {
        public ClientReceiptControl()
        {
            InitializeComponent();
        }

        private void CRCTimer_Tick(object sender, EventArgs e)
        {
            TimeLBL.Text = DateTime.Now.ToString("hh:mm tt");
            DateLBL.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
    }
}
