using BillingSoft.Authentication;
using BillingSoft.DbCode;
using BillingSoft.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Settings
{
    public partial class Setting : Form
    {
        companyClass company = new companyClass();
        PrintSetting printSetting = new PrintSetting();
        AuthClass auth = new AuthClass();
        String impath = "";
        string themenameold = "";
        string themepass = "";
        public Setting()
        {
            InitializeComponent();
        }


        
        private void Validate_phone(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OpenFolderPath(TextBox location)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                location.Text = fbd.SelectedPath;
                 
            }
        }

        private void buttonbacone_Click(object sender, EventArgs e)
        {
            OpenFolderPath(textBoxbackupone);
        }

        private void buttonbactwo_Click(object sender, EventArgs e)
        {
            OpenFolderPath(textBoxbackuptwo);
        }

       

        private bool isEmpty()
        {
            if(textBoxcompname.Text.Equals("")|| textBoxcompaddress.Text.Equals("")|| textBoxcomphone.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearField()
        {
            foreach (Control c in panelcomap.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
             
        }

        private void upload_CompanyLogo(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Pickup Image File|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            dlg.Title = "Uploading Company Logo";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxlogo.Image = new Bitmap(dlg.FileName);
                pictureBoxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
                string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
                File.Copy(dlg.FileName, Path.Combine(strWorkPath + "\\logo\\", Path.GetFileName(dlg.FileName)), true);
                string filename = Path.GetFileName(dlg.FileName);
                labellogoname.Text = filename;
                // MessageBox.Show("Successfully Uploaded");

            }
        }

        private void save_Company_Information(object sender, EventArgs e)
        {
            bool checkEmpty = isEmpty();
            if (checkEmpty)
            {
                MessageBox.Show("Please Fill Company(Name,address,Phone)...", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isInsert = company.insertCompanyDetail(textBoxcompname.Text, textBoxcompaddress.Text, textBoxcomphone.Text, textBoxntn.Text, textBoxzipcode.Text, labellogoname.Text,"false");
                if (isInsert)
                {
                    MessageBox.Show("Successfully Saved Information...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ClearField();
                    panelcomap.Enabled =  false;
                }
                else
                {
                    MessageBox.Show("Cannot saved...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            CheckTheme(auth.GetThemeName());
            company.fillTheFields(textBoxcompname,textBoxcompaddress,textBoxcomphone,textBoxntn,textBoxzipcode,labellogoname);
            printSetting.getPrintingTemplateSizes(comboBoxprintsize,textBoxwatermark,comboBoxqrcode);
            printSetting.getLocations(textBoxbackupone,textBoxbackuptwo);
            if(EnableDisable(textBoxcompname.Text))
            {
                panelcomap.Enabled = true;
            }
            else
            {
                panelcomap.Enabled = false;
            }
            getImage();
            themenameold = auth.GetThemeName();
        }
        private void getImage()
        {
            impath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(impath);
            string fullPath = strWorkPath + "\\logo\\" + company.getCompanyImage();
            pictureBoxlogo.ImageLocation = fullPath;
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private bool EnableDisable(String compName)
        {
            if(compName == String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void buttonsaveprintSetting_Click(object sender, EventArgs e)
        {
            string isChecked = "";
            if (checkBoxppreview.Checked)
            {
                isChecked = "Yes";
            }
            else
            {
                isChecked = "No";
            }
            bool isUpdateSetting = printSetting.updatePrintSetting(comboBoxprintsize.Text,textBoxwatermark.Text,comboBoxqrcode.Text,isChecked);
            if (isUpdateSetting)
            {
                MessageBox.Show("Successfully Saved Setting...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ClearField();
                
            }
            else
            {
                MessageBox.Show("Cannot saved...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsavebackupsetting_Click(object sender, EventArgs e)
        {
            if(textBoxbackupone.Text.Equals("") || textBoxbackuptwo.Text.Equals(""))
            {
                MessageBox.Show("Please Setup The location...", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUpdate = printSetting.updateBackupLocSetting(textBoxbackupone.Text,textBoxbackuptwo.Text);
                if (isUpdate)
                {
                    MessageBox.Show("Successfully Saved Setting...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ClearField();

                }
                else
                {
                    MessageBox.Show("Cannot saved...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string themename = "";
            if (home.Checked)
            {
                themename = "Home";
            }else if(themetwo.Checked)
            {
                themename = "ThemeTwo";
               
            }
            else 
            {
                themename = "ThemeThree";
               
            }
            // MessageBox.Show(themename);

            string themeOld = auth.GetThemeName();
            DialogResult dr = MessageBox.Show("Application become restart when you click 'YES'?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                bool isUpdate = auth.updatetheme(themename);
                if (isUpdate)
                {
                    MessageBox.Show("Successfully Saved Setting...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent.Parent.Refresh();

                    SetTheme(themeOld);
                    //MessageBox.Show(themename);
                    Application.Restart();

                }
                else
                {
                    MessageBox.Show("Cannot saved...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
        private void SetTheme(string name)
        {
            switch (name)
            {
                case "Home":
                    Application.OpenForms["Home"].Close();
                    break;
                case "ThemeTwo":
                    Application.OpenForms["ThemeTwo"].Close();
                    break;
                case "ThemeThree":
                    Application.OpenForms["ThemeThree"].Close();
                    break;
            }
        }
        private void CheckTheme(string name)
        {
            switch (name)
            {
                case "Home":
                    home.Checked = true;
                    break;
                case "ThemeTwo":
                    themetwo.Checked = true;
                    break;
                case "ThemeThree":
                    themethree.Checked = true;
                    break;
            }

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            home.Checked = true;
            groupBox2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //themetwo.Checked = true;
            labelthemes.Text = "Please Enter Theme Two Password";
            themepass = "dgthemetwo@123";
            groupBox2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // themethree.Checked = true;
            labelthemes.Text = "Please Enter Theme Three Password";
            themepass = "dgthemethree@123";
            groupBox2.Visible = true;
        }

        private void CheckPass(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string pass = textBoxthemetwopass.Text;
                if(pass.Equals(themepass))
                {
                   if(themepass.Equals("dgthemetwo@123"))
                    {
                        themetwo.Checked = true;
                    }else if(themepass.Equals("dgthemethree@123"))
                    {
                        themethree.Checked = true;
                    }
                    groupBox2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Password does not match...");
                }
            }
        }

        private void themetwo_Click(object sender, EventArgs e)
        {
            labelthemes.Text = "Please Enter Theme Two Password";
            themepass = "dgthemetwo@123";
            groupBox2.Visible = true;
            themetwo.Checked = false;
        }

        private void themethree_Click(object sender, EventArgs e)
        {
            labelthemes.Text = "Please Enter Theme Three Password";
            themepass = "dgthemethree@123";
            groupBox2.Visible = true;
            themethree.Checked = false;
        }

        private void home_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}
