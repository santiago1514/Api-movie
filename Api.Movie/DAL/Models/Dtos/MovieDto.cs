using System.ComponentModel.DataAnnotations;

namespace Api.Movie.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la pelicula es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Clasification { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
