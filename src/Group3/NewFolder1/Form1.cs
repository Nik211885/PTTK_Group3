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
                string insert = $"insert into [dbo].[Product]\r\nvalues (N'3',25,N'[TẶNG TÚI HIGHLANDS COFFEE-màu ngẫu nhiên] Cà Phê Bột Truyền Thống Highlands Coffee 1KG',0,N'Dòng Cà phê hạt Full City Roast Highlands Coffee: cà phê rang vừa, phối trộn 2 loại hạt cà phê Arabica và Robusta. Những hạt cà phê hảo hạng trồng ở vùng cao nguyên Việt Nam được chọn lọc thủ công kỹ lưỡng Sự hòa trộn giữa hạt Arabica và Robusta theo công thức riêng của Highlands Coffee trong sản phẩm cà phê hạt Full City Roast mang lại vị cà phê thật đậm đà, hài hòa, quyện giữa vị đắng, vị chua, vị chát nhẹ cùng hương thơm dịu nhẹ giúp bạn thưởng thức trọn vẹn và tỉnh táo mỗi ngày. Sản phẩm dành cho cà phê pha máy.',N'{ofd.FileName}',25000)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                /*string select = "select img from Product";
                string path = (string)conn.ExecuteScalar(select);
                pictureBox2.Image=Image.FromFile(path);*/


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string a = Method.MulitiLabel.Multi("Xin chào các bạn mình tên là Ninh rất vui được gặp mọi người hôm nay", 15);

        }
    }
}
