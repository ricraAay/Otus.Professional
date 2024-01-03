using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Services
{
    public class GuessTheNumberGenerate : IGuessTheNumberGenerate
    {
        private readonly IGuessTheNumberRandom _random;

        public GuessTheNumberGenerate(IGuessTheNumberRandom random)
        {
            _random = random;
        }

        public int Generate(Range range)
        {
            // Прибавляем единцицу, т.к.
            // диапозон не включает в себя верхнюю границу
            return _random.Next(range.Start.Value, range.End.Value + 1);
        }
    }
}
