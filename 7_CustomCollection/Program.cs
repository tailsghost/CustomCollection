using _7_CustomCollection.Collection;

namespace _7_CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new CustomCollection();

            collection.Add(1);

            collection.PrintContents();
        }
    }
}
