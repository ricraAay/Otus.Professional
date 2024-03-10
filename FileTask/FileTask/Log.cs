namespace FileTask
{
    public class Log
    {
        public static string WriteReadLine(string message)
        {
            Console.Write(message);

            var readLine = Console.ReadLine();

            if (string.IsNullOrEmpty(readLine))
            {
                throw new ArgumentException(nameof(readLine));
            }

            return readLine;
        }
    }
}
