namespace GuessTheNumber.Interfaces
{
    public interface IGuessTheNumberGenerate
    {
        /// <summary>
        /// Генерация числа из заданного диапазона
        /// </summary>
        /// <param name="range">Диапазон</param>
        /// <returns>Сгенерированное число</returns>
        int Generate(Range range);
    }
}
