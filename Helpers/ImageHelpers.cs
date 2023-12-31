using System.Drawing;

namespace B.Helpers{


public class ImageHelpers{

    public static string ConvertFromPathToImage(string path)
    {
            using Image image = Image.FromFile(path);
            using MemoryStream m = new();
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();

            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
}

}