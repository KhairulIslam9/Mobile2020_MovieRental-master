using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    public class Actor : IEntity<int>
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Actor(int actorId, string firstName, string lastName)
        {
            ActorId = actorId;
            FirstName = firstName;
            LastName = lastName;
        }

        internal Actor(int id, int actorId, string firstName, string lastName):
            this(actorId,firstName,lastName)
        {
            Id = id;
        }
    }
}
