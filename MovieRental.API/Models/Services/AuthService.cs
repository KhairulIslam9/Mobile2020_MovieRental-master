using MovieRental.DAL.Models;
using MovieRental.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.API.Models.Services
{
    public class AuthService
    {
        private CustomerService _customerService;
        public bool Check(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string email, string passwd)
        { 
            return _customerService.Login(email, passwd);
        }

        public int Register(Customer customer)
        {
            return _customerService.Insert(customer);
        }

        public AuthService()
        {
            _customerService = new CustomerService();
        }
    }
}

