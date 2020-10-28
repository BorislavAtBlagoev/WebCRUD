using System.ComponentModel.DataAnnotations;
using static Catstagram.Server.Data.Validation.Cat;


namespace Catstagram.Server.Features.Cats.Models
{
    public class CreateCatRequestModel
    {
        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(maxDescriptionLength)]
        public string Description { get; set; }
    }
}
