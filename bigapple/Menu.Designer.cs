﻿namespace bigapple
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TSRBtn = new System.Windows.Forms.Button();
            this.DSRBtn = new System.Windows.Forms.Button();
            this.CRBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bigAppleDataSet = new bigapple.BigAppleDataSet();
            this.dailySalesReportControl1 = new bigapple.DailySalesReportControl();
            this.clientReceiptControl1 = new bigapple.ClientReceiptControl();
            this.recordControl1 = new bigapple.RecordControl();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigAppleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoSize = true;
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LeftPanel.CausesValidation = false;
            this.LeftPanel.Controls.Add(this.TSRBtn);
            this.LeftPanel.Controls.Add(this.DSRBtn);
            this.LeftPanel.Controls.Add(this.CRBtn);
            this.LeftPanel.Controls.Add(this.HomeBtn);
            this.LeftPanel.Controls.Add(this.SidePanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(299, 861);
            this.LeftPanel.TabIndex = 0;
            // 
            // TSRBtn
            // 
            this.TSRBtn.FlatAppearance.BorderSize = 0;
            this.TSRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSRBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSRBtn.ForeColor = System.Drawing.Color.White;
            this.TSRBtn.Image = ((System.Drawing.Image)(resources.GetObject("TSRBtn.Image")));
            this.TSRBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSRBtn.Location = new System.Drawing.Point(12, 419);
            this.TSRBtn.Name = "TSRBtn";
            this.TSRBtn.Size = new System.Drawing.Size(284, 65);
            this.TSRBtn.TabIndex = 5;
            this.TSRBtn.Text = "Therapist Sales Report";
            this.TSRBtn.UseVisualStyleBackColor = true;
            this.TSRBtn.Click += new System.EventHandler(this.TSRBtn_Click);
            // 
            // DSRBtn
            // 
            this.DSRBtn.FlatAppearance.BorderSize = 0;
            this.DSRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSRBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSRBtn.ForeColor = System.Drawing.Color.White;
            this.DSRBtn.Image = ((System.Drawing.Image)(resources.GetObject("DSRBtn.Image")));
            this.DSRBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DSRBtn.Location = new System.Drawing.Point(12, 348);
            this.DSRBtn.Name = "DSRBtn";
            this.DSRBtn.Size = new System.Drawing.Size(284, 65);
            this.DSRBtn.TabIndex = 2;
            this.DSRBtn.Text = "Daily Sales Report";
            this.DSRBtn.UseVisualStyleBackColor = true;
            this.DSRBtn.Click += new System.EventHandler(this.DSRBtn_Click);
            // 
            // CRBtn
            // 
            this.CRBtn.FlatAppearance.BorderSize = 0;
            this.CRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CRBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRBtn.ForeColor = System.Drawing.Color.White;
            this.CRBtn.Image = ((System.Drawing.Image)(resources.GetObject("CRBtn.Image")));
            this.CRBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CRBtn.Location = new System.Drawing.Point(12, 277);
            this.CRBtn.Name = "CRBtn";
            this.CRBtn.Size = new System.Drawing.Size(284, 65);
            this.CRBtn.TabIndex = 1;
            this.CRBtn.Text = "Client Receipt";
            this.CRBtn.UseVisualStyleBackColor = true;
            this.CRBtn.Click += new System.EventHandler(this.CRBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(12, 206);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(284, 65);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Menu";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 206);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(26, 65);
            this.SidePanel.TabIndex = 4;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(299, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1285, 22);
            this.TopPanel.TabIndex = 1;
            // 
            // bigAppleDataSet
            // 
            this.bigAppleDataSet.DataSetName = "BigAppleDataSet";
            this.bigAppleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailySalesReportControl1
            // 
            this.dailySalesReportControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailySalesReportControl1.Location = new System.Drawing.Point(299, 25);
            this.dailySalesReportControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dailySalesReportControl1.Name = "dailySalesReportControl1";
            this.dailySalesReportControl1.Size = new System.Drawing.Size(680, 240);
            this.dailySalesReportControl1.TabIndex = 3;
            this.dailySalesReportControl1.Visible = false;
            // 
            // clientReceiptControl1
            // 
            this.clientReceiptControl1.AutoScroll = true;
            this.clientReceiptControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientReceiptControl1.Location = new System.Drawing.Point(299, 25);
            this.clientReceiptControl1.Margin = new System.Windows.Forms.Padding(4);
            this.clientReceiptControl1.Name = "clientReceiptControl1";
            this.clientReceiptControl1.Size = new System.Drawing.Size(1174, 840);
            this.clientReceiptControl1.TabIndex = 2;
            this.clientReceiptControl1.Visible = false;
            // 
            // recordControl1
            // 
            this.recordControl1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.recordControl1.Location = new System.Drawing.Point(299, 25);
            this.recordControl1.Margin = new System.Windows.Forms.Padding(4);
            this.recordControl1.Name = "recordControl1";
            this.recordControl1.Size = new System.Drawing.Size(887, 403);
            this.recordControl1.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.recordControl1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.dailySalesReportControl1);
            this.Controls.Add(this.clientReceiptControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Apple Express Spa";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bigAppleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button DSRBtn;
        private System.Windows.Forms.Button CRBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button TSRBtn;
        private System.Windows.Forms.Panel TopPanel;
        private ClientReceiptControl clientReceiptControl1;
        private DailySalesReportControl dailySalesReportControl1;
        private System.Windows.Forms.Timer timer1;
        private BigAppleDataSet bigAppleDataSet;
        private RecordControl recordControl1;
    }
}

