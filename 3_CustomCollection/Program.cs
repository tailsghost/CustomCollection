using _3_CustomCollection.Collection;
using System.Collections;

namespace _3_CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Collection = new UserCollection<Element>();

            Collection[0] = new Element(1, 2);
            Collection[1] = new Element(3, 4);
            Collection[2] = new Element(5, 6);
            Collection[3] = new Element(7, 8);

            foreach (Element element in Collection) {
                Console.WriteLine($"{element.ElementA} {element.ElementB}");
            }

            Console.WriteLine("-----");

            foreach (Element element in Collection)
            {
                Console.WriteLine($"{element.ElementA} {element.ElementB}");
            }
        }
    }
}
