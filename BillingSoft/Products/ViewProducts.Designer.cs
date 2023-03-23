namespace BillingSoft.Products
{
    partial class ViewProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeldiff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelsellprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelpprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelitemcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxsearchbycode = new System.Windows.Forms.TextBox();
            this.textBoxsearchbycategory = new System.Windows.Forms.TextBox();
            this.textBoxsearchbyname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1375, 743);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View All Product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1369, 425);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Check_Button_Click);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Formatting_Cell_Values);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labeldiff);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelsellprice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelpprice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelitemcount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 643);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 97);
            this.panel2.TabIndex = 2;
            // 
            // labeldiff
            // 
            this.labeldiff.AutoSize = true;
            this.labeldiff.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiff.Location = new System.Drawing.Point(926, 65);
            this.labeldiff.Name = "labeldiff";
            this.labeldiff.Size = new System.Drawing.Size(24, 26);
            this.labeldiff.TabIndex = 19;
            this.labeldiff.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Difference of Purchase price over Sell price :";
            // 
            // labelsellprice
            // 
            this.labelsellprice.AutoSize = true;
            this.labelsellprice.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsellprice.Location = new System.Drawing.Point(604, 12);
            this.labelsellprice.Name = "labelsellprice";
            this.labelsellprice.Size = new System.Drawing.Size(24, 26);
            this.labelsellprice.TabIndex = 17;
            this.labelsellprice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Item Sell Price :";
            // 
            // labelpprice
            // 
            this.labelpprice.AutoSize = true;
            this.labelpprice.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpprice.Location = new System.Drawing.Point(292, 65);
            this.labelpprice.Name = "labelpprice";
            this.labelpprice.Size = new System.Drawing.Size(24, 26);
            this.labelpprice.TabIndex = 15;
            this.labelpprice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Item Purchase Price :";
            // 
            // labelitemcount
            // 
            this.labelitemcount.AutoSize = true;
            this.labelitemcount.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelitemcount.Location = new System.Drawing.Point(193, 23);
            this.labelitemcount.Name = "labelitemcount";
            this.labelitemcount.Size = new System.Drawing.Size(24, 26);
            this.labelitemcount.TabIndex = 13;
            this.labelitemcount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Item Count :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxsearchbycode);
            this.panel1.Controls.Add(this.textBoxsearchbycategory);
            this.panel1.Controls.Add(this.textBoxsearchbyname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 196);
            this.panel1.TabIndex = 0;
            // 
            // textBoxsearchbycode
            // 
            this.textBoxsearchbycode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxsearchbycode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsearchbycode.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsearchbycode.Location = new System.Drawing.Point(621, 131);
            this.textBoxsearchbycode.Name = "textBoxsearchbycode";
            this.textBoxsearchbycode.Size = new System.Drawing.Size(301, 33);
            this.textBoxsearchbycode.TabIndex = 11;
            this.textBoxsearchbycode.TextChanged += new System.EventHandler(this.SearchbyCode);
            // 
            // textBoxsearchbycategory
            // 
            this.textBoxsearchbycategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxsearchbycategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsearchbycategory.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsearchbycategory.Location = new System.Drawing.Point(945, 46);
            this.textBoxsearchbycategory.Name = "textBoxsearchbycategory";
            this.textBoxsearchbycategory.Size = new System.Drawing.Size(301, 33);
            this.textBoxsearchbycategory.TabIndex = 10;
            this.textBoxsearchbycategory.TextChanged += new System.EventHandler(this.CategorySearch);
            // 
            // textBoxsearchbyname
            // 
            this.textBoxsearchbyname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxsearchbyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsearchbyname.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsearchbyname.Location = new System.Drawing.Point(363, 45);
            this.textBoxsearchbyname.Name = "textBoxsearchbyname";
            this.textBoxsearchbyname.Size = new System.Drawing.Size(301, 33);
            this.textBoxsearchbyname.TabIndex = 9;
            this.textBoxsearchbyname.TextChanged += new System.EventHandler(this.textBoxsearchbyname_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search Item by Code";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Item by Category";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Item by Name";
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 743);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxsearchbycode;
        private System.Windows.Forms.TextBox textBoxsearchbycategory;
        private System.Windows.Forms.TextBox textBoxsearchbyname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeldiff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelsellprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelpprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelitemcount;
        private System.Windows.Forms.Label label4;
    }
}