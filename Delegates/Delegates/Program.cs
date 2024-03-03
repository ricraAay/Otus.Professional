namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Bet>() 
            { 
                new(323),
                new(3535),
                new(7456745),
                new(53476),
                new(34363),
            };

            var value = list.GetMax(item => item.Value);

            Console.WriteLine($"Максимальная сумма: {value?.Value}");
        }
    }
}
