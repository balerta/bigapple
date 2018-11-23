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
using System.IO;

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
        public int JAIAmount1;
        public int JAIAmount2;
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
            RefreshCBList();
            MEAmount1 = 0;
            MEAmount2 = 0;
            MEAmount3 = 0;
            UNMWAmount1 = 0;
            UNMWAmount2 = 0;
            NYFDAmount1 = 0;
            NYFDAmount2 = 0;
            NYFDAmount3 = 0;
            NYFDAmount4 = 0;
            JAIAmount1 = 0;
            JAIAmount2 = 0;
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
            RefreshClient();
        }

        public void RefreshCBList()
        {
            StreamReader reader = new StreamReader(@".\Therapist.txt");
            string x = reader.ReadToEnd();
            string[] y = x.Split('\n');
            foreach (string data in y)
            {
                data.Trim();
                TherapistListCB.Items.Add(data);
            }
        }

        private void RefreshClient()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            string id = DatabaseClass.ClientEntryPlusOne();
            SeriesNumberLBL.Text = date + id;
            NameOfClientTXT.Focus();
            NameOfClientTXT.Text = "";
            SCNoRB.Select();
            TherapistListCB.Text = "";
            MEQtyMaskedTextBox1.Text = "0";
            MEQtyMaskedTextBox2.Text = "0";
            MEQtyMaskedTextBox3.Text = "0";
            UNMWQtyMaskedTextBox1.Text = "0";
            UNMWQtyMaskedTextBox2.Text = "0";
            NYFDQtyMaskedTextBox1.Text = "0";
            NYFDQtyMaskedTextBox2.Text = "0";
            NYFDQtyMaskedTextBox3.Text = "0";
            NYFDQtyMaskedTextBox4.Text = "0";
            JAIQtyMaskedTextBox1.Text = "0";
            JAIQtyMaskedTextBox2.Text = "0";
            DRTNQtyMaskedTextBox1.Text = "0";
            DRTNQtyMaskedTextBox2.Text = "0";
            DRTNQtyMaskedTextBox3.Text = "0";
            DRTNQtyMaskedTextBox4.Text = "0";
            MDQtyMaskedTextBox1.Text = "0";
            MDQtyMaskedTextBox2.Text = "0";
            MDQtyMaskedTextBox3.Text = "0";
            MDQtyMaskedTextBox4.Text = "0";
            MDQtyMaskedTextBox5.Text = "0";
            MDQtyMaskedTextBox6.Text = "0";
            PRQtyMaskedTextBox1.Text = "0";
            PRQtyMaskedTextBox2.Text = "0";
            PRQtyMaskedTextBox3.Text = "0";
            ATQtyMaskedTextBox1.Text = "0";
            ATQtyMaskedTextBox2.Text = "0";
            TotalLBL.Text = "0";
            NetOfVATLBL.Text = "0";
            VatLBL.Text = "0";
            SeniorCDiscountLBL.Text = "0";
            TotalAmountDLBL.Text = "0";
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
                JAIAmount1 + JAIAmount2 +
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
                JAIAmount1 + JAIAmount2 +
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
            TimeLBL.Text = DateTime.Now.ToString("HH:mm");
            DateLBL.Text = DateTime.Now.ToString("MM/dd/yyyy");
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
            if (NameOfClientTXT.Text == "")
            {

                MessageBox.Show("Please enter a name.", "Client Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TherapistListCB.Text == "")
            {
                MessageBox.Show("Please assign a therapist.", "Client Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TotalLBL.Text == "0")
            {
                MessageBox.Show("Please select at least one(1) service.", "Client Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ClientRecordModel client = new ClientRecordModel
            {
                // Client Info
                SeriesNumber = SeriesNumberLBL.Text,
                NameOfClient = NameOfClientTXT.Text,
                TherapistAssigned = TherapistListCB.Text.Trim(),
                Date = DateLBL.Text,
                Time = TimeLBL.Text,
                SeniorCitizen = SCYesRB.Checked == true ? SCYesRB.Checked.ToString() : SCYesRB.Checked.ToString(),
                // Manhattan Experience
                MEQty1 = MEQtyMaskedTextBox1.Text,
                MEAmount1 = MEAmount1LBL.Text,
                MEQty2 = MEQtyMaskedTextBox2.Text,
                MEAmount2 = MEAmount2LBL.Text,
                MEQty3 = MEQtyMaskedTextBox3.Text,
                MEAmount3 = MEAmount3LBL.Text,
                // UN
                UNMWQty1 = UNMWQtyMaskedTextBox1.Text,
                UNMWAmount1 = UNMWAmount1LBL.Text,
                UNMWQty2 = UNMWQtyMaskedTextBox2.Text,
                UNMWAmount2 = UNMWAmount2LBL.Text,
                // NY
                NYFPQty1 = NYFDQtyMaskedTextBox1.Text,
                NYFPAmount1 = NYFDAmount1LBL.Text,
                NYFPQty2 = NYFDQtyMaskedTextBox2.Text,
                NYFPAmount2 = NYFDAmount2LBL.Text,
                NYFPQty3 = NYFDQtyMaskedTextBox3.Text,
                NYFPAmount3 = NYFDAmount3LBL.Text,
                NYFPQty4 = NYFDQtyMaskedTextBox4.Text,
                NYFPAmount4 = NYFDAmount4LBL.Text,
                // JAI
                JAIQty1 = JAIQtyMaskedTextBox1.Text,
                JAIAmount1 = JAIAmount1LBL.Text,
                JAIQty2 = JAIQtyMaskedTextBox2.Text,
                JAIAmount2 = JAIAmount2LBL.Text,
                // Duration
                DRTNQty1 = DRTNQtyMaskedTextBox1.Text,
                DRTNAmount1 = DRTNAmount1LBL.Text,
                DRTNQty2 = DRTNQtyMaskedTextBox2.Text,
                DRTNAmount2 = DRTNAmount2LBL.Text,
                DRTNQty3 = DRTNQtyMaskedTextBox3.Text,
                DRTNAmount3 = DRTNAmount3LBL.Text,
                DRTNQty4 = DRTNQtyMaskedTextBox4.Text,
                DRTNAmount4 = DRTNAmount4LBL.Text,
                // Medium
                MDQty1 = MDQtyMaskedTextBox1.Text,
                MDAmount1 = MDAmount1LBL.Text,
                MDQty2 = MDQtyMaskedTextBox2.Text,
                MDAmount2 = MDAmount2LBL.Text,
                MDQty3 = MDQtyMaskedTextBox3.Text,
                MDAmount3 = MDAmount3LBL.Text,
                MDQty4 = MDQtyMaskedTextBox4.Text,
                MDAmount4 = MDAmount4LBL.Text,
                MDQty5 = MDQtyMaskedTextBox5.Text,
                MDAmount5 = MDAmount5LBL.Text,
                MDQty6 = MDQtyMaskedTextBox6.Text,
                MDAmount6 = MDAmount6LBL.Text,
                // Pressure
                PRQty1 = PRQtyMaskedTextBox1.Text,
                PRAmount1 = PRAmount1LBL.Text,
                PRQty2 = PRQtyMaskedTextBox2.Text,
                PRAmount2 = PRAmount2LBL.Text,
                PRQty3 = PRQtyMaskedTextBox3.Text,
                PRAmount3 = PRAmount3LBL.Text,
                // Additional Time
                ATQty1 = ATQtyMaskedTextBox1.Text,
                ATAmount1 = ATAmount1LBL.Text,
                ATQty2 = ATQtyMaskedTextBox2.Text,
                ATAmount2 = ATAmount2LBL.Text,
                // Total
                Total = TotalLBL.Text,
                NetOfVAT = NetOfVATLBL.Text,
                VAT = VatLBL.Text,
                SeniorCitizenDiscount = SeniorCDiscountLBL.Text,
                TotalAmountDue = TotalAmountDLBL.Text,
                Void = "FALSE"
            };

            DatabaseClass.SaveClientRecord(client);
            MessageBox.Show("Client Name '" + NameOfClientTXT.Text + "' with Series Number '" + SeriesNumberLBL.Text + "' was successfully saved.", "Client Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshClient();
        }

        private void JAIQtyMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            JAIAmount1 = Calculate_Amount(JAIAmount1, JAIQtyMaskedTextBox1, JAIPrice1LBL, JAIAmount1LBL);
            AmountCollectible();
        }

        private void JAIQtyMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            JAIAmount2 = Calculate_Amount(JAIAmount2, JAIQtyMaskedTextBox2, JAIPrice2LBL, JAIAmount2LBL);
            AmountCollectible();
        }
    }
}