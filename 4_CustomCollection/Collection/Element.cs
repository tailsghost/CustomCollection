using System.Xml.Linq;

namespace _4_CustomCollection.Collection;

public class Element
{
    public int ElementA {  get; set; }

    public int ElementB { get; set; }

    public Element(int ElementA, int ElementB) => (this.ElementA, this.ElementB) = (ElementA, ElementB);
}
