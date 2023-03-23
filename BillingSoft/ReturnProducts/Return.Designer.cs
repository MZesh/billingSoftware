namespace BillingSoft.ReturnProducts
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.textBoxpname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxinv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.textBoxprc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "Product Return Panel";
            // 
            // textBoxcode
            // 
            this.textBoxcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcode.Location = new System.Drawing.Point(732, 246);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.Size = new System.Drawing.Size(335, 32);
            this.textBoxcode.TabIndex = 57;
            // 
            // textBoxpname
            // 
            this.textBoxpname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpname.Location = new System.Drawing.Point(213, 242);
            this.textBoxpname.Name = "textBoxpname";
            this.textBoxpname.Size = new System.Drawing.Size(335, 32);
            this.textBoxpname.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(599, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Item Code :   ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(80, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 54;
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
            this.textBoxqty.Location = new System.Drawing.Point(213, 339);
            this.textBoxqty.Name = "textBoxqty";
            this.textBoxqty.Size = new System.Drawing.Size(335, 32);
            this.textBoxqty.TabIndex = 59;
            this.textBoxqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_Validate);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(80, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 58;
            this.label4.Text = "Quantity :   ";
            // 
            // textBoxinv
            // 
            this.textBoxinv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxinv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxinv.Location = new System.Drawing.Point(411, 154);
            this.textBoxinv.Name = "textBoxinv";
            this.textBoxinv.Size = new System.Drawing.Size(335, 32);
            this.textBoxinv.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(251, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 60;
            this.label5.Text = "Invoice No :   ";
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
            this.buttonupdate.Location = new System.Drawing.Point(466, 505);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(179, 56);
            this.buttonupdate.TabIndex = 62;
            this.buttonupdate.Text = "Return";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // textBoxprc
            // 
            this.textBoxprc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxprc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxprc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxprc.Location = new System.Drawing.Point(732, 337);
            this.textBoxprc.Name = "textBoxprc";
            this.textBoxprc.Size = new System.Drawing.Size(335, 32);
            this.textBoxprc.TabIndex = 64;
            this.textBoxprc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_Validate);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(623, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 63;
            this.label6.Text = "Price :   ";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1121, 667);
            this.Controls.Add(this.textBoxprc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.textBoxinv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxcode);
            this.Controls.Add(this.textBoxpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.TextBox textBoxpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxinv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.TextBox textBoxprc;
        private System.Windows.Forms.Label label6;
    }
}