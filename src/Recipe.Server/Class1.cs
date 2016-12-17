using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Recipe.Server.Data;

namespace Recipe.Server
{
    public class RecipeServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<RecipeRepository>().As<IRecipeRepository>();
        }
    }
}
