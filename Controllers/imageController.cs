using image_API.ImageRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace image_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class imageController : ControllerBase
    {
        private readonly IImageRepo imageRepo;

        public imageController(IImageRepo imageRepo)
        {
            this.imageRepo = imageRepo;
        }
        public IActionResult index()
        {
            return Ok("This is a Get API call");
        }
        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
            var imageURL = await imageRepo.UploadAsync(file);
            if (imageURL == null)
            {
                return Problem("Something went wrong", null, (int)HttpStatusCode.InternalServerError);
            }
            return new JsonResult(new { link = imageURL });
        }
    }
}
