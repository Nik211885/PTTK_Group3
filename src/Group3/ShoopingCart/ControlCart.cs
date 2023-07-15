using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.ShoopingCart
{
    public partial class ControlCart : UserControl
    {
        public ControlCart()
        {
            InitializeComponent();
        }
        private string nameFood;
        private ulong price;
        private int quantity;
        private string pathImage;
        //
        [Category("Data")]
        public string NameFood
        {
            get { return nameFood; }
            set { nameFood = value; nameProduct.Text=value;}
        }
        public ulong priceFood
        {
            get { return price; }
            set { price = value; Price.Text = Method.ConverMoney.convertMoney(value); }
        }
        public int QuanTitTy
        {
            get { return quantity; }
            set { quantity = value;numRicQuantity.Value = value; }
        }
        public string PathImage
        {
            get { return pathImage; }
            set { pathImage = value; Img.Image = Image.FromFile(value); }
        }

        private void ControlCart_Load(object sender, EventArgs e)
        {

        }
    }
}
