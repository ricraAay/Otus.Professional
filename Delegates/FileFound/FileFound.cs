﻿namespace FileFound
{
    public class FileFound
    {
        /// <summary>
        /// Событие нахождения файла
        /// </summary>
        public event EventHandler<FileArgs> FileFoundEvent = null!;

        /// <summary>
        /// Поиск файлов по указанному пути
        /// </summary>
        /// <param name="path">Путь</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <exception cref="Exception">Исключение при возникновении ошибки</exception>
        public void Found(CancellationToken cancellationToken, string? path = default)
        {
            if (FileFoundEvent == null)
            {
                throw new Exception("Отсутсвует подписка на событие FileFoundEvent");
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Укажите путь: ");
                path = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(path))
            {
                throw new Exception("Не указан путь для поиска файлов");
            }

            var fileEntries = Directory.GetFiles(path);

            if (fileEntries.Length == 0)
            {
                throw new Exception("По указанному пути файлы не найдены");
            }

            foreach (var entry in fileEntries)
            {
                var fileName = entry.Replace($"{path}", string.Empty);

                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                FileFoundEvent?.Invoke(this, new FileArgs
                {
                    Name = fileName
                });
            }
        }
    }
}
