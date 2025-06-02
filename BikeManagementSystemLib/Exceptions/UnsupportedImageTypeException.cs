namespace BikeManagementSystemLib.Exceptions
{
    public class UnsupportedImageTypeException : Exception
    {
        public UnsupportedImageTypeException(string imageType) : base($"Image type: {imageType} is unsupported"){}
    }
}
