using _5_CustomCollection.Collection;

namespace _5_CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection();

            foreach (var item in collection)
                Console.WriteLine(item);
            

            Console.WriteLine("-----");

            var array = new object[collection.Count];

            collection.CopyTo(array, 0);

            foreach(var item in array)
                Console.WriteLine(item);
        }
    }
}
