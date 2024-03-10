using System.Diagnostics;

namespace FileTask
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            await foreach (var value in FileTask.CountTheNumberOfSpacesAsync(Log.WriteReadLine("Укажите путь: ")))
            {
                stopWatch.Start();

                Console.WriteLine($"{stopWatch} - {value.Result}");

                stopWatch.Restart();
            }
        }
    }
}
