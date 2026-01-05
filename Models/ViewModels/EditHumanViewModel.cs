using System.ComponentModel.DataAnnotations;

namespace image_API.Models.ViewModels
{
    public class EditHumanViewModel
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Gender { get; set; }
        public byte[]? ExistingProfilePicture { get; set; }
        public IFormFile? ProfileImage { get; set; }

    }
}