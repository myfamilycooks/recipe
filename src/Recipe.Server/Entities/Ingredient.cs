using System;

namespace Recipe.Server.Entities
{
    public class Ingredient : AuditedEntity
    {
        public override Guid ID { get { return IngredientID; } }
        public Guid IngredientID { get; set; }

        public string Name { get; set; }
        public string AccessKey { get; set; }
        public string Description { get; set; }
        public Guid CategoryID { get; set; }
    }
}