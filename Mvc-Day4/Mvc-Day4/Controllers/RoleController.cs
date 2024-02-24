using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_Day4.Areas.Identity.Data;
using Mvc_Day4.Models;
using Mvc_Day4.Utilities;
using Mvc_Day4.ViewModels;

namespace Mvc_Day4.Controllers
{
    public class RoleController : Controller
    {
        private IdentityContext _context;
        private IMapper _mapper;

        public RoleController(IdentityContext contex,IMapper mapper)
        {
            _context = contex; 
            _mapper = mapper;
        }
        // [Authorize(Policy="Employeeone")]
        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

         [Authorize(Policy="Admin")]
        public IActionResult Admin()
        {
            var newmovie = new MovieViewModels
            {
                Movie = new Movie(),
                Movietypes = _context.MovieTypes.ToList()
            };

           
            return View(newmovie);
        }

        [Authorize(Policy="Admin")]
        public IActionResult Delete(int id)
        {
            var deletedmovie = _context.Movies.Find(id);
            _context.Movies.Remove(deletedmovie);
            _context.SaveChanges();
            return RedirectToAction("Index","Role");
        }

        [Authorize(Policy = "Manager")]

        public IActionResult Manager(int id)
        {
            var moviedetails = _context.Movies.Find(id);
            var movie = new MovieViewModels
            {
                Movie =moviedetails,
                Movietypes= _context.MovieTypes.ToList()
            };

            return View(movie);
        }

        [Authorize(Policy = "Med-Manager")]

        public IActionResult MedManager(int id )
        {
            var movie = _context.Movies.Include(m => m.MovieType).FirstOrDefault(m => m.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Save(Movie movie) 
        {
            ModelState.Remove("movie.MovieType");
            if (!ModelState.IsValid)
            {
                var viewmodel = new MovieViewModels { Movie = movie, Movietypes = _context.MovieTypes.ToList() };
                return View("MovieForm", viewmodel);
            }
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                _mapper.Map(movie, movieInDb);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Role");
        }
    }
}
