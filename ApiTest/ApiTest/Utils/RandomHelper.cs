namespace ApiTest.Utils;

public static class RandomHelper
{
    public static T GetRandomItem<T>(IList<T> items)
    {
        if (items == null || items.Count == 0)
            throw new ArgumentException("Список пустой или null");

        var rnd = new Random();
        int index = rnd.Next(items.Count);
        return items[index];
    }
}