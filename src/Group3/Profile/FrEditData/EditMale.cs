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
    public partial class EditMale : Form
    {
        public EditMale()
        {
            InitializeComponent();
        }
        public void setCheck(string maele)
        {
            if (checkNam.Text == maele)
            {
                checkNam.Checked = true;
            }
            if (chekNu.Text == maele)
            {
                chekNu.Checked = true;
            }
            if (checkIdontKnow.Text == maele)
            {
                checkIdontKnow.Checked = true;
            }
        }
        string male="";
        private string setMale()
        {
            
            if(checkNam.Checked)
            {
                male = checkNam.Text;
            }
            if (chekNu.Checked) { male= chekNu.Text; }
            if(checkIdontKnow.Checked) { male=checkIdontKnow.Text; }
            return male;
            
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            DataAcces.DataAcces dt = new DataAcces.DataAcces();
            setMale();
            await dt.UpdateMale(Stored.ur.Email,male);
            DataAcces.DataAcces db = new DataAcces.DataAcces();
            users = await db.getInforUsre(Method.Stored.ur.Email);
            Stored.ur = users[0];
        }
    }
}
