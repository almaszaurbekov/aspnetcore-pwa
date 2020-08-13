using PWA.Infrastructure.Entities.Base;
using PWA.Infrastructure.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PWA.Infrastructure.Entities
{
    public class Comment : AuditableEntity
    {
        [Key]
        public Guid CommentId { get; set; }
        public string Text { get; set; }
        public double Rate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}