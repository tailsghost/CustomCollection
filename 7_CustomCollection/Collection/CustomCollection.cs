using System.Collections;

namespace _7_CustomCollection.Collection;

public class CustomCollection : IList
{

    private readonly object[] contents = new object[8];
    private int count;

    public CustomCollection()
    {
        count = 0;
    }

    public object? this[int index] { get => contents[index]; set => contents[index] = value; }

    public bool IsFixedSize => true;

    public bool IsReadOnly => false;

    public int Count => contents.Length;

    public bool IsSynchronized => false;

    public object SyncRoot => null;

    public int Add(object? value)
    {
        if (count < contents.Length)
        {
            contents[count] = value;
            count++;
            return (count -1);
        }
        return -1;
    }

    public void Clear() => count = 0;

    public bool Contains(object? value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (contents[i].Equals(value))
                return true;
        }

        return false;
    }

    public void CopyTo(Array array, int index)
    {
        int h = index;

        for (int i = 0; h < Count; i++)
        {
            array.SetValue(contents[h], i);
            h++;
        }
    }

    public IEnumerator GetEnumerator()
    {
        for (int h = 0; h < Count; h++)
        {
            yield return contents[h];
        }
    }

    public int IndexOf(object? value)
    {
        for (int i = 0; i < Count; i++) { 
            if (contents[i] == value)
                return i;

        }

        return -1;
    }

    public void Insert(int index, object? value)
    {
        if (count + 1 > contents.Length && index >= Count && index >= 0)
        {
            return;
        }
        count++;

        for (int i = Count - 1; i > index; i--)
        {
            contents[i] = contents[i - 1];
        }
        contents[index] = value;
    }

    public void Remove(object? value) => RemoveAt(IndexOf(value));

    public void RemoveAt(int index)
    {
        if ((index >= 0) && (index < Count))
        {
            for (int i = 0; i < Count; i++)
                contents[i] = contents[i +1];

            count--;
        }
    }

    public void PrintContents()
    {
        Console.WriteLine($"Список имеет емкость {Count} и в настоящее время имеет {contents.GetEnumerator()}");
        Console.WriteLine("Список содержит");

        for (int i = 0; i <= Count; i++)
            Console.WriteLine($" {contents[i]}");

        Console.WriteLine("\n ------------------------------------------------------");
    }
}
