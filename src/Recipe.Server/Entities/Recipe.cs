using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe.Server.Entities
{
    public class Recipe : AuditedEntity
    {
        public override Guid ID { get { return RecipeID; } }
        public Guid RecipeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AccessKey { get; set; }
        public Guid OrganizationID { get; set; }
        public Guid CategoryID { get; set; }

        public virtual IList<RecipeIngredient> Ingredients { get; set; }
        public virtual IList<Yield> Yields { get; set; }

        public virtual Category Category { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
