using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeManagementSystemWeb.Controllers
{
    [Route("Images")]
    public class ImageController : Controller
    {
        private readonly ImageServiceExtended imageService;

        public ImageController(ImageServiceExtended imageService)
        {
            this.imageService = imageService;
        }

        [HttpGet("{id?}")]
        public async Task<IActionResult> GetImage(long id)
        {
            try
            {
                Image image = await imageService.GetEntityAsync(id);
                string imagePath = Path.Combine(Image.IMAGE_DIR, image.Path);
                var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                return File(stream, "application/octet-stream");
            }
            catch(EntityNotFoundException e)
            {

                return NotFound(e.Message);
            }
        }
    }
}
