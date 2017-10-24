namespace IMS.UI
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSNSACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billOfSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseChargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(836, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "MainMenu";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDetailsToolStripMenuItem,
            this.companyTypeToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.itemTypeToolStripMenuItem,
            this.itemUnitToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.customerTypeToolStripMenuItem,
            this.hSNSACToolStripMenuItem,
            this.invoiceTypeToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // companyDetailsToolStripMenuItem
            // 
            this.companyDetailsToolStripMenuItem.Name = "companyDetailsToolStripMenuItem";
            this.companyDetailsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.companyDetailsToolStripMenuItem.Text = "Company";
            this.companyDetailsToolStripMenuItem.Click += new System.EventHandler(this.companyDetailsToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // companyTypeToolStripMenuItem
            // 
            this.companyTypeToolStripMenuItem.Name = "companyTypeToolStripMenuItem";
            this.companyTypeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.companyTypeToolStripMenuItem.Text = "Company Type";
            // 
            // itemTypeToolStripMenuItem
            // 
            this.itemTypeToolStripMenuItem.Name = "itemTypeToolStripMenuItem";
            this.itemTypeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.itemTypeToolStripMenuItem.Text = "Item Type";
            // 
            // customerTypeToolStripMenuItem
            // 
            this.customerTypeToolStripMenuItem.Name = "customerTypeToolStripMenuItem";
            this.customerTypeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.customerTypeToolStripMenuItem.Text = "Customer Type";
            // 
            // itemUnitToolStripMenuItem
            // 
            this.itemUnitToolStripMenuItem.Name = "itemUnitToolStripMenuItem";
            this.itemUnitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.itemUnitToolStripMenuItem.Text = "Item Unit";
            // 
            // hSNSACToolStripMenuItem
            // 
            this.hSNSACToolStripMenuItem.Name = "hSNSACToolStripMenuItem";
            this.hSNSACToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hSNSACToolStripMenuItem.Text = "HSN SAC";
            // 
            // invoiceTypeToolStripMenuItem
            // 
            this.invoiceTypeToolStripMenuItem.Name = "invoiceTypeToolStripMenuItem";
            this.invoiceTypeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.invoiceTypeToolStripMenuItem.Text = "Invoice Type";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesInvoiceToolStripMenuItem,
            this.exportSaleToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseInvoiceToolStripMenuItem,
            this.billOfSupplyToolStripMenuItem,
            this.reverseChargeToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            // 
            // billOfSupplyToolStripMenuItem
            // 
            this.billOfSupplyToolStripMenuItem.Name = "billOfSupplyToolStripMenuItem";
            this.billOfSupplyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.billOfSupplyToolStripMenuItem.Text = "Bill of Supply";
            // 
            // reverseChargeToolStripMenuItem
            // 
            this.reverseChargeToolStripMenuItem.Name = "reverseChargeToolStripMenuItem";
            this.reverseChargeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reverseChargeToolStripMenuItem.Text = "Reverse Charge";
            // 
            // salesInvoiceToolStripMenuItem
            // 
            this.salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            this.salesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesInvoiceToolStripMenuItem.Text = "Sales Invoice";
            // 
            // exportSaleToolStripMenuItem
            // 
            this.exportSaleToolStripMenuItem.Name = "exportSaleToolStripMenuItem";
            this.exportSaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportSaleToolStripMenuItem.Text = "Export Sale";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 410);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSNSACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billOfSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseChargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}