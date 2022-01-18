using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Perpustakaan_Web_API.Models;

namespace LKS_Perpustakaan_Web_API.Controllers
{
    public class LoginController : ApiController
    {
        PCEntities row = new PCEntities();
        SqlConnection connection = new SqlConnection(Connection.conn);

        [HttpPost]
        public LoginModel login([FromBody]LoginModel model)
        {
            string sql = "select * from [dbo].[user] join anggota on [dbo].[user].id_user = anggota.id_user where level = 'anggota' and username = '" + model.username + "' and password = '" + model.password + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LoginModel l = new LoginModel();
                    l.id_user = Convert.ToInt32(reader["id_user"]);
                    l.name = reader["nama_lengkap"].ToString();
                    l.username = reader["username"].ToString();
                    return l;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
