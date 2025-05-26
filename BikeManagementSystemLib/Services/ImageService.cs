using BikeManagementSystemLib.Models;

namespace BikeManagementSystemLib.Services
{
    /// <summary>
    /// Service related to images.
    /// </summary>
    public class ImageService : CrudService<long, Image>
    {
        public ImageService(BikeManagementDbContext context) : base(context,context.Images)
        {
            if (!Directory.Exists(Image.IMAGE_DIR))
                Directory.CreateDirectory(Image.IMAGE_DIR);
        }      

        /// <summary>
        /// Moves file to the <see cref="Image.IMAGE_DIR"/> 
        /// using given file name concatenated with current
        /// date: <i>{imageName_yyyyMMddHHmmss.extension}.</i>
        /// </summary>
        /// 
        /// <param name="image">Image to move</param>
        /// <returns>Path to moved file</returns>
        private string MoveFile(Image image)
        {
            string formatedDateNow = DateTime.Now.ToString("yyyyMMddHHmmss");
            string fileName = Path.GetFileNameWithoutExtension(image.Path) + 
                '_' + formatedDateNow + Path.GetExtension(image.Path);
            image.Path = fileName;
            string finalPath = Path.Combine(Image.IMAGE_DIR, fileName);
            File.Copy(image.Path, finalPath);
            return finalPath;
        }

        public long AddImage(string imagePath)
        {
            return AddEntity(new Image(imagePath));
        }

        public override long AddEntity(Image entity)
        {
            string movedPath=MoveFile(entity);
            try
            {
                long imageId = base.AddEntity(entity);
                return imageId;
            }
            catch(Exception)
            {
                File.Delete(movedPath);
                throw;
            }
        }

        public override Image EditEntity(Image entity)
        {
            Image oldImage = GetEntity(entity.Id);
            Image updatedImage = base.EditEntity(entity);
            string oldImagePath = Path.Combine(Image.IMAGE_DIR, oldImage.Path);
            File.Delete(oldImagePath);
            MoveFile(entity);
            return updatedImage;
        }

        public override void DeleteEntity(long entityID)
        {
            Image image = GetEntity(entityID);
            string imagePath=Path.Combine(Image.IMAGE_DIR,image.Path);
            context.Images.Remove(image);
            File.Delete(imagePath);
        }
    }
}
