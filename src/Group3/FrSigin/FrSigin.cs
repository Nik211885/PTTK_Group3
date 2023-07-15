using Group3.FrSigin.Account;
using Group3.Method;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.FrSigin
{
    public partial class FrSigin : Form
    {
        public FrSigin()
        {
            InitializeComponent();
        }
      
       
        private void Log_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            if (Properties.Settings.Default.email == null||Properties.Settings.Default.email.Length==0)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked=true;
                emailLog.Text = Properties.Settings.Default.email;
                passwordLog.Text = Properties.Settings.Default.password;
            }
        }

        private void regirst_Click(object sender, EventArgs e)
        {
            if (regirst.Text == "Đăng nhập")
            {
                regirst.Text = "Đăng kí";
                tabControl1.SelectedIndex = 1;
                NameUser.Focus();
            }
            else
            {
                regirst.Text = "Đăng nhập";
                tabControl1.SelectedIndex = 0;
                emailLog.Focus();
            }
        }
        private void success(Panel panel, Guna2TextBox textBox,ref bool check)
        {
            panel.Visible = false;
            textBox.BorderColor = Color.Black;
            check = true;
        }
        private void failure(Panel panel, Guna2TextBox textBox,ref bool check)
        {
            panel.Visible = true;
            textBox.BorderColor = Color.Red;
            check = false;
        }
        bool checkEmail;
        private void ValidateEmail(string email,Panel panel,Guna2TextBox textBox)
        {
            if(Method.ValidateValue.isEmail(email))
            {
                success(panel, textBox, ref checkEmail);
            }
            else
            {
                failure(panel, textBox, ref checkEmail);
            }
        }
        bool checkPassword;
        private void ValidatePassWord(string password, Panel panel,Guna2TextBox textBox) 
        {
            if (Method.ValidateValue.isPassword(password)) 
            { 
                success(panel, textBox, ref checkPassword);
            }
            else
            {
                failure(panel, textBox, ref checkPassword);
            }
        }
        bool checkConfirmPassword;
        private void ValidateConfirmPassword(string confirmPassword,Panel panel,Guna2TextBox textBox ,string password)
        {
            if (confirmPassword == password)
            {
                success (panel, textBox, ref checkConfirmPassword);
            }
            else
            {
                failure (panel, textBox, ref checkConfirmPassword);
            }
        }
        bool checkName;
        private void ValidateName(string name,Panel panel,Guna2TextBox textBox)
        {
            if (Method.ValidateValue.isName(name))
            {
                success(panel,textBox, ref checkName);
            }
            else
            {
                failure(panel, textBox,ref checkName);
            }
        }
        int seconds;
        string a;
        private async Task sendEmail(string name,string email)
        {
            seconds = 60;       
            Random rd = new Random();
            var t = rd.Next(100000, 999999).ToString();
            a = t;
          
            await Method.MailServer.SendEmail(name, email,t);
            
            tabControl1.SelectedIndex = 3;
            timer1.Start();
        }
        bool status;
        List<User> userregirst = new List<User>();
        private async void sigUp_Click(object sender, EventArgs e)
        {
            ValidateEmail(EmailSig.Text, panel2, EmailSig);
            ValidatePassWord(Password.Text, panel6, Password);
            ValidateConfirmPassword(confirmPassword.Text, panel5, confirmPassword, Password.Text);
            ValidateName(NameUser.Text, panel7, NameUser);
            if (checkName && checkPassword && checkConfirmPassword && checkEmail)
            {
                status = false;
                userregirst.Add(new User { Email = EmailSig.Text, Password = Password.Text ,Name=NameUser.Text});
                await sendEmail(userregirst[0].Name, userregirst[0].Email);
            }
        }
        List<User> useSig = new List<User>();
        private async void login_Click(object sender, EventArgs e)
        {
            if (!Method.ValidateValue.isEmail(emailLog.Text.Trim()) || !Method.ValidateValue.isPassword(passwordLog.Text.Trim()))
            {
                panel4.Visible = true;
            }
            else
            {
                DataAcces.DataAcces db = new DataAcces.DataAcces();
                useSig= await db.getInforUsre(emailLog.Text);
                if (passwordLog.Text == useSig[0].Password)
                {
                    panel4.Visible = false;
                    MessageBox.Show(this, "Chúc bạn một ngày tốt lành", $"Xin chào {useSig[0].Name}",MessageBoxButtons.OK);
                    if (checkBox1.Checked)
                    {
                        Properties.Settings.Default.email = emailLog.Text;
                        Properties.Settings.Default.password=passwordLog.Text;
                        Properties.Settings.Default.Save();
                    }
                    Stored.ur = useSig[0];
                    Close();
                }
                else
                {
                    panel4.Visible = true;
                }
            }
        }
        List<User> usersforgot = new List<User>();
        private async void forgot_Click(object sender, EventArgs e)
        {
            ValidateEmail(emailForgot.Text, panel1, emailForgot);
            if (checkEmail)
            {
                DataAcces.DataAcces db = new DataAcces.DataAcces();
                usersforgot = await db.getInforUsre(emailForgot.Text);
                if (usersforgot.Count>0)
                {
                    panel1.Visible = false;
                    emailForgot.BorderColor = Color.Black;
                    status = true;
                    await sendEmail(usersforgot[0].Name, usersforgot[0].Email);
                    tabControl1.SelectedIndex = 3;
                }
                else
                {
                    panel1.Visible = true;
                    emailForgot.BorderColor = Color.Red;
                }
            }
        }
       

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(!checkBox1.Checked) {
                Properties.Settings.Default.email = null;
                Properties.Settings.Default.password = null;
                Properties.Settings.Default.Save();
            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private async void verify_Click(object sender, EventArgs e)
        {
            if (time.Text=="0")
            {
                panel3.Visible = true;label19.Text = "Mã xác minh đã hết hạn";
            }
            else
            {
                
                if (txtVerify.Text == a)
                {
                    panel3.Visible=false;
                    if (!status)
                    {
                        try
                        {
                            DataAcces.DataAcces dt = new DataAcces.DataAcces();
                            await dt.InsertAccont(userregirst[0].Name, userregirst[0].Email, userregirst[0].Password);
                            MessageBox.Show("Bạn đã tạo tài khoản thành công", "Succes", MessageBoxButtons.OK);
                            tabControl1.SelectedIndex = 1;
                        }
                        catch (Exception ex){ MessageBox.Show(ex.Message); };
                    }
                    else
                    {
                        tabControl1.SelectedIndex = 4;
                    }
                }
                else
                {
                    panel3.Visible = true; label19.Text = "Mã xác minh không hợp lệ";
                }
            }
        }

        private async void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!status)
            {
                await sendEmail(userregirst[0].Name, userregirst[0].Email);
            }
            else
            {
                await sendEmail(usersforgot[0].Name, usersforgot[0].Email);
            }
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            ValidatePassWord(txtUpdatePassword.Text,panel8,txtUpdatePassword);
            ValidateConfirmPassword(txtPassWordConfirm.Text, panel9, txtPassWordConfirm, txtUpdatePassword.Text);
            if (checkPassword && checkConfirmPassword)
            {
                DataAcces.DataAcces dt = new DataAcces.DataAcces();
                try
                {
                    await dt.UpdatePassword(txtUpdatePassword.Text, usersforgot[0].Email);
                    MessageBox.Show("Bạn đã cập nhật mật khẩu thành công","Succes",MessageBoxButtons.OK);
                    tabControl1.SelectedIndex = 1;
                }
                catch { };
            }
        }

        private void regirst_TabIndexChanged(object sender, EventArgs e)
        {
            regirst_Click(sender, e);
        }

        private void ForgotPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}
