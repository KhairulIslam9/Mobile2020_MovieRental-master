
using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MovieRental.DAL.Services
{
    public class RentalDetailService : ServiceBase<int, RentalDetail>
    {
        private RentalDetail Converter(SqlDataReader reader)
        {
            return new RentalDetail(
                (int)reader["RentalId"],
                (int)reader["FilmId"],
                (decimal)reader["RentalPrice"],
                (DateTime)reader["RentalDate"]
                );
        }
        public IEnumerable<RentalDetail> GetByCustomer(int customerId)
        {
            Command cmd = new Command("GetAllRentalDetailByCustomer", true);
            cmd.AddParameter("CustomerId", customerId);
            return connection.ExecuteReader<RentalDetail>(cmd, Converter);
        }
        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<RentalDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public override RentalDetail GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(RentalDetail entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(RentalDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
