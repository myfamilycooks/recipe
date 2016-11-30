using System;

namespace Recipe.Server.Entities
{
    public class RecipeIngredient : Ingredient
    {
        public override Guid ID { get { return RecipeIngredientID; } }
        public Guid RecipeIngredientID { get; set; }
        public string Note { get; set; }
        public string Group { get; set; }
        public string Units { get; set; }
        public double Quantity { get; set; }
    }
}