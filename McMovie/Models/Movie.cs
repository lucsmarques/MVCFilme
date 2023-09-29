using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace McMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gênero")]
        public string? Genre { get; set; }
        [Display(Name = "Preço")]
        public float Price { get; set; }
    }
}
