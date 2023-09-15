namespace FastFood_Web.Service.Helpers
{
    public class ImageHelper
    {
        public static string MakeImageName(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string name = "IMG_" + Guid.NewGuid().ToString();
            return name + extension;
        }
    }
}

