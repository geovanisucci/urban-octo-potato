using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        protected ActivityCreated()
        {

        }
        public  ActivityCreated(Guid id, Guid userId,
                                string category, 
                                string name,
                                string description)
        {
            Id = id;
            UserId = userId;
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
        }
    }
}