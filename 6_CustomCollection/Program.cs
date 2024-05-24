using _6_CustomCollection.Collection;

namespace _6_CustomCollection;

internal class Program
{
    static void Main(string[] args)
    {
        var collection = new UserCollection<int> { 1, 2, 3, 4, 5 };

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----");

        Console.WriteLine(collection.Contains(2));
    }
}
