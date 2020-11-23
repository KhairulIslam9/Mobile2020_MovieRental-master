using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get;set;}

        public Category()
        {

        }
        public Category(string name)
        {
            this.Name = name;
        }
        internal Category(int idn, string name) : this(name)
        {
            Id = idn;
        }
    }
}
