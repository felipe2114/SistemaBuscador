using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBuscador.Repositories
{
    public class LoginRepository
    {
        public bool UserExist(string usuario, string password) 
        {
            bool result = false;
            string connectionString = "server=localhost\\SQLEXPRESS; database=PRO402BD;Integrated Security=true; ";
            using SqlConnection sql = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("select count (*) from usuarios where usuario = '"+usuario+"' and password= '"+password+"'", sql);
            sql.Open();
            int bdResult = (int) cmd.ExecuteScalar();
            if (bdResult > 0) 
            { 
                result = true;
            }
            
            return result;
        }
    }
}
