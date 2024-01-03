namespace GuessTheNumber.Interfaces
{
    public interface IGuessTheNumberRandom
    {
        /// <summary>
        /// Генерация числа из заданного диапазона
        /// </summary>
        /// <param name="min">Нижняя граница диапазона</param>
        /// <param name="max">Верхняя граница диапазона</param>
        /// <returns>Сгенерированное число</returns>
        int Next(int min, int max);
    }
}
