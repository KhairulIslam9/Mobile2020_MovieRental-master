using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string name { get;set;}

        public Category()
        {

        }
        public Category(string name)
        {
            this.name = name;
        }
        public Category(int idn, string name) : this(name)
        {
            Id = idn;
        }
    }
}
