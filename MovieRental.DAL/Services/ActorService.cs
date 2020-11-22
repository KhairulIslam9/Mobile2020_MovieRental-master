using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MovieRental.DAL.Services
{
    public class ActorService : ServiceBase<int, Actor>
    {
        private Actor Converter(SqlDataReader reader)
        {
            return new Actor(
                
                (int)reader["ActorId"],
                reader["LastName"].ToString(),
                reader["FirstName"].ToString()
                );
        }
        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override Actor GetById(int key)
        {
            Command cmd = new Command("GetActorById", true);
            cmd.AddParameter("Id", key);

            return connection.ExecuteReader<Actor>(cmd, Converter).FirstOrDefault();
        }

        public IEnumerable<Actor> GetByFilm(string title)
        {
            Command cmd = new Command("GetActorByFilm", true);
            cmd.AddParameter("Title", title);

            return connection.ExecuteReader<Actor>(cmd, Converter);
        }

        public IEnumerable<Actor> GetByIntial(char first, char last)
        {
            Command cmd = new Command("GetActorbyInitial", true);
            cmd.AddParameter("FirstL", first);
            cmd.AddParameter("LastL", last);

            return connection.ExecuteReader<Actor>(cmd, Converter);
        }
        public override IEnumerable<Actor> GetAll()
        {
            Command cmd = new Command("GetAllActor", true);

            return connection.ExecuteReader<Actor>(cmd, Converter);
        }


        public override int Insert(Actor entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Actor entity)
        {
            throw new NotImplementedException();
        }

        

    }
}
