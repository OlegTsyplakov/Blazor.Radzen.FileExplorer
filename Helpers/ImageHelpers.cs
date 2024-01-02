namespace B.Helpers{


public class ImageHelpers
    {
        public static async Task<string> ConvertFromPathToImageAsync(string path)
        {
            byte[] imageBytes = await File.ReadAllBytesAsync(path);

            if (imageBytes is null) 
            {
                return string.Empty;
            }
            return Convert.ToBase64String(imageBytes);      
        }
    }

}