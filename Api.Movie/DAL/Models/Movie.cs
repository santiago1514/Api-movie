using Api.Movie.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Api.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required] 
        [Display(Name = "Nombre de la Pelicula")] 
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Clasification { get; set; }

    }
}