using System;
using System.ComponentModel.DataAnnotations;

namespace PWA.Infrastructure.Entities.Base
{
    public class AuditableEntity<T> : AuditableEntity
    {
        [Key]
        public T Id { get; set; }
    }

    public class AuditableEntity
    {
        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        public bool Flag { get; set; } = false;

        [ScaffoldColumn(false)]
        public DateTime? DeletedDate { get; set; }
    }
}
