using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFirst.Models
{
    [Display(Name="Фильм")]
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Необходимо заполнить название фильма")]
        [Display(Name = "Название фильма")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Display(Name = "Дата релиза")]
        [DataType(DataType.Date)]
        //[RegularExpression()]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Описание фильма")]
        [StringLength(1000)]
        [Compare("Title")]
        public string? Description { get; set; }
        [StringLength(30)]
        [Required]
        [Display(Name = "Жанр")]
        //[CustomValidation()]
        public string? Genre { get; set; }

        [Display(Name = "Цена")]
        [Range(1,1000)]
        public decimal Price { get; set; }

        public bool Preorder { get; set; }
    }
}
