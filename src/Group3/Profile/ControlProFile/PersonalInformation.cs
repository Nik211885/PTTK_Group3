using Group3.FrSigin.Account;
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

namespace Group3.Profile.ControlProFile
{
    public partial class PersonalInformation : UserControl
    {
        public PersonalInformation()
        {
            InitializeComponent();
            
        }

        private void infor5_btnChnage(object sender, EventArgs e)
        {
            using(EditAvtatr ed = new EditAvtatr()) {
                {
                    Image img = infor5.setImage;
                    ed.setAvater(img);
                    ed.ShowDialog();
                } }
            PersonalInformation_Load(sender, e);
        }

        private void infor8_btnChnage(object sender, EventArgs e)
        {
            using (EditName edit = new EditName())
            {
                string name = infor8.setNameInfor;
                edit.setName(name);
                edit.ShowDialog();
            }
            PersonalInformation_Load(sender, e);
        }


        private void infor9_btnChnage(object sender, EventArgs e)
        {
            using (EditBirthDay ed = new EditBirthDay())
            {
                string[] splitDate = infor9.setNameInfor.Split('/');
                ed.setDateTime(splitDate[0], splitDate[1], splitDate[2]);
                ed.ShowDialog();
            }
            PersonalInformation_Load(sender, e);
        }

        private void infor10_Click(object sender, EventArgs e)
        {
            using(EditMale ed = new EditMale())
            {
                string male = infor10.setNameInfor;
                ed.setCheck(male);
                ed.ShowDialog();
            }
            PersonalInformation_Load(sender, e);
        }


        private void infor7_btnChnage(object sender, EventArgs e)
        {
            using (EditPhone ed = new EditPhone())
            {
                string phone = infor7.setNameInfor;
                ed.setPhone(phone);
                ed.ShowDialog();
            }
            PersonalInformation_Load(sender, e);
        }

        private void infor5_Load(object sender, EventArgs e)
        {

        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            try
            {
                infor5.setImage = Image.FromFile(Method.Stored.ur.Img);
                infor8.setNameInfor = Method.Stored.ur.Name;
                infor9.setNameInfor = Method.Stored.ur.birthDay.ToString("dd/MM/yyyy");
                infor10.setNameInfor = Method.Stored.ur.Male;
                infor6.setNameInfor = Method.Stored.ur.Email;
                infor7.setNameInfor = Method.Stored.ur.Phone;
                infor1.setNameInfor = Method.Stored.ur.Address;
            }
            catch { }
        }
    }
}
