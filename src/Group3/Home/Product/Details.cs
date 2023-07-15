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
            InforProduct.Text = Method.MulitiLabel.Multi(Stored.pd.Infor,88);
            imgProduct.Image = Image.FromFile(Stored.pd.Img);
            NameFood.Text= Method.MulitiLabel.Multi(Stored.pd.Name,40);
            Id.Text= Stored.pd.Id;
            PricePromotion.Text = Method.ConverMoney.convertMoney((ulong)(Stored.pd.Price - Stored.pd.Price * Stored.pd.Promotion * 0.01)); 
            if (Stored.pd.Promotion == 0)
            {
                label5.Visible= false;
                Price.Visible = false;
                label7.Visible = false;
                Promotion.Visible = false;
                panel2.Visible = false;
                PricePromotion.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                PricePromotion.Location = new Point(297, 145);
            }
            else
            {
                Price.Text = Method.ConverMoney.convertMoney(Stored.pd.Price);
                Promotion.Text = Method.ConverMoney.convertMoney((ulong)(Stored.pd.Price * Stored.pd.Promotion * 0.01));
            }
            panel5.Location = new Point(7,NameFood.Size.Height+40);
            InforProduct.Location = new Point(17, NameFood.Size.Height + 275);
            panel2.Size = new System.Drawing.Size(Price.Size.Width, 1);
            panel1.Location = new Point(100 + Price.Size.Width, 70);
        }

        private void addToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
