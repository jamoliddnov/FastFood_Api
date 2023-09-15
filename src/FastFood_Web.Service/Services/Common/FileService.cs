using FastFood_Web.Service.Helpers;
using FastFood_Web.Service.Interfaces.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace FastFood_Web.Service.Services.Common
{
    public class FileService : IFileService
    {
        private readonly string images = "images";
        private readonly string _rootPath;
        public FileService(IWebHostEnvironment webHostEnvironment)
        {

        }
        public async Task<string> SaveImageAsync(IFormFile image)
        {
            try
            {
                string imageName = ImageHelper.MakeImageName(image.FileName);
                string imagePath = Path.Combine(_rootPath, images, imageName);

                var stream = new FileStream(imagePath, FileMode.Create);

                try
                {
                    await image.CopyToAsync(stream);
                    return Path.Combine(_rootPath, imageName);
                }
                catch
                {
                    return "";
                }
                finally
                {
                    stream.Close();
                }

            }
            catch
            {
                return "";
            }
        }
    }
}
