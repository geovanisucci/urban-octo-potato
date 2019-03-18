using System;

namespace Actio.Services.Activities.Domain.Models
{
    public class Activity
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public string Description { get; protected set; }
        public Guid UserId { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected Activity()
        {

        }
        public Activity(string name, string category, Guid userId, string description)
        {
            Id = Guid.NewGuid();
            Name = name.ToLowerInvariant();
            Category = category;
            UserId = userId;
            Description = description;
            CreatedAt = DateTime.UtcNow;
        }
    }
}