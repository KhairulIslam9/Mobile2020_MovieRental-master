﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public string Token { get; set; }

        public Customer()
        {

        }
        public Customer(string lastName, string firstName, string email)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
        }
        public Customer(string lastName,string firstName, string email,string passwd)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Passwd = passwd;
        }
        internal Customer(int id, string lastName, string firstName, string email) :
            this(lastName, firstName, email)
        {
            Id = id;
        }
        internal Customer(int id, string lastName, string firstName, string email, string passwd):
            this(lastName, firstName, email, passwd)
        {
            Id = id;
        }
    }
}
