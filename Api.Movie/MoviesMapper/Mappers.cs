using Api.Movie.DAL.Models;
using Api.Movie.DAL.Models.Dtos;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();

            CreateMap<Api.Movies.DAL.Models.Movie, MovieDto>().ReverseMap();
            CreateMap<Api.Movies.DAL.Models.Movie, MovieCreateUpdateDto>().ReverseMap();
        }
    }
}
