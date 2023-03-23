namespace BillingSoft.Products
{
    partial class EditUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUpdate));
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.textBoxpname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxqty = new System.Windows.Forms.TextBox();
            this.textBoxsellprice = new System.Windows.Forms.TextBox();
            this.textBoxpprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxcat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxbnd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxcode
            // 
            this.textBoxcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcode.Location = new System.Drawing.Point(286, 143);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.Size = new System.Drawing.Size(335, 32);
            this.textBoxcode.TabIndex = 41;
            // 
            // textBoxpname
            // 
            this.textBoxpname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpname.Location = new System.Drawing.Point(286, 71);
            this.textBoxpname.Name = "textBoxpname";
            this.textBoxpname.Size = new System.Drawing.Size(335, 32);
            this.textBoxpname.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::BillingSoft.Properties.Resources.required;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(153, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Item Code :   ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::BillingSoft.Properties.Resources.required;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(153, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 38;
            this.label2.Tag = "";
            this.label2.Text = "Item Name :  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // textBoxqty
            // 
            this.textBoxqty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxqty.Location = new System.Drawing.Point(286, 357);
            this.textBoxqty.Name = "textBoxqty";
            this.textBoxqty.Size = new System.Drawing.Size(335, 32);
            this.textBoxqty.TabIndex = 48;
            this.textBoxqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_VAlidate);
            // 
            // textBoxsellprice
            // 
            this.textBoxsellprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxsellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsellprice.Location = new System.Drawing.Point(286, 280);
            this.textBoxsellprice.Name = "textBoxsellprice";
            this.textBoxsellprice.Size = new System.Drawing.Size(335, 32);
            this.textBoxsellprice.TabIndex = 47;
            this.textBoxsellprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sell_Price_Validate);
            // 
            // textBoxpprice
            // 
            this.textBoxpprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxpprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpprice.Location = new System.Drawing.Point(286, 203);
            this.textBoxpprice.Name = "textBoxpprice";
            this.textBoxpprice.Size = new System.Drawing.Size(335, 32);
            this.textBoxpprice.TabIndex = 46;
            this.textBoxpprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_Purchase_Validate);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Quantity : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Sell Price: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Purchase Price: ";
            // 
            // buttonupdate
            // 
            this.buttonupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonupdate.AutoSize = true;
            this.buttonupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(66)))));
            this.buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.ForeColor = System.Drawing.Color.White;
            this.buttonupdate.Image = global::BillingSoft.Properties.Resources.update;
            this.buttonupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonupdate.Location = new System.Drawing.Point(210, 567);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(179, 56);
            this.buttonupdate.TabIndex = 50;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BillingSoft.Properties.Resources.remove;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(442, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 56);
            this.button1.TabIndex = 51;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 37);
            this.label1.TabIndex = 52;
            this.label1.Text = "Edit/Delete Products Information";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(775, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelid
            // 
            this.labelid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(333, 645);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(108, 26);
            this.labelid.TabIndex = 54;
            this.labelid.Text = "Quantity : ";
            this.labelid.Visible = false;
            // 
            // textBoxcat
            // 
            this.textBoxcat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcat.Location = new System.Drawing.Point(286, 432);
            this.textBoxcat.Name = "textBoxcat";
            this.textBoxcat.Size = new System.Drawing.Size(335, 32);
            this.textBoxcat.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cagetory:";
            // 
            // textBoxbnd
            // 
            this.textBoxbnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxbnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxbnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbnd.Location = new System.Drawing.Point(286, 505);
            this.textBoxbnd.Name = "textBoxbnd";
            this.textBoxbnd.Size = new System.Drawing.Size(335, 32);
            this.textBoxbnd.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 57;
            this.label9.Text = "Brand:";
            // 
            // EditUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(803, 707);
            this.Controls.Add(this.textBoxbnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxcat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.textBoxqty);
            this.Controls.Add(this.textBoxsellprice);
            this.Controls.Add(this.textBoxpprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxcode);
            this.Controls.Add(this.textBoxpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUpdate";
            this.Load += new System.EventHandler(this.EditUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.TextBox textBoxpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxqty;
        private System.Windows.Forms.TextBox textBoxsellprice;
        private System.Windows.Forms.TextBox textBoxpprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxcat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxbnd;
        private System.Windows.Forms.Label label9;
    }
}