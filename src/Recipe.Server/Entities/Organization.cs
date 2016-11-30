using System;

namespace Recipe.Server.Entities
{
    public class Organization : AuditedEntity
    {
        public override Guid ID { get { return OrganizationID; } }
        public Guid OrganizationID { get; set; }
        public string Name { get; set; }
        public string AccessKey { get; set; }
    }
}