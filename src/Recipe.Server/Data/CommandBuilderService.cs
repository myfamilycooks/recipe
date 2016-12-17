using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace Recipe.Server.Data
{
    public class CommandBuilderService : ICommandBuilderService
    {
        protected IMemoryCache MemoryCache { get; set; }
        public CommandBuilderService(IMemoryCache memoryCache)
        {
            MemoryCache = memoryCache;
        }
        public string BuildInsertAndReturnQuery<T>()
        {
            return $"insert into {GetTableName<T>()} ({GetListOfColumns<T>()}) values ({GetListOfColumns<T>("@")} returning * )";
        }

        public string GetTableName<T>()
        {
            return string.Empty;
        }

        public string GetListOfColumns<T>(string prefix = "")
        {
            var tableName = GetTableName<T>();
            var columns = new List<string>();

            if (!MemoryCache.TryGetValue($"{tableName}$Columns", out columns))
            {
                
            }

            var data = String.IsNullOrEmpty(prefix) ? columns.AsEnumerable() : columns.Select(s => $"{prefix}{s}");

            return string.Join(", ", data);           
        }

        public string BuildSelectById<T>()
        {
            return $"select * from {GetTableName<T>()} where id = @id";
        }
    }
}