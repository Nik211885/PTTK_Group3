using Group3.FrSigin.Account;
using Group3.Method;
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
    public partial class EditBirthDay : Form
    {
        public EditBirthDay()
        {
            InitializeComponent();

        }
        public void setDateTime(string day,string month,string year)
        {
            txtD.Text = day;
            combM.SelectedIndex=int.Parse(month)-1;
            txtY.Text=year;
        }
        private void EditBirthDay_Load(object sender, EventArgs e)
        {

        }
        bool check = false;
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            CheckDate();
            string[] month = combM.Text.Split(' ');

            string date= txtY.Text +"-"+ month[1] + "-" + txtD.Text;
            if (check)
            {
                List<User> users = new List<User>();
                DataAcces.DataAcces dt = new DataAcces.DataAcces();
                await dt.UpdateBirthDay(Method.Stored.ur.Email,date);
                DataAcces.DataAcces db = new DataAcces.DataAcces();
                users = await db.getInforUsre(Method.Stored.ur.Email);
                Stored.ur = users[0];
            }
        }
       
        private void txtD_TextChanged(object sender, EventArgs e)
        {
            CheckDate();
        }
        private void CheckDate()
        {
            string[] split = combM.Text.Split(' ');
            if (Method.ValidateValue.isYear(txtD.Text, split[1], txtY.Text))
            {
                //update
                txtD.BorderColor = Color.Black;
                txtY.BorderColor = Color.Black;
                combM.BorderColor = Color.Black;
                sapn.Visible = false;
                check = true;
            }
            else
            {
                txtD.BorderColor = Color.Red;
                txtY.BorderColor = Color.Red;
                combM.BorderColor = Color.Red;
                sapn.Visible = true;
                check = false;
            }
        }
        private void combM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckDate();
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            CheckDate();
        }
    }
}
