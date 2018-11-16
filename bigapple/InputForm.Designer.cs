namespace bigapple
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.lblSeriesNumberInfo = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeriesNumberInfo2 = new System.Windows.Forms.Label();
            this.btnVoidSale = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeriesNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeriesNumberInfo
            // 
            this.lblSeriesNumberInfo.AutoSize = true;
            this.lblSeriesNumberInfo.Location = new System.Drawing.Point(13, 13);
            this.lblSeriesNumberInfo.Name = "lblSeriesNumberInfo";
            this.lblSeriesNumberInfo.Size = new System.Drawing.Size(196, 18);
            this.lblSeriesNumberInfo.TabIndex = 0;
            this.lblSeriesNumberInfo.Text = "Please enter Admin Password,";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(363, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Password:";
            // 
            // lblSeriesNumberInfo2
            // 
            this.lblSeriesNumberInfo2.AutoSize = true;
            this.lblSeriesNumberInfo2.Location = new System.Drawing.Point(12, 31);
            this.lblSeriesNumberInfo2.Name = "lblSeriesNumberInfo2";
            this.lblSeriesNumberInfo2.Size = new System.Drawing.Size(224, 18);
            this.lblSeriesNumberInfo2.TabIndex = 3;
            this.lblSeriesNumberInfo2.Text = "To Void Sale with Series Number of";
            // 
            // btnVoidSale
            // 
            this.btnVoidSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnVoidSale.FlatAppearance.BorderSize = 0;
            this.btnVoidSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoidSale.ForeColor = System.Drawing.Color.White;
            this.btnVoidSale.Image = ((System.Drawing.Image)(resources.GetObject("btnVoidSale.Image")));
            this.btnVoidSale.Location = new System.Drawing.Point(26, 99);
            this.btnVoidSale.Name = "btnVoidSale";
            this.btnVoidSale.Size = new System.Drawing.Size(471, 65);
            this.btnVoidSale.TabIndex = 11;
            this.btnVoidSale.Text = "Void Sale";
            this.btnVoidSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoidSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoidSale.UseVisualStyleBackColor = false;
            this.btnVoidSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVoidSale_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 65);
            this.panel1.TabIndex = 10;
            // 
            // lblSeriesNumber
            // 
            this.lblSeriesNumber.AutoSize = true;
            this.lblSeriesNumber.Location = new System.Drawing.Point(233, 31);
            this.lblSeriesNumber.Name = "lblSeriesNumber";
            this.lblSeriesNumber.Size = new System.Drawing.Size(46, 18);
            this.lblSeriesNumber.TabIndex = 12;
            this.lblSeriesNumber.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Voiding Sales can\'t be undone.";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeriesNumber);
            this.Controls.Add(this.btnVoidSale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSeriesNumberInfo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSeriesNumberInfo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ika\'s Wellness Spa - Enter Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeriesNumberInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeriesNumberInfo2;
        private System.Windows.Forms.Button btnVoidSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeriesNumber;
        private System.Windows.Forms.Label label2;
    }
}