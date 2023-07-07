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
using Group3.Home.Product.MethodProduct;
using Guna.UI2.WinForms;

namespace Group3.Home
{
    public partial class Home : Form
    {
        List<Product.Product> product= new List<Product.Product>();
        public Home()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();
            product = db.getInfor();
            foreach(var item in product)
            {
                item.Margin = new Padding(12, 12, 12, 12);
                flowLayoutPanel1.Controls.Add(item);
            }
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
                flowLayoutPanel1.Location = new System.Drawing.Point(50, 130);
                flowLayoutPanel1.Size = flowLayoutPanel1.MinimumSize;
            }
        }
    }
}
