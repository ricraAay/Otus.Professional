namespace FileFound
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fileFound = new FileFound();

                fileFound.FileFoundEvent += (object? sender, FileArgs arg) =>
                {
                    Console.WriteLine($"Наименование файла: {arg.Name}");
                };

                fileFound.Found();

                // Вызов метода с условие для остановки поиска
                // fileFound.Found(predicate: (name => name == "photo.jpg"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
