namespace GuessTheNumber.Interfaces
{
    public interface IGuessTheNumberConfigurate
    {
        /// <summary>
        /// Количество попыток 
        /// </summary>
        int NumberAttempts { get; set; }

        /// <summary>
        /// Диапазон чисел
        /// </summary>
        Range Range { get; set; }
    }
}
