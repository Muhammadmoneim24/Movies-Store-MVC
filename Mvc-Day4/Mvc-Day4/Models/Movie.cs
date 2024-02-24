using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Day4.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string Name { get; set; }
        public int PublishDate { get; set; }
        public string MovieStar { get; set; }

        //[Display(Name ="Enter The Category")]
        public string Category { get; set; }

        //[MoviesValidation]
        public double MovieLength { get; set; }

        [Range(1, 10)]
        public double Rate { get; set; }

        [ForeignKey("MovieType")]
        public int MovieTypeId { get; set; }
        public MovieType MovieType { get; set; }

    }
}
