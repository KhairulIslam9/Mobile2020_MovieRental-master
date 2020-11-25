
using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MovieRental.DAL.Services
{
    public class RentalService : ServiceBase<int, Rental>
    {
        DataTable rentalData = new DataTable("Rental");
        

        public override bool Delete(int key)
        {
            
            throw new NotImplementedException();
        }

        public override IEnumerable<Rental> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Rental GetById(int key)
        {
            throw new NotImplementedException();
        }
        public int Basket(int customerId,params Film[] films)
        {
            DataTable filmId = new DataTable();
            filmId.Columns.Add(new DataColumn("FilmId", typeof(int)));

            foreach (Film film in films)
            {
                filmId.Rows.Add(film.Id);
            }

            Command cmd = new Command("CreateRental", true);
            cmd.AddParameter("CustomerId", customerId);
            cmd.AddParameter("FilmIds", filmId);
            return connection.ExecuteNonQuery(cmd);
        }

        public override int Insert(Rental entity )
        {
            throw new NotImplementedException();
        }

        public override bool Update(Rental entity)
        {
            throw new NotImplementedException();
        }
    }
}
