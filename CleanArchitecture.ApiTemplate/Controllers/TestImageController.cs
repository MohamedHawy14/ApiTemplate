using Microsoft.AspNetCore.Mvc;
using Utilites;

namespace CleanArchitecture.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestImageController : ControllerBase
    {
        [HttpPost("image")]
        public async Task<IActionResult> UploadImage(IFormFile image)
        {
            try
            {
                if (image == null || image.Length == 0)
                    return BadRequest("Please upload a valid image.");

                var imageUrl = await ImageHelper.SaveImageAsync(image);

                return Ok(new { imageUrl });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error uploading image: {ex.Message}");
            }
        }

        [HttpDelete("image")]
        public IActionResult DeleteImage([FromQuery] string imageUrl)
        {
            try
            {
                bool deleted = ImageHelper.DeleteImage(imageUrl);
                return deleted
                    ? Ok("Image deleted successfully.")
                    : NotFound("Image not found.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error deleting image: {ex.Message}");
            }
        }

        [HttpPut("image")]
        public async Task<IActionResult> ReplaceImage(IFormFile newImage, [FromQuery] string? oldImageUrl)
        {
            try
            {
                if (newImage == null || newImage.Length == 0)
                    return BadRequest("Please upload a valid new image.");

                var newImageUrl = await ImageHelper.ReplaceImageAsync(newImage, oldImageUrl);

                return Ok(new { newImageUrl });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error replacing image: {ex.Message}");
            }
        }

    }
}
