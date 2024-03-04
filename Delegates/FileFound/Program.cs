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

                var cancellationTokenSource = new CancellationTokenSource();

                // Вызов метода с условие для остановки поиска
                fileFound.Found(cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
