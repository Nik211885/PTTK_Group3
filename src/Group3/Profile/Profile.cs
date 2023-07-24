using Group3.Profile.ControlProFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3.Profile
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();

        }

        private void infor_Click(object sender, EventArgs e)
        {
            personalInformation1.BringToFront();
            senBakc();
        }
        private void senBakc()
        {
            nav.SendToBack();
            Close.BringToFront();
        }
        private void personalInformation1_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            changePassword1.BringToFront();
            senBakc();
        }
    }
}
