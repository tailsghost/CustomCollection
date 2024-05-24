using System;
using System.Collections;
using System.Collections.Generic;

namespace _4_CustomCollection.Collection;

public class UserCollection<T>
{

    private T[] elements;

    public T this[int index]
    {
        get => elements[index];

        set => elements[index] = value;
    }

    public UserCollection()
    {
        this.elements = new T[4];
        this.position = -1;
    }

    private int position;

    public void Reset() => position = -1;

    public IEnumerator GetEnumerator()
    {
        Enumerator enumerator = new Enumerator();

        enumerator.@this = (UserCollection<T>)this;

        return enumerator;
    }

    private sealed class Enumerator : IEnumerator<object>, IEnumerator, IDisposable
    {
        private object current;
        public UserCollection<T> @this;

        public object Current => current;

        public bool MoveNext()
        {

            if (@this.position < (@this.elements.Length -1))
            {
                @this.position++;
                current = @this.elements[@this.position];
                return true;
            }
            @this.Reset();
            return false;
        }

        public void Reset()
        {
            
        }

        public void Dispose()
        {
            
        }
    }
}
