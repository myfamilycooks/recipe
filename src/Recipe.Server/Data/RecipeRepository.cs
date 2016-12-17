using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Recipe.Server.Entities;

namespace Recipe.Server.Data
{
    public class RecipeRepository : RepositoryBase<Entities.Recipe>, IRecipeRepository
    {
        public RecipeRepository(ICommandBuilderService commandBuilder) : base(commandBuilder)
        {
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
