using bigapplelib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigapple
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            clientReceiptControl1.Visible = false;
            dailySalesReportControl1.Visible = false;
            therapistReport1.Visible = false;
            voidSaleControl1.Visible = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeBtn.Height;
            SidePanel.Top = HomeBtn.Top;
            clientReceiptControl1.Visible = false;
            dailySalesReportControl1.Visible = false;
            therapistReport1.Visible = false;
            voidSaleControl1.Visible = false;
        }

        private void CRBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CRBtn.Height;
            SidePanel.Top = CRBtn.Top;
            clientReceiptControl1.Visible = true;
            dailySalesReportControl1.Visible = false;
            therapistReport1.Visible = false;
            voidSaleControl1.Visible = false;
        }

        private void DSRBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = DSRBtn.Height;
            SidePanel.Top = DSRBtn.Top;
            clientReceiptControl1.Visible = false;
            dailySalesReportControl1.Visible = true;
            therapistReport1.Visible = false;
            voidSaleControl1.Visible = false;
        }

        private void TSRBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = TSRBtn.Height;
            SidePanel.Top = TSRBtn.Top;
            clientReceiptControl1.Visible = false;
            dailySalesReportControl1.Visible = false;
            therapistReport1.Visible = true;
            voidSaleControl1.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void VoidSalesBTN_Click(object sender, EventArgs e)
        {
            SidePanel.Height = VoidSalesBTN.Height;
            SidePanel.Top = VoidSalesBTN.Top;
            clientReceiptControl1.Visible = false;
            dailySalesReportControl1.Visible = false;
            therapistReport1.Visible = false;
            voidSaleControl1.Visible = true;
            voidSaleControl1.LoadVoidModeRecord();
        }
    }
}
