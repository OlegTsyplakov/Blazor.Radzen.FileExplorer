using System.Drawing;

namespace B.Helpers{


public class ImageHelpers{

    public static string ConvertFromPathToImage(string path)
    {
    using (Image image = Image.FromFile(path))
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }
}

}