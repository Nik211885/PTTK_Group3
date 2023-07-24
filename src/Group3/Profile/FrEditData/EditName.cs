using Group3.FrSigin.Account;
using Group3.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.Profile.FrEditData
{
    public partial class EditName : Form
    {
        public EditName()
        {
            InitializeComponent();
        }
        public void setName(string name)
        {
            txtName.Text = name;
        }
        bool chek = false;
        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Method.ValidateValue.isName(txtName.Text))
            {
                chek = true;
                txtName.BorderColor = Color.Black;
                sapn.Visible = false;
            }
            else
            {
                chek=false;
                txtName.BorderColor = Color.Red;
                sapn.Visible = true;
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox1_TextChanged(sender, e);
            if (chek)
            {
                List<User> users = new List<User>();
                DataAcces.DataAcces dt = new DataAcces.DataAcces();
                await dt.UpdateName(Method.Stored.ur.Email, txtName.Text);
                DataAcces.DataAcces db = new DataAcces.DataAcces();
                users = await db.getInforUsre(Method.Stored.ur.Email);
                Stored.ur = users[0];
            }
        }
    }
}
