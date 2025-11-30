using System.ComponentModel.DataAnnotations;

namespace Api.Movie.DAL.Models
{
    public class Movie
    {
        [Required] 
        [Display(Name = "Nombre de la Pelicula")] 
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Clasification { get; set; }
    }
}
