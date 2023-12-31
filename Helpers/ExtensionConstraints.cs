namespace B.Helpers
{
    public class ExtensionConstraints
    {
      public static IEnumerable<string> ImageTypes => new List<string>() { ".bmp", ".jpg", ".png" };
      public static IEnumerable<string> TextTypes => new List<string>() { ".txt" };
    }
}
