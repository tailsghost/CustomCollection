using System;
using System.Collections;

namespace _6_CustomCollection.Collection;

public class UserCollection<T> : ICollection<T>
{

    T[] elements = new T[0];

    public void Add(T item)
    {
        var newArray = new T[elements.Length + 1];
        elements.CopyTo(newArray, 0);
        newArray[elements.Length -1] = item;
        elements = newArray;
    }

    public void Clear() => elements = new T[0];

    public bool Contains(T item)
    {
        foreach (var element in elements)
            if (element.Equals(item)) 
                return true;

        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        elements.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>) elements).GetEnumerator();

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => (this as IEnumerable<T>).GetEnumerator();

    public int Count => elements.Length;

    public bool IsReadOnly => false;
}
