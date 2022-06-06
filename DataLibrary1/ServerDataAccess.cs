using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataLibrary1
{
    public class ServerDataAccess : IServerDataAccess
    {
        public async Task<List<T>> LoadData <T, U>(string sql, U parameters, string connectionString)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

              
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }

            
        }

        public Task SaveData<T>(String sql, T parameters, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }
        public ServerDataAccess()
        {

        }

        
    }

    
}
