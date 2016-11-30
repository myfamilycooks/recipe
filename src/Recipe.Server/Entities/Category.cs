using System;

namespace Recipe.Server.Entities
{
    public class Category : AuditedEntity
    {
        public override Guid ID { get { return CategoryID; } }
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public string AccessKey { get; set; }
    }
}