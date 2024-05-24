using System.Collections;

namespace _1_CustomCollection.Collection;

public class UserCollection : IEnumerable, IEnumerator
{

    public readonly Element[] elements = new Element[4];

    public Element this[int index]
    {
        get => elements[index];

        set => elements[index] = value;
    }

    private int position = -1;

    public object Current => elements[position];

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if (position < elements.Length -1)
        {
            position++;
            return true;
        }
        Reset();
        return false;
    }

    public void Reset() => position = -1;
}
