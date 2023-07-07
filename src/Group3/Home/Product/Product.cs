using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3.Method;

namespace Group3.Home.Product
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        private string _id;
        private ulong _promotion;
        private string _infor;
        private bool _status;
        private string _name;
        private string _img;
        private ulong _price;
        public string Infor { get { return _infor; } set { _infor = value.Trim(); } }
        //
        public bool Status { get { return _status; } set { _status = value; } }
        public string Id { get { return _id; } set { _id = value.Trim(); } }


        [Category("Custum Food")]

        public ulong Promotion
        {
            get { return _promotion; }
            set { _promotion = value; PromotionFood.Text = $"{_promotion}%"; }
        }
        [Category("Custum Food")]
        public string Img
        {
            get { return _img; }
            set { _img = value;imgFood.Image = Image.FromFile(value); }
        }
        [Category("Custum Food")]
        public string Name
        {
            get { return _name; }
            set { _name = value.Trim();}
        }
        [Category("Custum Food")]
        public ulong Price
        {
            get { return _price; }
            set {_price = value;PriceFood.Text = Method.ConverMoney.convertMoney(value) ;}
        }
        [Category("Custum Food")]
        private void Product_Load(object sender, EventArgs e)
        {
            FoodPromotion.Text = Method.ConverMoney.convertMoney((ulong)(_price - (_price * _promotion * 0.01)));
            if (_promotion == 0)
            {
                PanelPromotion.Visible = false;
                PriceFood.Visible = false;
                panelLine.Visible = false;
            }
            string text = _name;
            int b=0;
            if (text == null || text.Length == 0)
            {

            }
            else
            {
                b = text.Length;
            }
            StringBuilder sb = new StringBuilder();
            if (b > 25)
            {
                int temp = 0;
                for(int i = 25; i >=0; i--)
                {
                    if (text[i]==' ') { temp = i;break; }
                }
                sb.Append(text.Substring(0, temp));
                sb.Append("\n");
                if (b > 47)
                {
                    sb.Append(text.Substring(temp+1, 25));
                    sb.Append("...");
                }
                else
                {
                    sb.Append(text.Substring(temp+1, b - temp));
                }

            }
            else
            {
                sb.Append(text);
            }
            NameProduct.Text = sb.ToString();
            int sizeLine = PriceFood.Size.Width;
            panelLine.Size = new System.Drawing.Size(sizeLine, 1);
            int a= FoodPromotion.Width;
            PriceFood.Location= new System.Drawing.Point(a+9, 231);
            panelLine.Location = new System.Drawing.Point(a + 9, 240);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            using (Group3.Home.Product.Details dl = new Group3.Home.Product.Details())
            {
                Group3.Home.Product.MethodProduct.ProductClick.pd = this;   
                dl.ShowDialog();
                
            }
        }

        private void Buy_Click(object sender, EventArgs e)
        {

        }
    }
}
