using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    public class Rating : IEntity<int>
    {
        public int Id { get; set; }
        public string Classement { get; set; }

        public Rating()
        {

        }
        public Rating(string classement)
        {
            Classement = classement;
        }
        public Rating(int id, string classement) : this(classement)
        {
            Id = id;
        }
    }
}
