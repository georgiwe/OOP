using System;
using System.Text;

public class GenericList<T>
{
    private T[] array;
    private int lastIndex = -1;

    // Constructors
    public GenericList(int capacity, params T[] elements) : this(capacity)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            this.array[i] = elements[i];

            this.lastIndex = i;
        }
    }

    public GenericList(int capacity)
    {
        this.array = new T[capacity];
    }

    // Properties
    public int Count
    {
        get { return this.lastIndex + 1; }
    }

    public int Capacity
    {
        get { return this.array.Length; }
    }

    // Indexer
    public T this[int ind]
    {
        get 
        {
            if (ind < 0 || ind > this.lastIndex)
            {
                throw new IndexOutOfRangeException();
            }

            return this.array[ind];
        }
    }
    
    // Methods
    public void Add(T element)
    {
        this.EnsureCapacity();

        this.array[++this.lastIndex] = element;
    }

    public void RemoveAt(int ind)
    {
        if (ind < 0 || ind > this.lastIndex)
        {
            throw new IndexOutOfRangeException();
        }

        int count = this.lastIndex - 1 + ind;

        for (int i = ind; i < count; i++)
        {
            this.array[i] = this.array[i + 1];
        }

        this.lastIndex--;
    }

    public void Insert(int ind, T value)
    {                 // I add this last check so that you can insert at 0 when count == 0 and such
        if (ind < 0 || (ind > this.lastIndex && (ind - this.lastIndex != 1)))
        {
            throw new ArgumentOutOfRangeException();
        }

        this.EnsureCapacity();

        for (int i = this.lastIndex + 1; i > ind; i--)
        {
            this.array[i] = this.array[i - 1];
        }

        this.lastIndex++;
        this.array[ind] = value;
    }

    public void Clear()
    {
        this.lastIndex = -1;
    }

    public int IndexOf(T elem, int startInd = 0)
    {
        if (startInd < 0 || startInd > this.lastIndex)
        {
            throw new ArgumentOutOfRangeException();
        }

        int indexOfElem = -1;

        for (int i = startInd; i <= this.lastIndex; i++)
        {
            if (this.array[i].Equals(elem))
            {
                indexOfElem = i;
                break;
            }
        }

        return indexOfElem;
    }

    public T Max<T>() where T : IComparable
    {
        dynamic max = this.array[0];

        for (int i = 1; i <= this.lastIndex; i++)
        {
            if (max.CompareTo(this.array[i]) < 0)
            {
                max = this.array[i];
            }
        }

        return max;
    }

    public T Min<T>() where T : IComparable
    {
        dynamic min = this.array[0];

        for (int i = 1; i <= this.lastIndex; i++)
        {
            if (min.CompareTo(this.array[i]) > 0)
            {
                min = this.array[i];
            }
        }

        return min;
    }

    public override string ToString()
    {
        if (this.lastIndex == -1)
        {
            return string.Empty;
        }

        var result = new StringBuilder();

        for (int i = 0; i < this.lastIndex; i++)
        {
            result.Append(this.array[i].ToString() + ", ");
        }

        result.Append(this.array[this.lastIndex]);

        return result.ToString();
    }

    public string ToString(string splitter = " ")
    {
        if (this.lastIndex == -1)
        {
            return string.Empty;
        }

        var result = new StringBuilder();

        for (int i = 0; i < this.lastIndex; i++)
        {
            result.Append(this.array[i].ToString() + splitter);
        }

        result.Append(this.array[this.lastIndex]);

        return result.ToString();
    }

    private void EnsureCapacity()
    {
        if (this.lastIndex < this.array.Length - 1)
        {
            return;
        }

        T[] newArr = new T[this.array.Length * 2];

        for (int i = 0; i <= this.lastIndex; i++)
        {
            newArr[i] = this.array[i];
        }

        this.array = newArr;
    }
}