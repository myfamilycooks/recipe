using System;

namespace Recipe.Server.Entities
{
    public abstract class AuditedEntity {
        public abstract Guid ID { get; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}