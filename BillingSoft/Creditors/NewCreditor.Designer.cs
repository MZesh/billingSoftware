namespace BillingSoft.Creditors
{
    partial class NewCreditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCreditor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxinvoice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxpaidAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxremaining = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcrdnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 745);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Creditors";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.textBoxinvoice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBoxpaidAmount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxremaining);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxamount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxcrdnm);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(20, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 620);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // textBoxinvoice
            // 
            this.textBoxinvoice.Location = new System.Drawing.Point(203, 415);
            this.textBoxinvoice.Name = "textBoxinvoice";
            this.textBoxinvoice.Size = new System.Drawing.Size(336, 31);
            this.textBoxinvoice.TabIndex = 8;
            this.textBoxinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_contact);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BillingSoft.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(312, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add New Creditor";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxpaidAmount
            // 
            this.textBoxpaidAmount.Location = new System.Drawing.Point(203, 262);
            this.textBoxpaidAmount.Name = "textBoxpaidAmount";
            this.textBoxpaidAmount.Size = new System.Drawing.Size(336, 31);
            this.textBoxpaidAmount.TabIndex = 7;
            this.textBoxpaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_PaidAmount);
            this.textBoxpaidAmount.Leave += new System.EventHandler(this.Check_remain);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Paid Amount: ";
            // 
            // textBoxremaining
            // 
            this.textBoxremaining.Location = new System.Drawing.Point(203, 340);
            this.textBoxremaining.Name = "textBoxremaining";
            this.textBoxremaining.ReadOnly = true;
            this.textBoxremaining.Size = new System.Drawing.Size(336, 31);
            this.textBoxremaining.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remaining: ";
            // 
            // textBoxamount
            // 
            this.textBoxamount.Location = new System.Drawing.Point(203, 180);
            this.textBoxamount.Name = "textBoxamount";
            this.textBoxamount.Size = new System.Drawing.Size(336, 31);
            this.textBoxamount.TabIndex = 6;
            this.textBoxamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Amount);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount: ";
            // 
            // textBoxcrdnm
            // 
            this.textBoxcrdnm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxcrdnm.Location = new System.Drawing.Point(203, 97);
            this.textBoxcrdnm.Name = "textBoxcrdnm";
            this.textBoxcrdnm.Size = new System.Drawing.Size(336, 31);
            this.textBoxcrdnm.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creditor Name: ";
            // 
            // NewCreditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 745);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewCreditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCreditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxinvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxpaidAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxremaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxcrdnm;
        private System.Windows.Forms.Label label2;
    }
}