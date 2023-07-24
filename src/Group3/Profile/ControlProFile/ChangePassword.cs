using Group3.Profile.FrEditData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.Profile.ControlProFile
{
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        bool chek1;
        bool chek2;
        bool chek3;
        private void ValidateValue()
        {
            if ((txtPasswordold.Text != Method.Stored.ur.Password))
            {
                sapn.Visible = true;
                txtPasswordold.BorderColor = Color.Red;
                chek1 = false;
            }
            else
            {
                sapn.Visible = false;
                txtPasswordold.BorderColor = Color.Black;
                chek2 = true;
            }
            if(!Method.ValidateValue.isPassword(txtNewPassword.Text)) {
                label6.Visible = true;
                txtNewPassword.BorderColor = Color.Red;
                chek2 = false;
            }
            else
            {
                label6.Visible= false;
                txtNewPassword.BorderColor = Color.Black;
                chek1 = true;
            }
            if (txtNewPassword.Text!=conFirmPasword.Text) {
                label7.Visible = true;
                conFirmPasword.BorderColor = Color.Red;
                chek3 = false;
            }
            else
            {
                label7.Visible = false;
                conFirmPasword.BorderColor = Color.Black;
                chek3 = true;
            }
        }
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            ValidateValue();
            if (chek1&&chek2&&chek3)
            {
                using (SendCode sc  = new SendCode())
                {
                    sc.newPassword = txtNewPassword.Text;
                    sc.ShowDialog();
                }
                txtPasswordold.Clear();txtNewPassword.Clear();conFirmPasword.Clear();
            }
        }
    }
}
