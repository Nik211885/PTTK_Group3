using Group3.FrSigin.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.Profile.FrEditData
{
    public partial class EditPhone : Form
    {
        public EditPhone()
        {
            InitializeComponent();
        }
        bool chek;
        public void setPhone(string phone)
        {
            txtPhone.Text = phone;
        }
        bool chek2;
        private void setCheck(string phone)
        {
            if (phone.Length != 10)
            {
                sapn.Visible = true;
                chek2 = false;
                txtPhone.BorderColor = Color.Red;
            }
            else
            {
                sapn.Visible = false;
                chek2 = true;
                txtPhone.BorderColor = Color.Black;
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if(Method.ValidateValue.isPhone(txtPhone.Text)&&txtPhone.Text.Length<=10)
            {
                sapn.Visible = false;
                chek = true;
                txtPhone.BorderColor = Color.Black;
            }
            else
            {
                sapn.Visible = true;
                chek= false;
                txtPhone.BorderColor = Color.Red;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
            txtPhone_TextChanged((object)sender, e);
            setCheck(txtPhone.Text);
            if (chek&&chek2)
            {
                List<User> users = new List<User>();
            }
        }
    }
}
