
using System.ComponentModel.DataAnnotations;

using static Catstagram.Server.Data.Validation.Cat;

namespace Catstagram.Server.Features.Cats.Models
{
    public class UpdateCatRequestModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(maxDescriptionLength)]
        public string Description { get; set; }
    }
}
