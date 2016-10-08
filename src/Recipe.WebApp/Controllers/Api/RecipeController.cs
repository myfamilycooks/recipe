
using Microsoft.AspNetCore.Mvc;
using Recipe.Business;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe.WebApp.Controllers.Api
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private readonly RecipeService recipeService;
        public RecipeController()
        {
            this.recipeService = new RecipeService();
        }

        // GET api/values/5
        [HttpGet("{recipeId}")]
        public IActionResult Get(int? recipeId = null)
        {
            if (!recipeId.HasValue)
            {
                return this.BadRequest("recipeId not specified");
            }

            var recipe = this.recipeService.GetRecipeDetail(recipeId.Value);

            if (recipe == null)
            {
                return this.NotFound();
            }

            return this.Ok(recipe);
        }
        
    }
}
