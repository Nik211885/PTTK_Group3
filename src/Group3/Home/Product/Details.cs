using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Group3.Method;
namespace Group3.Home.Product
{
    public partial class Details : Form
    {

        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            InforProduct.Text = MethodProduct.ProductClick.pd.Infor;
            imgProduct.Image = Image.FromFile(MethodProduct.ProductClick.pd.Img);
            NameFood.Text=MethodProduct.ProductClick.pd.Name;
            Id.Text=MethodProduct.ProductClick.pd.Id;
            PricePRomotion.Text = Method.ConverMoney.convertMoney((ulong)(MethodProduct.ProductClick.pd.Price - MethodProduct.ProductClick.pd.Price * MethodProduct.ProductClick.pd.Promotion * 0.01)); 
            if (MethodProduct.ProductClick.pd.Promotion == 0)
            {
                label5.Visible= false;
                Price.Visible = false;
                label7.Visible = false;
                Promotion.Visible = false;
                panel2.Visible = false;
                PricePRomotion.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                PricePRomotion.Location = new Point(297, 145);
            }
            else
            {
                Price.Text = Method.ConverMoney.convertMoney(MethodProduct.ProductClick.pd.Price);
                Promotion.Text = Method.ConverMoney.convertMoney((ulong)(MethodProduct.ProductClick.pd.Price * MethodProduct.ProductClick.pd.Promotion * 0.01));
            }
        }
    }
}
