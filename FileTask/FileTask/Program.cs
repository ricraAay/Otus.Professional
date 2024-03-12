using System.Diagnostics;

namespace FileTask
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            Console.Write("Укажите путь: ");

            var path = Console.ReadLine();

            await foreach (var value in FileTask.CountTheNumberOfSpacesAsync(path))
            {
                stopWatch.Start();

                Console.WriteLine($"{stopWatch} - Наименование файла: {value.Item1}, количество пробелов: {value.Item2}");

                stopWatch.Restart();
            }
        }
    }
}
