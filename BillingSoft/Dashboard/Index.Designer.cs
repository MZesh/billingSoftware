namespace BillingSoft.Dashboard
{
    partial class Index
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelfill = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labeltotalinvoices = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeltotalsellitems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltotalproduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewtotalProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewtotalsell = new System.Windows.Forms.DataGridView();
            this.dataGridViewunprint = new System.Windows.Forms.DataGridView();
            this.dataGridViewoutofstock = new System.Windows.Forms.DataGridView();
            this.panelleft = new System.Windows.Forms.Panel();
            this.paneloutofstock = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCreditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonhelp = new System.Windows.Forms.Button();
            this.timer_blink = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelfill.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtotalProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtotalsell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewunprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoutofstock)).BeginInit();
            this.panelleft.SuspendLayout();
            this.paneloutofstock.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelfill);
            this.panel1.Controls.Add(this.panelleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 785);
            this.panel1.TabIndex = 0;
            // 
            // panelfill
            // 
            this.panelfill.Controls.Add(this.panel4);
            this.panelfill.Controls.Add(this.panel7);
            this.panelfill.Controls.Add(this.chart1);
            this.panelfill.Controls.Add(this.dataGridViewtotalProduct);
            this.panelfill.Controls.Add(this.dataGridViewtotalsell);
            this.panelfill.Controls.Add(this.dataGridViewunprint);
            this.panelfill.Controls.Add(this.dataGridViewoutofstock);
            this.panelfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfill.Location = new System.Drawing.Point(368, 0);
            this.panelfill.Name = "panelfill";
            this.panelfill.Size = new System.Drawing.Size(1076, 785);
            this.panelfill.TabIndex = 1;
            this.panelfill.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfill_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Controls.Add(this.labeltotalinvoices);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.labeltotalsellitems);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.labeltotalproduct);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(51, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(916, 172);
            this.panel4.TabIndex = 2;
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart2.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(312, 0);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.Name = "TotalProduct";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.LabelBorderWidth = 0;
            series2.Legend = "Legend1";
            series2.Name = "DailySell";
            series2.ShadowColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.LabelBorderWidth = 0;
            series3.Legend = "Legend1";
            series3.Name = "UnprintInvoices";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(599, 171);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // labeltotalinvoices
            // 
            this.labeltotalinvoices.AutoSize = true;
            this.labeltotalinvoices.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalinvoices.Location = new System.Drawing.Point(241, 113);
            this.labeltotalinvoices.Name = "labeltotalinvoices";
            this.labeltotalinvoices.Size = new System.Drawing.Size(21, 23);
            this.labeltotalinvoices.TabIndex = 5;
            this.labeltotalinvoices.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total unpaid invoices : ";
            // 
            // labeltotalsellitems
            // 
            this.labeltotalsellitems.AutoSize = true;
            this.labeltotalsellitems.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalsellitems.Location = new System.Drawing.Point(189, 68);
            this.labeltotalsellitems.Name = "labeltotalsellitems";
            this.labeltotalsellitems.Size = new System.Drawing.Size(21, 23);
            this.labeltotalsellitems.TabIndex = 3;
            this.labeltotalsellitems.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daily sell Items : ";
            // 
            // labeltotalproduct
            // 
            this.labeltotalproduct.AutoSize = true;
            this.labeltotalproduct.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalproduct.Location = new System.Drawing.Point(189, 20);
            this.labeltotalproduct.Name = "labeltotalproduct";
            this.labeltotalproduct.Size = new System.Drawing.Size(21, 23);
            this.labeltotalproduct.TabIndex = 1;
            this.labeltotalproduct.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Product : ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 655);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1076, 130);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(887, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 64);
            this.panel6.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::BillingSoft.Properties.Resources.logout;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.MaximumSize = new System.Drawing.Size(309, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.Controls.Add(this.button6);
            this.panel9.Location = new System.Drawing.Point(502, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(309, 64);
            this.panel9.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::BillingSoft.Properties.Resources.creditor;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.MaximumSize = new System.Drawing.Size(309, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(309, 64);
            this.button6.TabIndex = 2;
            this.button6.Text = "All Times  Creditors";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.button5);
            this.panel8.Location = new System.Drawing.Point(32, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(309, 64);
            this.panel8.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::BillingSoft.Properties.Resources.summary;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.MaximumSize = new System.Drawing.Size(309, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(309, 64);
            this.button5.TabIndex = 2;
            this.button5.Text = "Business Summary";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 29);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Tomato;
            series4.CustomProperties = "IsXAxisQuantitative=False, EmptyPointValue=Zero";
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.LightSalmon;
            series4.Name = "Sales";
            series4.ShadowColor = System.Drawing.Color.Brown;
            series4.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Maroon;
            series4.ToolTip = "Selling Chart";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1058, 447);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridViewtotalProduct
            // 
            this.dataGridViewtotalProduct.AllowUserToAddRows = false;
            this.dataGridViewtotalProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(26)))));
            this.dataGridViewtotalProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtotalProduct.Location = new System.Drawing.Point(833, 185);
            this.dataGridViewtotalProduct.Name = "dataGridViewtotalProduct";
            this.dataGridViewtotalProduct.RowHeadersWidth = 62;
            this.dataGridViewtotalProduct.RowTemplate.Height = 28;
            this.dataGridViewtotalProduct.Size = new System.Drawing.Size(156, 154);
            this.dataGridViewtotalProduct.TabIndex = 11;
            this.dataGridViewtotalProduct.Visible = false;
            // 
            // dataGridViewtotalsell
            // 
            this.dataGridViewtotalsell.AllowUserToAddRows = false;
            this.dataGridViewtotalsell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtotalsell.Location = new System.Drawing.Point(783, 249);
            this.dataGridViewtotalsell.Name = "dataGridViewtotalsell";
            this.dataGridViewtotalsell.RowHeadersWidth = 62;
            this.dataGridViewtotalsell.RowTemplate.Height = 28;
            this.dataGridViewtotalsell.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewtotalsell.TabIndex = 9;
            this.dataGridViewtotalsell.Visible = false;
            // 
            // dataGridViewunprint
            // 
            this.dataGridViewunprint.AllowUserToAddRows = false;
            this.dataGridViewunprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewunprint.Location = new System.Drawing.Point(749, 271);
            this.dataGridViewunprint.Name = "dataGridViewunprint";
            this.dataGridViewunprint.RowHeadersWidth = 62;
            this.dataGridViewunprint.RowTemplate.Height = 28;
            this.dataGridViewunprint.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewunprint.TabIndex = 9;
            this.dataGridViewunprint.Visible = false;
            // 
            // dataGridViewoutofstock
            // 
            this.dataGridViewoutofstock.AllowUserToAddRows = false;
            this.dataGridViewoutofstock.AllowUserToDeleteRows = false;
            this.dataGridViewoutofstock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewoutofstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewoutofstock.Location = new System.Drawing.Point(502, 206);
            this.dataGridViewoutofstock.Name = "dataGridViewoutofstock";
            this.dataGridViewoutofstock.ReadOnly = true;
            this.dataGridViewoutofstock.RowHeadersWidth = 62;
            this.dataGridViewoutofstock.RowTemplate.Height = 28;
            this.dataGridViewoutofstock.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewoutofstock.TabIndex = 12;
            this.dataGridViewoutofstock.Visible = false;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(26)))));
            this.panelleft.Controls.Add(this.paneloutofstock);
            this.panelleft.Controls.Add(this.menuStrip1);
            this.panelleft.Controls.Add(this.panel5);
            this.panelleft.Controls.Add(this.panel3);
            this.panelleft.Controls.Add(this.panel2);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(368, 785);
            this.panelleft.TabIndex = 0;
            // 
            // paneloutofstock
            // 
            this.paneloutofstock.Controls.Add(this.button4);
            this.paneloutofstock.Location = new System.Drawing.Point(26, 39);
            this.paneloutofstock.Name = "paneloutofstock";
            this.paneloutofstock.Size = new System.Drawing.Size(309, 58);
            this.paneloutofstock.TabIndex = 5;
            this.paneloutofstock.Visible = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(22)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = global::BillingSoft.Properties.Resources.war;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.MaximumSize = new System.Drawing.Size(309, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(309, 58);
            this.button4.TabIndex = 2;
            this.button4.Text = "   Out Of Stock Item";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.Start_Blink);
            this.button4.MouseHover += new System.EventHandler(this.Stop_Blinking);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 749);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditorsToolStripMenuItem
            // 
            this.creditorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditorReportToolStripMenuItem,
            this.addNewCreditorToolStripMenuItem,
            this.makePaymentToolStripMenuItem});
            this.creditorsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditorsToolStripMenuItem.Name = "creditorsToolStripMenuItem";
            this.creditorsToolStripMenuItem.Size = new System.Drawing.Size(133, 32);
            this.creditorsToolStripMenuItem.Text = "Creditors";
            // 
            // creditorReportToolStripMenuItem
            // 
            this.creditorReportToolStripMenuItem.Name = "creditorReportToolStripMenuItem";
            this.creditorReportToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.creditorReportToolStripMenuItem.Text = "Creditor Report";
            this.creditorReportToolStripMenuItem.Click += new System.EventHandler(this.creditorReportToolStripMenuItem_Click);
            // 
            // addNewCreditorToolStripMenuItem
            // 
            this.addNewCreditorToolStripMenuItem.Name = "addNewCreditorToolStripMenuItem";
            this.addNewCreditorToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.addNewCreditorToolStripMenuItem.Text = "Add New Creditor";
            this.addNewCreditorToolStripMenuItem.Click += new System.EventHandler(this.addNewCreditorToolStripMenuItem_Click);
            // 
            // makePaymentToolStripMenuItem
            // 
            this.makePaymentToolStripMenuItem.Name = "makePaymentToolStripMenuItem";
            this.makePaymentToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.makePaymentToolStripMenuItem.Text = "Make Payment";
            this.makePaymentToolStripMenuItem.Click += new System.EventHandler(this.makePaymentToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(26, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 64);
            this.panel5.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(22)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::BillingSoft.Properties.Resources.credit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.MaximumSize = new System.Drawing.Size(309, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Daily Sell Credit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(26, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 64);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(22)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::BillingSoft.Properties.Resources.invoice;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.MaximumSize = new System.Drawing.Size(309, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Unprint Invoices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonhelp);
            this.panel2.Location = new System.Drawing.Point(26, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 64);
            this.panel2.TabIndex = 4;
            // 
            // buttonhelp
            // 
            this.buttonhelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonhelp.FlatAppearance.BorderSize = 0;
            this.buttonhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(22)))));
            this.buttonhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhelp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhelp.ForeColor = System.Drawing.Color.Black;
            this.buttonhelp.Image = global::BillingSoft.Properties.Resources.report;
            this.buttonhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonhelp.Location = new System.Drawing.Point(0, 0);
            this.buttonhelp.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonhelp.Name = "buttonhelp";
            this.buttonhelp.Size = new System.Drawing.Size(309, 64);
            this.buttonhelp.TabIndex = 2;
            this.buttonhelp.Text = "Daily Sell Report";
            this.buttonhelp.UseVisualStyleBackColor = true;
            this.buttonhelp.Click += new System.EventHandler(this.buttonhelp_Click);
            // 
            // timer_blink
            // 
            this.timer_blink.Interval = 200;
            this.timer_blink.Tick += new System.EventHandler(this.timer_blink_Tick);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 785);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Index_Load);
            this.panel1.ResumeLayout(false);
            this.panelfill.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtotalProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtotalsell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewunprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoutofstock)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.paneloutofstock.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelfill;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonhelp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labeltotalsellitems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltotalproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltotalinvoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewtotalProduct;
        private System.Windows.Forms.DataGridView dataGridViewtotalsell;
        private System.Windows.Forms.DataGridView dataGridViewunprint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCreditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditorReportToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel paneloutofstock;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewoutofstock;
        private System.Windows.Forms.Timer timer_blink;
    }
}