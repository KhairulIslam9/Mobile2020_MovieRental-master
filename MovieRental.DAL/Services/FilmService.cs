using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace MovieRental.DAL.Services
{
    public class FilmService : ServiceBase<int, Film>
    {

        private Film Converter(SqlDataReader reader)
        {
            return new Film(

                (int)reader["FilmId"],
                reader["Title"].ToString(),
                reader["Description"].ToString(),
                (int)reader["ReleaseYear"],
                (int)reader["LanguageId"],
                (int)reader["RentalDuration"],
                (decimal)reader["RentalPrice"],
                (int)reader["Length"],
                (decimal)reader["ReplacementCost"],
                (int)reader["RatingId"]
                );
        }
        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Film> GetAll()
        {
            Command cmd = new Command("GetAllFilm", true);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByActor(string LastName)
        {
            Command cmd = new Command("GetFilmByActor", true);
            cmd.AddParameter("LastName", LastName);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByCategory(string cat)
        {
            Command cmd = new Command("GetFilmByCategory", true);
            cmd.AddParameter("Cat", cat);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByKeyWord(string keyWord)
        {
            Command cmd = new Command("GetFilmByKeyWord", true);
            cmd.AddParameter("KeyWord", keyWord);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByLanguage(string lang)
        {
            Command cmd = new Command("GetFilmByLanguage", true);
            cmd.AddParameter("Language", lang);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByTitle(string title)
        {
            Command cmd = new Command("GetFilmByTitle", true);
            cmd.AddParameter("Title", title);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public override Film GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Film entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Film entity)
        {
            throw new NotImplementedException();
        }
    }
}
