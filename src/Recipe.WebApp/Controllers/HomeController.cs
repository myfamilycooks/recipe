using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Recipe.WebApp.ViewModels;
using Recipe.Server.Business;

namespace Recipe.WebApp.Controllers
{
    public class HomeController : Controller
    {
        protected static Random RandomNumbers { get; set; }
        protected IRecipeService RecipeService { get; set; }
        public IActionResult Index()
        {
            if(RandomNumbers == default(Random))
                RandomNumbers = new Random();

            RecipeService = new RecipeService();
            var recipes = RecipeService.GetRecipeHeaders();
            return View(new HomeViewModel()
            {
                Recipes = recipes.ToList(),
                Featured = RecipeService.GetRecipeDetail(RandomNumbers.Next(10))
            });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
