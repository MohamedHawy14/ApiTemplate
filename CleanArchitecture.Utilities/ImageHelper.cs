using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;



namespace Utilites
{
    public static class ImageHelper
    {
        private static IHttpContextAccessor _httpContextAccessor = null!;
        private static IWebHostEnvironment _env = null!;
        private static readonly long _maxImageSize = 3 * 1024 * 1024; // 3MB
        private static readonly List<string> _allowedExtensions = new() { ".jpg", ".jpeg", ".png" };

        public static void Configure(IHttpContextAccessor accessor, IWebHostEnvironment env)
        {
            _httpContextAccessor = accessor;
            _env = env;
        }

        public static async Task<string> SaveImageAsync(IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
                throw new ArgumentException("Invalid image file.");

            string ext = Path.GetExtension(imageFile.FileName).ToLower();
            if (!_allowedExtensions.Contains(ext))
                throw new ArgumentException("Only .jpg, .jpeg, and .png files are allowed.");

            if (imageFile.Length > _maxImageSize)
                throw new ArgumentException("Image size cannot exceed 3MB.");

            
            string uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            string uniqueFileName = $"{Guid.NewGuid()}{ext}";
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            
            var request = _httpContextAccessor.HttpContext?.Request;
            string baseUrl = $"{request?.Scheme}://{request?.Host}";

            return $"{baseUrl}/uploads/{uniqueFileName}";
        }

       
        public static bool DeleteImage(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
                throw new ArgumentException("Invalid image URL.");

            try
            {
               
                var uri = new Uri(imageUrl);
                
                string relativePath = uri.AbsolutePath.TrimStart('/').Replace('/', Path.DirectorySeparatorChar);

                
                string filePath = Path.Combine(_env.WebRootPath, relativePath);

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }
            }
            catch
            {
                throw;
            }

            return false;
        }

        
        public static async Task<string> ReplaceImageAsync(IFormFile newImageFile, string? oldImageUrl)
        {
            
            if (!string.IsNullOrEmpty(oldImageUrl))
            {
                DeleteImage(oldImageUrl);
            }

            return await SaveImageAsync(newImageFile);
        }
    }
}


