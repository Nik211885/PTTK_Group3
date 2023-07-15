using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using Group3.Method;
using Guna.UI2.WinForms;
using Group3.ShoopingCart;
using System.Runtime.InteropServices;
using Group3.Home.Product;
using DeviceId;
using DeviceId.Encoders;
using DeviceId.Formatters;
using Group3.FrSigin.Account;
using System.Web.UI.WebControls;
using Group3.DataAcces;

namespace Group3.Home
{
    public partial class Home : Form
    {
        List<Product.Product> product= new List<Product.Product>();
        public Home()
        {
            InitializeComponent();
        }
        private void addMenu(List<Product.Product>list )
        {
            foreach(var i in list)
            {
                i.Margin = new Padding(11, 11, 11, 11);
                flowLayoutPanel1.Controls.Add(i);
            }
        }
        private async void Login_Load(object sender, EventArgs e)
        {
            DataAcces.DataAcces db = new DataAcces.DataAcces();
            product = await db.getInforProduct();
            addMenu(product);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Size.Width > 1149)
            {
                flowLayoutPanel1.Location = new System.Drawing.Point((this.Width - flowLayoutPanel1.Width) / 2, 135);
            }
            if (flowLayoutPanel1.Location.X >70 && flowLayoutPanel1.Size.Width <= 1149)
            {
                flowLayoutPanel1.Location = new System.Drawing.Point(55, 130);
                flowLayoutPanel1.Size = flowLayoutPanel1.MinimumSize;
            }
        }
        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            using(FormCart cart = new FormCart())
            {
                h = this;
                this.Hide();
                cart.ShowDialog();
            }
            h.Show();
            
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text.Length >= 3)
            {
                var item = from pd in product
                           where Method.RemoveUnicode.unicode(pd.Name.ToLower()).Contains(Method.RemoveUnicode.unicode(TxtSearch.Text.ToString().ToLower()))
                           select pd;
                flowLayoutPanel1.Controls.Clear();
                addMenu(item.ToList());
            }
            if (TxtSearch.Text == null || TxtSearch.Text.Length == 0)
            {
                addMenu(product);
            }

        }

        private void Account_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            using(FrSigin.FrSigin lg = new FrSigin.FrSigin())
            {
                home = this;
                this.Hide();
                lg.ShowDialog();
            }
            //aaajsa
            if (Stored.ur != null)
            {
                if (Stored.ur.Img==null||Stored.ur.Img.Trim().Length==0)
                {
                }
                else
                {
                    Account.Image = System.Drawing.Image.FromFile(Stored.ur.Img);
                }
            }
            home.Show();
        }
    }
}
