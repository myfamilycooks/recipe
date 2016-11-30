using System;

namespace Recipe.Server.Entities
{
    public class Yield : AuditedEntity
    {
        public override Guid ID { get { return YieldID; } }
        public Guid YieldID { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
    }
}