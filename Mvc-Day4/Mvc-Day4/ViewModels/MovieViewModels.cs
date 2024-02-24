using Mvc_Day4.Models;

namespace Mvc_Day4.ViewModels
{
    public class MovieViewModels
    {
        public Movie Movie { get; set; }
        public IEnumerable<MovieType> Movietypes { get; set; }
    }
}
