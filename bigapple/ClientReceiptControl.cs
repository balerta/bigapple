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
        public int MEAmount1;
        public int MEAmount2;
        public int MEAmount3;
        public int UNMWAmount1;
        public int UNMWAmount2;
        public int NYFDAmount1;
        public int NYFDAmount2;
        public int NYFDAmount3;
        public int NYFDAmount4;
        public int DRTNAmount1;
        public int DRTNAmount2;
        public int DRTNAmount3;
        public int DRTNAmount4;
        public int MDAmount3;
        public int MDAmount4;
        public int MDAmount5;
        public int MDAmount6;
        public int PRAmount3;
        public int ATAmount1;
        public int ATAmount2;

        public ClientReceiptControl()
        {
            InitializeComponent();
            MEAmount1 = 0;
            MEAmount2 = 0;
            MEAmount3 = 0;
            UNMWAmount1 = 0;
            UNMWAmount2 = 0;
            NYFDAmount1 = 0;
            NYFDAmount2 = 0;
            NYFDAmount3 = 0;
            NYFDAmount4 = 0;
            DRTNAmount1 = 0;
            DRTNAmount2 = 0;
            DRTNAmount3 = 0;
            DRTNAmount4 = 0;
            MDAmount3 = 0;
            MDAmount4 = 0;
            MDAmount5 = 0;
            MDAmount6 = 0;
            PRAmount3 = 0;
            ATAmount1 = 0;
            ATAmount2 = 0;
        }

        private void ClientReceiptControl_Load(object sender, EventArgs e)
        {
            NameOfClientTXT.Focus();
            SCNoRB.Select();
        }
        
        private static int Calculate_Amount(int Amount, MaskedTextBox maskedTextBoxQuantity, Label labelPrice, Label labelAmount)
        {
            if (int.TryParse(labelPrice.Text, out int Price) && int.TryParse(maskedTextBoxQuantity.Text, out int Quantity))
            {
                Amount = Price * Quantity;
            }
            else
            {
                Amount = 0;
                maskedTextBoxQuantity.Text = Amount.ToString();
            }
            labelAmount.Text = Amount.ToString();
            return Amount;
        }

        private void AmountCollectible()
        {
            if (SCYesRB.Checked == true)
            {
                CalculateTotalAmountDueWithSC();
            }

            if (SCNoRB.Checked == true)
            {
                CalculateTotalAmountDue();
            }
        }

        private void CalculateTotalAmountDue()
        {
            int tad;
            tad = MEAmount1 + MEAmount2 + MEAmount3 + UNMWAmount1 + UNMWAmount2 +
                NYFDAmount1 + NYFDAmount2 + NYFDAmount3 + NYFDAmount4 +
                DRTNAmount1 + DRTNAmount2 + DRTNAmount3 + DRTNAmount4 +
                MDAmount3 + MDAmount4 + MDAmount5 + MDAmount6 +
                PRAmount3 + ATAmount1 + ATAmount2;

            double netvat = (double)tad / 1.12;
            double vat = netvat * 0.12;
            double scd = 0.00;
            double discount = (netvat + vat) - scd;

            float floatNetOfVAT = float.Parse(Math.Round(netvat, 2).ToString());
            float floatVAT = float.Parse(Math.Round(vat, 2).ToString());
            float floatSCD = float.Parse(Math.Round(scd, 2).ToString());
            float floatDiscount = float.Parse(Math.Round(discount, 2).ToString());

            TotalLBL.Text = tad.ToString();
            NetOfVATLBL.Text = floatNetOfVAT.ToString();
            VatLBL.Text = floatVAT.ToString();
            SeniorCDiscountLBL.Text = floatSCD.ToString();
            TotalAmountDLBL.Text = floatDiscount.ToString();
        }

        private void CalculateTotalAmountDueWithSC()
        {
            int tad;
            tad = MEAmount1 + MEAmount2 + MEAmount3 + UNMWAmount1 + UNMWAmount2 +
                NYFDAmount1 + NYFDAmount2 + NYFDAmount3 + NYFDAmount4 +
                DRTNAmount1 + DRTNAmount2 + DRTNAmount3 + DRTNAmount4 +
                MDAmount3 + MDAmount4 + MDAmount5 + MDAmount6 +
                PRAmount3 + ATAmount1 + ATAmount2;

            double netvat = (double)tad / 1.12;
            double vat = netvat * 0.12;
            double scd = netvat * 0.20;
            double discount = (netvat + vat) - scd;

            float floatNetOfVAT = float.Parse(Math.Round(netvat, 2).ToString());
            float floatVAT = float.Parse(Math.Round(vat, 2).ToString());
            float floatSCD = float.Parse(Math.Round(scd, 2).ToString());
            float floatDiscount = float.Parse(Math.Round(discount, 2).ToString());

            TotalLBL.Text = tad.ToString();
            NetOfVATLBL.Text = floatNetOfVAT.ToString();
            VatLBL.Text = floatVAT.ToString();
            SeniorCDiscountLBL.Text = floatSCD.ToString();
            TotalAmountDLBL.Text = floatDiscount.ToString();
        }

        private void MaskedTextBox_GotFocus(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            if (sender == null)
            {
                return;
            }
            maskedTextBox.SelectAll();
        }

        private void CRCTimer_Tick(object sender, EventArgs e)
        {
            TimeLBL.Text = DateTime.Now.ToString("hh:mm tt");
            DateLBL.Text = DateTime.Now.ToString("MM/dd/yyyy");
            SeriesNumberLBL.Text = DateTime.Now.ToString("yyyyMMdd");
        }

        private void MEQtyMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            MEAmount1 = Calculate_Amount(MEAmount1, MEQtyMaskedTextBox1, MEPrice1LBL, MEAmount1LBL);
            AmountCollectible();
        }

        private void MEQtyMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            MEAmount2 = Calculate_Amount(MEAmount2, MEQtyMaskedTextBox2, MEPrice2LBL, MEAmount2LBL);
            AmountCollectible();
        }

        private void MEQtyMaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            MEAmount3 = Calculate_Amount(MEAmount3, MEQtyMaskedTextBox3, MEPrice3LBL, MEAmount3LBL);
            AmountCollectible();
        }

        private void UNMWQtyMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            UNMWAmount1 = Calculate_Amount(UNMWAmount1, UNMWQtyMaskedTextBox1, UNMWPrice1LBL, UNMWAmount1LBL);
            AmountCollectible();

        }

        private void UNMWQtyMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            UNMWAmount2 = Calculate_Amount(UNMWAmount2, UNMWQtyMaskedTextBox2, UNMWPrice2LBL, UNMWAmount2LBL);
            AmountCollectible();

        }

        private void NYFDQtyMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            NYFDAmount1 = Calculate_Amount(NYFDAmount1, NYFDQtyMaskedTextBox1, NYFDPrice1LBL, NYFDAmount1LBL);
            AmountCollectible();
        }

        private void NYFDQtyMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            NYFDAmount2 = Calculate_Amount(NYFDAmount2, NYFDQtyMaskedTextBox2, NYFDPrice2LBL, NYFDAmount2LBL);
            AmountCollectible();
        }

        private void NYFDQtyMaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            NYFDAmount3 = Calculate_Amount(NYFDAmount3, NYFDQtyMaskedTextBox3, NYFDPrice3LBL, NYFDAmount3LBL);
            AmountCollectible();
        }

        private void NYFDQtyMaskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            NYFDAmount4 = Calculate_Amount(NYFDAmount4, NYFDQtyMaskedTextBox4, NYFDPrice4LBL, NYFDAmount4LBL);
            AmountCollectible();
        }

        private void DRTNQtyMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            DRTNAmount1 = Calculate_Amount(DRTNAmount1, DRTNQtyMaskedTextBox1, DRTNPrice1LBL, DRTNAmount1LBL);
            AmountCollectible();
        }

        private void DRTNQtyMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            DRTNAmount2 = Calculate_Amount(DRTNAmount2, DRTNQtyMaskedTextBox2, DRTNPrice2LBL, DRTNAmount2LBL);
            AmountCollectible();
        }

        private void DRTNQtyMaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            DRTNAmount3 = Calculate_Amount(DRTNAmount3, DRTNQtyMaskedTextBox3, DRTNPrice3LBL, DRTNAmount3LBL);
            AmountCollectible();
        }

        private void DRTNQtyMaskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            DRTNAmount4 = Calculate_Amount(DRTNAmount4, DRTNQtyMaskedTextBox4, DRTNPrice4LBL, DRTNAmount4LBL);
            AmountCollectible();
        }

        private void MDQtyMaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            MDAmount3 = Calculate_Amount(MDAmount3, MDQtyMaskedTextBox3, MDPrice3LBL, MDAmount3LBL);
            AmountCollectible();
        }

        private void MDQtyMaskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            MDAmount4 = Calculate_Amount(MDAmount4, MDQtyMaskedTextBox4, MDPrice4LBL, MDAmount4LBL);
            AmountCollectible();
        }

        private void MDQtyMaskedTextBox5_TextChanged(object sender, EventArgs e)
        {
            MDAmount5 = Calculate_Amount(MDAmount5, MDQtyMaskedTextBox5, MDPrice5LBL, MDAmount5LBL);
            AmountCollectible();
        }

        private void MDQtyMaskedTextBox6_TextChanged(object sender, EventArgs e)
        {
            MDAmount6 = Calculate_Amount(MDAmount6, MDQtyMaskedTextBox6, MDPrice6LBL, MDAmount6LBL);
            AmountCollectible();
        }

        private void PRQtyMaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            PRAmount3 = Calculate_Amount(PRAmount3, PRQtyMaskedTextBox3, PRPrice3LBL, PRAmount3LBL);
            AmountCollectible();
        }

        private void ATQtyMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            ATAmount1 = Calculate_Amount(ATAmount1, ATQtyMaskedTextBox1, ATPrice1LBL, ATAmount1LBL);
            AmountCollectible();
        }

        private void ATQtyMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            ATAmount2 = Calculate_Amount(ATAmount2, ATQtyMaskedTextBox2, ATPrice2LBL, ATAmount2LBL);
            AmountCollectible();
        }

        private void SCYesRB_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmountDueWithSC();
        }

        private void SCNoRB_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalAmountDue();
        }

        private void CalculateDataOKBTN_Click(object sender, EventArgs e)
        {

        }
    }
}