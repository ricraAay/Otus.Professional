namespace FileTask
{
    public class FileTask
    {
        public static async IAsyncEnumerable<Task<string>> CountTheNumberOfSpacesAsync(string path)
        {
            var fileEntries = Directory.GetFiles(path);

            foreach(var entry in fileEntries)
            {
                var text = await File.ReadAllTextAsync(entry);

                var fileName = entry.Replace($"{path}\\", string.Empty);
                var chars = Array.FindAll(text.ToCharArray(), chr => chr == ' ');

                yield return Task.Run(() => $"Наименование файла: {fileName}, количество пробелов: {chars.Length}");
            }
        }
    }
}
