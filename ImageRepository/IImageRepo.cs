namespace image_API.ImageRepository
{
    public interface IImageRepo
    {
        Task<String> UploadAsync(IFormFile file);
    }
}
