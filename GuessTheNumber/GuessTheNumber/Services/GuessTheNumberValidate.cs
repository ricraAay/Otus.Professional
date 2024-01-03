using GuessTheNumber.Interfaces;
using GuessTheNumber.Enums;

namespace GuessTheNumber.Services
{
    public class GuessTheNumberValidate : IGuessTheNumberValidate
    {
        public GuessTheNumberValidateType Validate(int value, int comparisonValue)
        {
            if (value < comparisonValue)
            {
                return GuessTheNumberValidateType.Less;
            }

            if (value > comparisonValue)
            {
                return GuessTheNumberValidateType.More;
            }

            return GuessTheNumberValidateType.Equals;
        }
    }
}
