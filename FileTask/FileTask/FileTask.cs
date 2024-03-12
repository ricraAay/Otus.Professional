namespace FileTask
{
    public class FileTask
    {
        public static async IAsyncEnumerable<(string, int)> CountTheNumberOfSpacesAsync(string path)
        {
            var fileEntries = Directory.GetFiles(path);

            foreach(var entry in fileEntries)
            {
                var text = await File.ReadAllTextAsync(entry);

                var fileName = entry.Replace($"{path}\\", string.Empty);
                var chars = Array.FindAll(text.ToCharArray(), chr => chr == ' ');

                yield return (fileName, chars.Length);
            }
        }
    }
}
