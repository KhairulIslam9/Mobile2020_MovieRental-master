using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Models
{
    public class Film : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ReleaseYear { get; set; }
        public int LanguageId { get; set; }
        public int RentalDuration { get; set; }
        public decimal RentalPrice { get; set; }
        public int Lenght { get; set; }
        public decimal RemplacementCost { get; set; }
        public int RatingId { get; set; }

        public Film()
        {

        }
        public Film(string Title, string Description, int ReleaseYear, int LanguageId, int RentalDuration,
            decimal RentalPrice, int Lenght, decimal RemplacementCost, int RatingId)
        {
            this.Title = Title;
            this.Description = Description;
            this.ReleaseYear = ReleaseYear;
            this.LanguageId = LanguageId;
            this.RentalDuration = RentalDuration;
            this.RentalPrice = RentalPrice;
            this.Lenght = Lenght;
            this.RemplacementCost = RemplacementCost;
            this.RatingId = RatingId;
        }
        public Film(int Id, string Title, string Description, int ReleaseYear, int LanguageId, int RentalDuration,
            decimal RentalPrice, int Lenght, decimal RemplacementCost, int RatingId):
            this(Title,Description,ReleaseYear,LanguageId,RentalDuration,RentalPrice,Lenght,RemplacementCost,RatingId)
        {
            this.Id = Id;
        }
    }
}
