using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Group3.Home.Product.MethodProduct
{
    public class DataAcces
    {
        public List<Product> getInfor()
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConnectValue("DbCafe")))
            {
                List<Product> data = con.Query<Product>("dbo.ProductInsert").ToList();
                return data;
            }
        }
    }
}
