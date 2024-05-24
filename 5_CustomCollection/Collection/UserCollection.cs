using System.Collections;

namespace _5_CustomCollection.Collection;

public class UserCollection : ICollection
{

    private readonly object[] elements = {1,2,3,4,5};

    private object syncRoot => new object();

    public void CopyTo(Array array, int index)
    {
        var arr = array as object[];

        if (arr == null)
            throw new ArgumentException("Expecting array to be object[]");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[index++] = elements[i];
        }
    }

    public int Count => elements.Length;

    public bool IsSynchronized => true;

    public object SyncRoot => syncRoot;

    public IEnumerator GetEnumerator() => elements.GetEnumerator();
}
