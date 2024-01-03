using GuessTheNumber.Interfaces;

namespace GuessTheNumber.DTO
{
    public class GuessTheNumberConfigurate : IGuessTheNumberConfigurate
    {
        public int NumberAttempts { get; set; }

        public Range Range { get; set; }

        public GuessTheNumberConfigurate(int numberAttempts, Range range)
        {
            NumberAttempts = numberAttempts;
            Range = range;
        }
    }
}
