using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Dapper;

namespace Recipe.Server.Data
{
    public class DapperRepositoryAsync<T> where T : class, new()
    {
        public async Task<IEnumerable<T>> GetAll()
        {
            var connection = await GetConnection();
            return await connection.QueryAsync<T>("select * from Recipes");
        }

        private async Task<NpgsqlConnection> GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
