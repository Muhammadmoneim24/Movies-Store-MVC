using AutoMapper;
using Mvc_Day4.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mvc_Day4.Utilities
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Movie, Movie>();
        }
    }
}
