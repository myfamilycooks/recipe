using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipe.Server.Business;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe.WebApp.Controllers.Api
{
    [Route("api/[controller]")]
    public class RecipeHeaderController : Controller
    {
        private readonly RecipeService recipeService;

        public RecipeHeaderController()
        {
            this.recipeService = new RecipeService();
        }

        // GET: api/RecipeHeader
        [HttpGet]
        public IActionResult Get()
        {
            var recipeHeaders = recipeService.GetRecipeHeaders();

            return this.Ok(recipeHeaders);
        }
        
    }
}
