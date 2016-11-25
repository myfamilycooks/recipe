using System;
using Xunit;
using FluentAssertions;

namespace Tests
{
    public class Tests
    {
        [Fact(DisplayName = "RecipeService::GetRecipeDetail() Returns a Valid Recipe")]
        public void RecipeServiceGetRecipeDetailReturnsCorrectly()
        {
            var recipeService = new Recipe.Business.RecipeService();
            var recipe = recipeService.GetRecipeDetail(1);

            recipe.Should().NotBeNull();
        }
    }
}