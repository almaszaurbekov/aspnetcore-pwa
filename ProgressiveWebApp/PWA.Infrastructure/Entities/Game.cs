using PWA.Infrastructure.Entities.Base;
using System;

namespace PWA.Infrastructure.Entities
{
    public class Game : AuditableEntity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public string Url { get; set; }
    }
}
