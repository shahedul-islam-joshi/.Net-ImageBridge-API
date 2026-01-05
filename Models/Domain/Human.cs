using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace image_API.Models.Domain
{
    public class Human
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Gender { get; set; }
        public byte[]? ProfilePicture { get; set; }
        [NotMapped]
        [Display(Name = "Upload Picture")]
        public IFormFile? ProfileImage { get; set; }
    }
}