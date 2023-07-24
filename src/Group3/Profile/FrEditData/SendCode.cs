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
    public partial class SendCode : Form
    {
        public string newPassword;
        public SendCode()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Method.SenCode.ConfirmCode(txtCode.Text))
            {
                label8.Visible = false;
                txtCode.BorderColor= Color.Black;
                DataAcces.DataAcces dt = new DataAcces.DataAcces();
                await dt.UpdatePassword(newPassword, Method.Stored.ur.Email);
                MessageBox.Show("Bạn đã cập nhật mật khẩu thành công", "Succes");
                Close();
            }
            else
            {
                label8.Visible = true;
                txtCode.BorderColor = Color.Red;
            }
        }
        int seconds = 0;
        private async void SendCode_Load(object sender, EventArgs e)
        {
           seconds = 60;
           await Method.SenCode.sendEmail(Method.Stored.ur.Name, Method.Stored.ur.Email);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = (seconds--).ToString();
            if (seconds < 0)
            {
                timer1.Stop();
                seconds = 60;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCode_Load(sender, e);
            guna2Button1_Click(sender, e);
        }
    }
}
