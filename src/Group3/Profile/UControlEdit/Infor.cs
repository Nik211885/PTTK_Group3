using Group3.Profile.FrEditData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group3.Profile.UControlEdit
{
    public partial class Infor : UserControl
    {
        public event EventHandler btnChnage;
        public Infor()
        {
            InitializeComponent();
        }
        private string name;
        private string nameInfor;
        private Image img;
        [Category("Data")]
        public string setName
        {
            get { return name; } set { name = value;FrName.Text = value; }
        }
        [Category("Data")]
        public string setNameInfor
        {
            get { return nameInfor; }
            set { nameInfor = value; FrInfromation.Text = value; }
        }
        [Category("Data")]
        public Image setImage
        {
            get { return img ; }
            set { img = value; FrImage.Image = value; }
        }

        private void Infor_Click(object sender, EventArgs e)
        {
            if (btnChnage == null)
            {
            }
            else
            {
                btnChnage.Invoke(this, new EventArgs());
            }
        }

        private void FrName_Click(object sender, EventArgs e)
        {
            Infor_Click(sender, e);
        }
    }
}
