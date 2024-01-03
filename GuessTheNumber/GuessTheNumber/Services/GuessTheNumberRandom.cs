using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Services
{
    public class GuessTheNumberRandom : Random, IGuessTheNumberRandom
    {
        public new int Next(int min, int max)
        {
            return base.Next(min, max);
        }
    }
}
