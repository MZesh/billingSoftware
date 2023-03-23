namespace BillingSoft.Authentication
{
    partial class UpdateCredentials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCredentials));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxrole = new System.Windows.Forms.ComboBox();
            this.textBoxnewpass = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxconfrmpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxnewUser = new System.Windows.Forms.TextBox();
            this.labelnewUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BillingSoft.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(220, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update Credentials";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonlogin.AutoSize = true;
            this.buttonlogin.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(113, 669);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(361, 44);
            this.buttonlogin.TabIndex = 7;
            this.buttonlogin.Text = "Update Credentials";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(547, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 28);
            this.label6.TabIndex = 39;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxrole
            // 
            this.comboBoxrole.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrator",
            "User"});
            this.comboBoxrole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxrole.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxrole.FormattingEnabled = true;
            this.comboBoxrole.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.comboBoxrole.Location = new System.Drawing.Point(89, 622);
            this.comboBoxrole.Name = "comboBoxrole";
            this.comboBoxrole.Size = new System.Drawing.Size(381, 34);
            this.comboBoxrole.TabIndex = 6;
            // 
            // textBoxnewpass
            // 
            this.textBoxnewpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxnewpass.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnewpass.Location = new System.Drawing.Point(93, 462);
            this.textBoxnewpass.Name = "textBoxnewpass";
            this.textBoxnewpass.Size = new System.Drawing.Size(381, 33);
            this.textBoxnewpass.TabIndex = 4;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxpass.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.Location = new System.Drawing.Point(93, 385);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(381, 33);
            this.textBoxpass.TabIndex = 3;
            this.textBoxpass.Leave += new System.EventHandler(this.Match_Old_Pass);
            // 
            // textBoxuser
            // 
            this.textBoxuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxuser.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxuser.Location = new System.Drawing.Point(93, 218);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(381, 33);
            this.textBoxuser.TabIndex = 1;
            this.textBoxuser.Leave += new System.EventHandler(this.Get_Username);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Username";
            // 
            // textBoxconfrmpass
            // 
            this.textBoxconfrmpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxconfrmpass.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxconfrmpass.Location = new System.Drawing.Point(93, 542);
            this.textBoxconfrmpass.Name = "textBoxconfrmpass";
            this.textBoxconfrmpass.Size = new System.Drawing.Size(381, 33);
            this.textBoxconfrmpass.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 28);
            this.label7.TabIndex = 48;
            this.label7.Text = "Confirm Password";
            // 
            // textBoxnewUser
            // 
            this.textBoxnewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxnewUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxnewUser.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnewUser.Location = new System.Drawing.Point(93, 297);
            this.textBoxnewUser.Name = "textBoxnewUser";
            this.textBoxnewUser.Size = new System.Drawing.Size(381, 33);
            this.textBoxnewUser.TabIndex = 2;
            // 
            // labelnewUser
            // 
            this.labelnewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnewUser.AutoSize = true;
            this.labelnewUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnewUser.Location = new System.Drawing.Point(36, 261);
            this.labelnewUser.Name = "labelnewUser";
            this.labelnewUser.Size = new System.Drawing.Size(169, 28);
            this.labelnewUser.TabIndex = 51;
            this.labelnewUser.Text = "New Username";
            // 
            // UpdateCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 748);
            this.Controls.Add(this.textBoxnewUser);
            this.Controls.Add(this.labelnewUser);
            this.Controls.Add(this.textBoxconfrmpass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxrole);
            this.Controls.Add(this.textBoxnewpass);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateCredentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Credentials";
            this.Load += new System.EventHandler(this.UpdateCredentials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxrole;
        private System.Windows.Forms.TextBox textBoxnewpass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxconfrmpass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxnewUser;
        private System.Windows.Forms.Label labelnewUser;
    }
}