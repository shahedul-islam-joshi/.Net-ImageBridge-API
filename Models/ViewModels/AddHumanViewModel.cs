using System.ComponentModel.DataAnnotations;

namespace image_API.Models.ViewModels
{
    public class AddHumanViewModel
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Gender { get; set; }
        public IFormFile? ProfileImage { get; set; }
    }
}