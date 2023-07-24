using Group3.FrSigin.Account;
using Group3.Method;
using MailKit.Net.Imap;
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
    public partial class EditAvtatr : Form
    {
        public EditAvtatr()
        {
            InitializeComponent();
        }
        public void setAvater(Image img)
        {
            picAvatar.Image = img;
        }
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    List<User> users = new List<User>();
                    picAvatar.Image=Image.FromFile(ofd.FileName);
                    DataAcces.DataAcces dt= new DataAcces.DataAcces();
                    await dt.UpdateAvatar(Stored.ur.Email,ofd.FileName);
                    DataAcces.DataAcces db = new DataAcces.DataAcces();
                    users = await db.getInforUsre(Method.Stored.ur.Email);
                    Stored.ur = users[0];
                    
                }
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            guna2Button1_Click(sender,e);
        }
    }
}
