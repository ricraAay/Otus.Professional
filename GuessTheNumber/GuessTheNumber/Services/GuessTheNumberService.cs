using GuessTheNumber.Interfaces;
using GuessTheNumber.Enums;

namespace GuessTheNumber.Services
{
    public class GuessTheNumberService : IGuessTheNumberService
    {
        private readonly IGuessTheNumberConfigurate _configurate;

        private readonly IGuessTheNumberValidate _validate;

        private readonly IGuessTheNumberGenerate _generate;

        public GuessTheNumberService(
            IGuessTheNumberConfigurate configurate,
            IGuessTheNumberValidate validate,
            IGuessTheNumberGenerate generate)
        {
            _configurate = configurate;
            _validate = validate;
            _generate = generate;
        }

        public void Execute()
        {
            var randomNumber = _generate.Generate(_configurate.Range);
            var numberAttempts = _configurate.NumberAttempts;

            Console.WriteLine("#Угадай число");

            while (0 != numberAttempts--)
            {
                Console.Write("Введите число: ");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    var validate = _validate.Validate(result, randomNumber);

                    if (validate == GuessTheNumberValidateType.Less)
                    {
                        Console.WriteLine("Меньше отгадываемого числа");
                    }

                    if (validate == GuessTheNumberValidateType.More)
                    {
                        Console.WriteLine("Больше отгадываемого числа");
                    }

                    if (validate == GuessTheNumberValidateType.Equals)
                    {
                        Console.WriteLine("Вы выйграли");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("Вы проиграли");
        }
    }
}
