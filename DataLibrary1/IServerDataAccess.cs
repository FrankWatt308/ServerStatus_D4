using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary1
{
    public interface IServerDataAccess
    {
        
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);
    }
}