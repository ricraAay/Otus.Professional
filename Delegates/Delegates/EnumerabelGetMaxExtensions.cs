namespace Delegates
{
    public static class EnumerabelGetMaxExtensions
    {
        public static TSource? GetMax<TSource>(this IEnumerable<TSource> collection, Func<TSource, float> convertToNumber)
            where TSource : class
        {
            if (collection == null || !collection.Any())
            {
                return null;
            }

            var maxElement = collection.First();
            var maxNumber = convertToNumber(maxElement);

            foreach (var item in collection)
            {
                var currentNumber = convertToNumber(item);

                if (currentNumber > maxNumber)
                {
                    maxElement = item;
                    maxNumber = currentNumber;
                }
            }

            return maxElement;
        }
    }
}
