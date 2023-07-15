using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Group3.Home.Product;
using System.Threading;
namespace Group3.DataAcces
{
    public class DataAcces
    {
        public async Task<List<Product>> getInforProduct()
        {
            return await Task.Run(() =>
            {
                using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConnectValue("DbCafe")))
                {
                    var data = con.Query<Product>("dbo.ProductInsert").ToList();
                    return data;
                }
            });
        }
        public async Task<List<FrSigin.Account.User>> getInforUsre(string email)
        {
            return await Task.Run(() =>
            {
                using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConnectValue("DbCafe")))
                {
                    var data = con.Query<FrSigin.Account.User>("dbo.SlectUser @Email", new { Email = email }).ToList();
                    return data;
                }
            });
        }
        public async Task UpdatePassword(string password,string email)
        {
            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConnectValue("DbCafe")))
            {
                await con.ExecuteAsync("dbo.updatePassword @password,@email", new { password = password, email=email });
            };
        }
        public async Task InsertAccont(string name,string email,string password)
        {
            using(IDbConnection con = new System.Data.SqlClient.SqlConnection(Helper.ConnectValue("DbCafe")))
            {
                await con.ExecuteAsync("dbo.createAccout @name, @password, @email",new { name = name,email = email, password = password });
            };
        }
    }
}
