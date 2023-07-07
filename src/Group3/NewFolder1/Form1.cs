using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Group3.Home.Product.MethodProduct;
using System.Data.SqlClient;

namespace Group3.NewFolder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                
                SqlConnection conn = new SqlConnection("Server=DESKTOP-HEENP7A;Database=MyCafeGroup3;Trusted_Connection=True;");
                conn.Open();
                string insert = $"insert into [dbo].[Product]\r\nvalues (N'3',30,N'Trà sữa trân trâu đen',1,N'Hôm nay duy nhất hôm nay mua 2 tặng 1',N'{ofd.FileName}',30000)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                /*string select = "select img from Product";
                string path = (string)conn.ExecuteScalar(select);
                pictureBox2.Image=Image.FromFile(path);*/


            }

        }
    }
}
