using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipe.WebApp.Controllers.Api;
using Recipe.Server.Entities;

namespace Recipe.WebApp.ViewModels
{
    public class HomeViewModel
    {
        public List<RecipeHeader> Recipes { get; set; } 
        public RecipeDetail Featured { get; set; }
    }
}
