namespace BillingSoft.Themes
{
    partial class ThemeTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeTwo));
            this.paneltop = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelrole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelright = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSellingPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.paneltop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelright.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.paneltop.Controls.Add(this.labeltitle);
            this.paneltop.Controls.Add(this.panel1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1394, 100);
            this.paneltop.TabIndex = 0;
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(679, 30);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(168, 37);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.labelrole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrole.ForeColor = System.Drawing.Color.Gold;
            this.labelrole.Location = new System.Drawing.Point(82, 42);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(0, 23);
            this.labelrole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelright.Controls.Add(this.menuStrip1);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelright.Location = new System.Drawing.Point(0, 100);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(293, 590);
            this.panelright.TabIndex = 1;
            this.panelright.Paint += new System.Windows.Forms.PaintEventHandler(this.panelright_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.manageProductToolStripMenuItem,
            this.sellPanelToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.databaseOptionToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 590);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dashboardToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.dashboard;
            this.dashboardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.viewProductToolStripMenuItem});
            this.manageProductToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageProductToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.product;
            this.manageProductToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.product;
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(282, 42);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // viewProductToolStripMenuItem
            // 
            this.viewProductToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.view;
            this.viewProductToolStripMenuItem.Name = "viewProductToolStripMenuItem";
            this.viewProductToolStripMenuItem.Size = new System.Drawing.Size(282, 42);
            this.viewProductToolStripMenuItem.Text = "View Product";
            this.viewProductToolStripMenuItem.Click += new System.EventHandler(this.viewProductToolStripMenuItem_Click);
            // 
            // sellPanelToolStripMenuItem
            // 
            this.sellPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productSellingPanelToolStripMenuItem,
            this.sellingHistoryToolStripMenuItem});
            this.sellPanelToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPanelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sellPanelToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.sell;
            this.sellPanelToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellPanelToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.sellPanelToolStripMenuItem.Name = "sellPanelToolStripMenuItem";
            this.sellPanelToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.sellPanelToolStripMenuItem.Text = "Sell Panel";
            // 
            // productSellingPanelToolStripMenuItem
            // 
            this.productSellingPanelToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.sellpanel;
            this.productSellingPanelToolStripMenuItem.Name = "productSellingPanelToolStripMenuItem";
            this.productSellingPanelToolStripMenuItem.Size = new System.Drawing.Size(376, 42);
            this.productSellingPanelToolStripMenuItem.Text = "Product Selling Panel";
            this.productSellingPanelToolStripMenuItem.Click += new System.EventHandler(this.productSellingPanelToolStripMenuItem_Click);
            // 
            // sellingHistoryToolStripMenuItem
            // 
            this.sellingHistoryToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.history;
            this.sellingHistoryToolStripMenuItem.Name = "sellingHistoryToolStripMenuItem";
            this.sellingHistoryToolStripMenuItem.Size = new System.Drawing.Size(376, 42);
            this.sellingHistoryToolStripMenuItem.Text = "Selling History";
            this.sellingHistoryToolStripMenuItem.Click += new System.EventHandler(this.sellingHistoryToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.expensesToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.expense;
            this.expensesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.expensesToolStripMenuItem.Text = "Expenses";
            this.expensesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // databaseOptionToolStripMenuItem
            // 
            this.databaseOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.databaseOptionToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseOptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.databaseOptionToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.database;
            this.databaseOptionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.databaseOptionToolStripMenuItem.Name = "databaseOptionToolStripMenuItem";
            this.databaseOptionToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.databaseOptionToolStripMenuItem.Text = "Database Option";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.backup;
            this.backupToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(212, 42);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.restore;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(212, 42);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.setting;
            this.settingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Image = global::BillingSoft.Properties.Resources.help;
            this.helpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(247, 37);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(293, 100);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1101, 590);
            this.mainpanel.TabIndex = 2;
            // 
            // ThemeTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1394, 690);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.paneltop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThemeTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Check_BAckup);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closed);
            this.Load += new System.EventHandler(this.ThemeTwo_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSellingPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelrole;
    }
}