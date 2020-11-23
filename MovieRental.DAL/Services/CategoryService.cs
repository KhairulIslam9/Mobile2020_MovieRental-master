using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace MovieRental.DAL.Services
{
    public class CategoryService : ServiceBase<int, Category>
    {

        private Category Converter(SqlDataReader reader)
        {
            return new Category(
                reader["Name"].ToString()
                );
        }
        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Category> GetAll()
        {
            Command cmd = new Command("GetAllCategory", true);

            return connection.ExecuteReader<Category>(cmd, Converter);
        }

        public override Category GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
