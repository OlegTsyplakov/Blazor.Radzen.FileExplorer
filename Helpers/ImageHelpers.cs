using System.Drawing;

namespace B.Helpers{


public class ImageHelpers
    {
        public static async Task<string> ConvertFromPathToImageAsync(string path)
        {
            byte[] imageBytes = await File.ReadAllBytesAsync(path);

            if (imageBytes is not null) 
            {
                return Convert.ToBase64String(imageBytes);
            }
            return string.Empty;
        }
    }

}