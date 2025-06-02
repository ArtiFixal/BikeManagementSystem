namespace BikeManagementSystemLib.Exceptions
{
    public class ImageTypeMismatchException : Exception
    {
        public ImageTypeMismatchException(string mime,string extension) : base($"Current image type: {mime} does not match extension: {extension}"){}
    }
}
