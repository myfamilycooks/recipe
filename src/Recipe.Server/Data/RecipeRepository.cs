using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Npgsql;
using Recipe.Server.Entities;

namespace Recipe.Server.Data
{
    public interface IDataRepositoryAsync<T>
    {
        Task<T> GetById(Guid id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task<List<T>> GetAll();
    }
    public interface IRecipeRepository : IDataRepositoryAsync<Entities.Recipe>
    {
        
    }

    public class RepositoryBase<T>
    {
        public async Task<NpgsqlConnection> GetConnection(bool open = false)
        {
            var connection = new NpgsqlConnection("ConnectionStringHere");
            if (open)
                await connection.OpenAsync();
            return connection;
        }

        /// <summary>
        /// inserts a row using dapper and CommandBuilder
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Insert(T entity)
        {
            var connection = await GetConnection(true);

            var sqlQuery = CommandBuilder.BuildInsertAndReturnQuery<T>();
            return await connection.QuerySingleAsync<T>(sqlQuery, entity);
        }

    }

    public static class CommandBuilder
    {
        public static string BuildInsertAndReturnQuery<T>()
        {
            return $"insert into {GetTableName<T>()} ({GetListOfColumns<T>()}) values ({GetListOfColumns<T>("@")} returning * )";
        }

        private static string GetTableName<T>()
        {
            return string.Empty;
        }

        private static string GetListOfColumns<T>(string prefix = "")
        {
            return String.Empty;
            
        }
    }
    public class RecipeRepository : RepositoryBase<Entities.Recipe>, IRecipeRepository
    {
        public async Task<Entities.Recipe> GetById(Guid id)
        {
            var connection = await GetConnection(true);
            return await connection.QuerySingleAsync<Entities.Recipe>("select * from recipes where id = @id", new {id});
        }


        public Task<Entities.Recipe> Update(Entities.Recipe entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Entities.Recipe entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entities.Recipe>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
