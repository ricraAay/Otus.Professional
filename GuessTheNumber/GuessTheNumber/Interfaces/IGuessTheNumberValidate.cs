using GuessTheNumber.Enums;

namespace GuessTheNumber.Interfaces
{
    public interface IGuessTheNumberValidate
    {
        /// <summary>
        /// Валидация двух чисел
        /// </summary>
        /// <param name="value">текущее значение</param>
        /// <param name="comparisonValue">значение для сравнения</param>
        /// <returns>Значение валидации</returns>
        GuessTheNumberValidateType Validate(int value, int comparisonValue);
    }
}
