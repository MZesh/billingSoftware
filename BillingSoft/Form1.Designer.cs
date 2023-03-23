namespace BillingSoft
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.labelad = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.flowLayoutmenupanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.pictureBoxExpend = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelprodbtn = new System.Windows.Forms.Panel();
            this.buttonViewProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelselling = new System.Windows.Forms.Panel();
            this.btnhistory = new System.Windows.Forms.Button();
            this.buttonsellingpanel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.paneldatabase = new System.Windows.Forms.Panel();
            this.buttonrestoredata = new System.Windows.Forms.Button();
            this.buttonbackupdata = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonsetting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonhelp = new System.Windows.Forms.Button();
            this.timer_slideMenu = new System.Windows.Forms.Timer(this.components);
            this.timer_prod = new System.Windows.Forms.Timer(this.components);
            this.timerdatabase = new System.Windows.Forms.Timer(this.components);
            this.timerselling = new System.Windows.Forms.Timer(this.components);
            this.toppanel.SuspendLayout();
            this.flowLayoutmenupanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpend)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelprodbtn.SuspendLayout();
            this.panelselling.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneldatabase.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(318, 100);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(963, 702);
            this.mainpanel.TabIndex = 5;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(100)))));
            this.toppanel.Controls.Add(this.labelad);
            this.toppanel.Controls.Add(this.labeltitle);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(318, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(963, 100);
            this.toppanel.TabIndex = 4;
            // 
            // labelad
            // 
            this.labelad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelad.Location = new System.Drawing.Point(656, 34);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(60, 28);
            this.labelad.TabIndex = 4;
            this.labelad.Text = "User";
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltitle.Location = new System.Drawing.Point(323, 28);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(184, 37);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "Dashboard";
            // 
            // flowLayoutmenupanel
            // 
            this.flowLayoutmenupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.flowLayoutmenupanel.Controls.Add(this.panelTop);
            this.flowLayoutmenupanel.Controls.Add(this.panel4);
            this.flowLayoutmenupanel.Controls.Add(this.panelprodbtn);
            this.flowLayoutmenupanel.Controls.Add(this.panelselling);
            this.flowLayoutmenupanel.Controls.Add(this.panel2);
            this.flowLayoutmenupanel.Controls.Add(this.paneldatabase);
            this.flowLayoutmenupanel.Controls.Add(this.panel3);
            this.flowLayoutmenupanel.Controls.Add(this.panel1);
            this.flowLayoutmenupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutmenupanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutmenupanel.MaximumSize = new System.Drawing.Size(318, 0);
            this.flowLayoutmenupanel.MinimumSize = new System.Drawing.Size(52, 0);
            this.flowLayoutmenupanel.Name = "flowLayoutmenupanel";
            this.flowLayoutmenupanel.Size = new System.Drawing.Size(318, 802);
            this.flowLayoutmenupanel.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.pictureBoxclose);
            this.panelTop.Controls.Add(this.pictureBoxExpend);
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(315, 62);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxclose.Image = global::BillingSoft.Properties.Resources.close;
            this.pictureBoxclose.Location = new System.Drawing.Point(264, 0);
            this.pictureBoxclose.MaximumSize = new System.Drawing.Size(51, 50);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxclose.TabIndex = 1;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxExpend
            // 
            this.pictureBoxExpend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxExpend.Image = global::BillingSoft.Properties.Resources.menu;
            this.pictureBoxExpend.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxExpend.MaximumSize = new System.Drawing.Size(51, 50);
            this.pictureBoxExpend.Name = "pictureBoxExpend";
            this.pictureBoxExpend.Size = new System.Drawing.Size(44, 50);
            this.pictureBoxExpend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExpend.TabIndex = 0;
            this.pictureBoxExpend.TabStop = false;
            this.pictureBoxExpend.Visible = false;
            this.pictureBoxExpend.Click += new System.EventHandler(this.pictureBoxExpend_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 64);
            this.panel4.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::BillingSoft.Properties.Resources.dashboard;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.MaximumSize = new System.Drawing.Size(309, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dashboard";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelprodbtn
            // 
            this.panelprodbtn.Controls.Add(this.buttonViewProduct);
            this.panelprodbtn.Controls.Add(this.buttonAddProduct);
            this.panelprodbtn.Controls.Add(this.btnProduct);
            this.panelprodbtn.Location = new System.Drawing.Point(3, 141);
            this.panelprodbtn.MaximumSize = new System.Drawing.Size(309, 194);
            this.panelprodbtn.MinimumSize = new System.Drawing.Size(309, 60);
            this.panelprodbtn.Name = "panelprodbtn";
            this.panelprodbtn.Size = new System.Drawing.Size(309, 60);
            this.panelprodbtn.TabIndex = 1;
            // 
            // buttonViewProduct
            // 
            this.buttonViewProduct.FlatAppearance.BorderSize = 0;
            this.buttonViewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProduct.ForeColor = System.Drawing.Color.White;
            this.buttonViewProduct.Image = global::BillingSoft.Properties.Resources.view;
            this.buttonViewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewProduct.Location = new System.Drawing.Point(-1, 117);
            this.buttonViewProduct.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonViewProduct.Name = "buttonViewProduct";
            this.buttonViewProduct.Size = new System.Drawing.Size(309, 64);
            this.buttonViewProduct.TabIndex = 4;
            this.buttonViewProduct.Text = "View Product";
            this.buttonViewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewProduct.UseVisualStyleBackColor = true;
            this.buttonViewProduct.Click += new System.EventHandler(this.buttonViewProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduct.Image = global::BillingSoft.Properties.Resources.prod;
            this.buttonAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.Location = new System.Drawing.Point(-1, 63);
            this.buttonAddProduct.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(309, 64);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::BillingSoft.Properties.Resources.product;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 3);
            this.btnProduct.MaximumSize = new System.Drawing.Size(309, 64);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(309, 64);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Manage Products";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelselling
            // 
            this.panelselling.Controls.Add(this.btnhistory);
            this.panelselling.Controls.Add(this.buttonsellingpanel);
            this.panelselling.Controls.Add(this.button4);
            this.panelselling.Location = new System.Drawing.Point(3, 207);
            this.panelselling.MaximumSize = new System.Drawing.Size(309, 194);
            this.panelselling.MinimumSize = new System.Drawing.Size(309, 60);
            this.panelselling.Name = "panelselling";
            this.panelselling.Size = new System.Drawing.Size(309, 60);
            this.panelselling.TabIndex = 5;
            // 
            // btnhistory
            // 
            this.btnhistory.FlatAppearance.BorderSize = 0;
            this.btnhistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.ForeColor = System.Drawing.Color.White;
            this.btnhistory.Image = global::BillingSoft.Properties.Resources.history;
            this.btnhistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistory.Location = new System.Drawing.Point(-1, 117);
            this.btnhistory.MaximumSize = new System.Drawing.Size(309, 64);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(309, 64);
            this.btnhistory.TabIndex = 4;
            this.btnhistory.Text = "View Sell History";
            this.btnhistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhistory.UseVisualStyleBackColor = true;
            this.btnhistory.Click += new System.EventHandler(this.open_Selling_History);
            // 
            // buttonsellingpanel
            // 
            this.buttonsellingpanel.FlatAppearance.BorderSize = 0;
            this.buttonsellingpanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonsellingpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsellingpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsellingpanel.ForeColor = System.Drawing.Color.White;
            this.buttonsellingpanel.Image = global::BillingSoft.Properties.Resources.sellpanel;
            this.buttonsellingpanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsellingpanel.Location = new System.Drawing.Point(-1, 63);
            this.buttonsellingpanel.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonsellingpanel.Name = "buttonsellingpanel";
            this.buttonsellingpanel.Size = new System.Drawing.Size(309, 64);
            this.buttonsellingpanel.TabIndex = 3;
            this.buttonsellingpanel.Text = "Selling Panel";
            this.buttonsellingpanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonsellingpanel.UseVisualStyleBackColor = true;
            this.buttonsellingpanel.Click += new System.EventHandler(this.selling_panel);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::BillingSoft.Properties.Resources.sell;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.MaximumSize = new System.Drawing.Size(309, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(309, 64);
            this.button4.TabIndex = 2;
            this.button4.Text = "Sell Product Panel";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 64);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BillingSoft.Properties.Resources.expense;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.MaximumSize = new System.Drawing.Size(309, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Expenses";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paneldatabase
            // 
            this.paneldatabase.Controls.Add(this.buttonrestoredata);
            this.paneldatabase.Controls.Add(this.buttonbackupdata);
            this.paneldatabase.Controls.Add(this.button2);
            this.paneldatabase.Location = new System.Drawing.Point(3, 343);
            this.paneldatabase.MaximumSize = new System.Drawing.Size(317, 196);
            this.paneldatabase.MinimumSize = new System.Drawing.Size(317, 60);
            this.paneldatabase.Name = "paneldatabase";
            this.paneldatabase.Size = new System.Drawing.Size(317, 60);
            this.paneldatabase.TabIndex = 4;
            // 
            // buttonrestoredata
            // 
            this.buttonrestoredata.FlatAppearance.BorderSize = 0;
            this.buttonrestoredata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonrestoredata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonrestoredata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrestoredata.ForeColor = System.Drawing.Color.White;
            this.buttonrestoredata.Image = global::BillingSoft.Properties.Resources.restore;
            this.buttonrestoredata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonrestoredata.Location = new System.Drawing.Point(2, 138);
            this.buttonrestoredata.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonrestoredata.Name = "buttonrestoredata";
            this.buttonrestoredata.Size = new System.Drawing.Size(309, 64);
            this.buttonrestoredata.TabIndex = 4;
            this.buttonrestoredata.Text = "Database Restore";
            this.buttonrestoredata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonrestoredata.UseVisualStyleBackColor = true;
            this.buttonrestoredata.Click += new System.EventHandler(this.restoreDb);
            // 
            // buttonbackupdata
            // 
            this.buttonbackupdata.FlatAppearance.BorderSize = 0;
            this.buttonbackupdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonbackupdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbackupdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbackupdata.ForeColor = System.Drawing.Color.White;
            this.buttonbackupdata.Image = global::BillingSoft.Properties.Resources.backup;
            this.buttonbackupdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonbackupdata.Location = new System.Drawing.Point(5, 70);
            this.buttonbackupdata.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonbackupdata.Name = "buttonbackupdata";
            this.buttonbackupdata.Size = new System.Drawing.Size(309, 64);
            this.buttonbackupdata.TabIndex = 3;
            this.buttonbackupdata.Text = "Database Backup";
            this.buttonbackupdata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonbackupdata.UseVisualStyleBackColor = true;
            this.buttonbackupdata.Click += new System.EventHandler(this.backupDb);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::BillingSoft.Properties.Resources.database;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 0);
            this.button2.MaximumSize = new System.Drawing.Size(309, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Database Options";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonsetting);
            this.panel3.Location = new System.Drawing.Point(3, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 64);
            this.panel3.TabIndex = 5;
            // 
            // buttonsetting
            // 
            this.buttonsetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsetting.FlatAppearance.BorderSize = 0;
            this.buttonsetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsetting.ForeColor = System.Drawing.Color.White;
            this.buttonsetting.Image = global::BillingSoft.Properties.Resources.setting;
            this.buttonsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsetting.Location = new System.Drawing.Point(0, 0);
            this.buttonsetting.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonsetting.Name = "buttonsetting";
            this.buttonsetting.Size = new System.Drawing.Size(309, 64);
            this.buttonsetting.TabIndex = 2;
            this.buttonsetting.Text = "Setting";
            this.buttonsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonsetting.UseVisualStyleBackColor = true;
            this.buttonsetting.Click += new System.EventHandler(this.buttonsetting_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonhelp);
            this.panel1.Location = new System.Drawing.Point(3, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 64);
            this.panel1.TabIndex = 3;
            // 
            // buttonhelp
            // 
            this.buttonhelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonhelp.FlatAppearance.BorderSize = 0;
            this.buttonhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhelp.ForeColor = System.Drawing.Color.White;
            this.buttonhelp.Image = global::BillingSoft.Properties.Resources.help;
            this.buttonhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonhelp.Location = new System.Drawing.Point(0, 0);
            this.buttonhelp.MaximumSize = new System.Drawing.Size(309, 64);
            this.buttonhelp.Name = "buttonhelp";
            this.buttonhelp.Size = new System.Drawing.Size(309, 64);
            this.buttonhelp.TabIndex = 2;
            this.buttonhelp.Text = "Help";
            this.buttonhelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonhelp.UseVisualStyleBackColor = true;
            this.buttonhelp.Click += new System.EventHandler(this.buttonhelp_Click);
            // 
            // timer_slideMenu
            // 
            this.timer_slideMenu.Interval = 10;
            this.timer_slideMenu.Tick += new System.EventHandler(this.timer_slideMenu_Tick);
            // 
            // timer_prod
            // 
            this.timer_prod.Interval = 10;
            this.timer_prod.Tick += new System.EventHandler(this.timer_prod_Tick);
            // 
            // timerdatabase
            // 
            this.timerdatabase.Interval = 10;
            this.timerdatabase.Tick += new System.EventHandler(this.timerdatabase_Tick);
            // 
            // timerselling
            // 
            this.timerselling.Interval = 10;
            this.timerselling.Tick += new System.EventHandler(this.timerselling_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 802);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.flowLayoutmenupanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Soff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed_1);
            this.Load += new System.EventHandler(this.Home_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.flowLayoutmenupanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpend)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelprodbtn.ResumeLayout(false);
            this.panelselling.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.paneldatabase.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutmenupanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.PictureBox pictureBoxExpend;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelprodbtn;
        private System.Windows.Forms.Button buttonViewProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel paneldatabase;
        private System.Windows.Forms.Button buttonrestoredata;
        private System.Windows.Forms.Button buttonbackupdata;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonsetting;
        private System.Windows.Forms.Panel panelselling;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button buttonsellingpanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonhelp;
        private System.Windows.Forms.Timer timer_slideMenu;
        private System.Windows.Forms.Timer timer_prod;
        private System.Windows.Forms.Timer timerdatabase;
        private System.Windows.Forms.Timer timerselling;
        private System.Windows.Forms.Label labelad;
    }
}

