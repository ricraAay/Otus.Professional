namespace FileFound
{
    public class FileArgs : EventArgs
    {
        /// <summary>
        /// Наименование файла
        /// </summary>
        public string Name { get; init; } = null!;
    }
}
