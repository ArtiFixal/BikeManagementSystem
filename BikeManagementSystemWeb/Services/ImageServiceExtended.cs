using BikeManagementSystemLib;
using BikeManagementSystemLib.Exceptions;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;

namespace BikeManagementSystemWeb.Services
{
    /// <summary>
    /// Image service extended to handle <see cref="IFormFile">IFormFiles</see>.
    /// </summary>
    public class ImageServiceExtended : ImageService
    {
        public const long MAX_SIZE = 8 * 1024 * 1024;
        public static readonly Dictionary<string,string> ALLOWED_IMAGE_TYPES = new(){
            {".jpg","image/jpeg"},
            {".jpeg","image/jpeg"},
            {".png","image/png"},
            {".gif","image/gif"},
        };

        public ImageServiceExtended(BikeManagementDbContext context) : base(context){}

        private async Task<string> MoveFile(IFormFile file)
        {
            string fileName = GetUniqueFilename(file.FileName);
            string filePath = Path.Combine(Image.IMAGE_DIR,fileName);
            using(var stream = new FileStream(filePath,FileMode.CreateNew,FileAccess.Write,FileShare.None))
            {
                await file.CopyToAsync(stream)
                    .ConfigureAwait(false);
            }
            return fileName;
        }

        public async Task<long> AddImage(IFormFile imageFile)
        {
            //if (imageFile.Length==0||imageFile.Length>MAX_SIZE)
            var extension = Path.GetExtension(imageFile.FileName);
            if (!ALLOWED_IMAGE_TYPES.TryGetValue(extension,out var mime))
                throw new UnsupportedImageTypeException(extension);
            if(!imageFile.ContentType.Equals(mime,StringComparison.OrdinalIgnoreCase))
                throw new ImageTypeMismatchException(mime,extension);
            string imagePath = await MoveFile(imageFile)
                .ConfigureAwait(false);
            return await AddEntityAsync(new Image(imagePath))
                .ConfigureAwait(false);
        }

        public override async Task<long> AddEntityAsync(Image entity)
        {
            var toAdd = await context.AddAsync(entity);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return toAdd.Entity.Id;
        }
    }
}
