using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe.CommonObject
{
    public class RecipeIngredient : Ingredient
    {
        public int RecipeId { get; set; }
        public double Quantity { get; set; }
        public string Units { get; set; }
    }
}
