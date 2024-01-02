namespace B.Helpers
{


    public class TextHelpers
    {
        public static async Task<string> ConvertPathToTextAsync(string path)
        {
            if (!File.Exists(path))
            {
               return string.Empty;
            }
            return await File.ReadAllTextAsync(path);
        }

    }

}