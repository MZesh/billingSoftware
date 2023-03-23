namespace BillingSoft.Creditors
{
    partial class ViewAndPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndPrint));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewnew = new System.Windows.Forms.DataGridView();
            this.textBoxnewCreditor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttongen = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnew)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttongen);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1567, 744);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Creditor Report";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.dataGridViewnew);
            this.groupBox6.Controls.Add(this.textBoxnewCreditor);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(12, 62);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1395, 620);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Creditors";
            // 
            // dataGridViewnew
            // 
            this.dataGridViewnew.AllowUserToAddRows = false;
            this.dataGridViewnew.AllowUserToDeleteRows = false;
            this.dataGridViewnew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewnew.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewnew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnew.Location = new System.Drawing.Point(6, 100);
            this.dataGridViewnew.Name = "dataGridViewnew";
            this.dataGridViewnew.ReadOnly = true;
            this.dataGridViewnew.RowHeadersWidth = 62;
            this.dataGridViewnew.RowTemplate.Height = 28;
            this.dataGridViewnew.Size = new System.Drawing.Size(1355, 514);
            this.dataGridViewnew.TabIndex = 2;
            // 
            // textBoxnewCreditor
            // 
            this.textBoxnewCreditor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxnewCreditor.Location = new System.Drawing.Point(701, 47);
            this.textBoxnewCreditor.Name = "textBoxnewCreditor";
            this.textBoxnewCreditor.Size = new System.Drawing.Size(336, 31);
            this.textBoxnewCreditor.TabIndex = 1;
            this.textBoxnewCreditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_By_Name);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(443, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Search by Creditor Name: ";
            // 
            // buttongen
            // 
            this.buttongen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttongen.AutoSize = true;
            this.buttongen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttongen.Enabled = false;
            this.buttongen.FlatAppearance.BorderSize = 0;
            this.buttongen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongen.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongen.Image = global::BillingSoft.Properties.Resources.report;
            this.buttongen.Location = new System.Drawing.Point(1113, 682);
            this.buttongen.Name = "buttongen";
            this.buttongen.Size = new System.Drawing.Size(215, 55);
            this.buttongen.TabIndex = 12;
            this.buttongen.Text = "Generate Report";
            this.buttongen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttongen.UseVisualStyleBackColor = false;
            this.buttongen.Click += new System.EventHandler(this.buttongen_Click);
            // 
            // ViewAndPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 744);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1589, 800);
            this.MinimumSize = new System.Drawing.Size(1589, 800);
            this.Name = "ViewAndPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View And Print";
            this.Load += new System.EventHandler(this.ViewAndPrint_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewnew;
        private System.Windows.Forms.TextBox textBoxnewCreditor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttongen;
    }
}