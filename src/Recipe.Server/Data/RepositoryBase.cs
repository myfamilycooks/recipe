using System;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace Recipe.Server.Data
{
    public class RepositoryBase<T>
    {
        protected ICommandBuilderService CommandBuilder { get; set; }
        public RepositoryBase(ICommandBuilderService commandBuilderService)
        {
            CommandBuilder = commandBuilderService;
        } 
        public async Task<NpgsqlConnection> GetConnection(bool open = false)
        {
            var connection = new NpgsqlConnection("ConnectionStringHere");
            if (open)
                await connection.OpenAsync();
            return connection;
        }

        public async Task<T> GetById(Guid id)
        {
            var connection = await GetConnection(true);
            return await connection.QuerySingleAsync<T>(CommandBuilder.BuildSelectById<T>(), new { id });
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
}