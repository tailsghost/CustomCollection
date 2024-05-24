using System.Collections;

namespace _2_CustomCollection.Collection;

public class UserCollection<T> : IEnumerable<T>, IEnumerator<T>
{

    public readonly T[] elements = new T[4];

    public T this[int index]
    {
        get => elements[index];

        set => elements[index] = value;
    }

    private int position = -1;

    public object Current => elements[position];

    T IEnumerator<T>.Current => elements[position];

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

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return this;
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public void Dispose()
    {
       ((IEnumerator)this).Reset();
    }
}
