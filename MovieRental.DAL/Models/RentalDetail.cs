using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    //Pour le moment pas besoin
    public class RentalDetail: IEntity<int>
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public decimal RentalPrice { get; set; }
        public DateTime DateTime { get; set; }

        public RentalDetail(int v1, int v2, decimal v3, DateTime dateTime)
        {
            this.Id = v1;
            this.FilmId = v2;
            this.RentalPrice = v3;
            this.DateTime = dateTime;
        }

        
    }
}
