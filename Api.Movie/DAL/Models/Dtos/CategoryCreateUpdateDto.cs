namespace Api.Movie.DAL.Models.Dtos
{
    public class MovieCreateUpdateDto
    {
        public string Name { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string Clasification { get; set; } = null!;
    }
}
