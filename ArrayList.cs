using System;
public class ArrayList<T>
{
    private int length;
    private T[] items;
    public ArrayList()
    {
        this.length = 0;
        this.items = new T[32];
    }
    public ArrayList(int startSize)
    {
        this.length = 0;
        if (startSize > 32)
        {
            this.items = new T[startSize];
        } 
        else 
        {
            this.items = new T[32];
        }
    }
    public ArrayList(T[] startItems)
    {
        this.length = startItems.Length;
        if (startItems.Length < 32)
        {
            T[] temp = new T[32];
            for (int i = 0; i < startItems.Length; i++)
            {
                temp[i] = startItems[i];
            }
            this.items = temp;
        }
        else
        {
            this.items = startItems;
        }
    }
        public override string ToString()
    {
        string output = "[";
        for (int i = 0; i < this.length; i++)
        {
            output += this.items[i];
            if (i != this.length-1)
            {
            output += ", ";
            }
        }
        output += "]";
        return output;
    }
    public void Append(T item)
    {
        if (this.length == this.items.Length)
        {
            T[] temp = new T[this.items.Length*2];
            for (int i = 0; i < this.items.Length; i++)
            {
                temp[i] = this.items[i];
            }
            this.items = temp;
        }

        this.items[this.length++] = item;
        
    }
    public bool Contains(T item)
    {
        for (int i = 0; i < this.length; i++)
        {
            if (item.Equals(this.items[i]))
            {
                return true;
            }
        }
        return false;
    }
    public int? IndexOf(T item)
    {
        for (int i = 0; i < this.length; i++)
        {
            if (item.Equals(this.items[i]))
            {
                return i;
            }
        }
        return null;
    }
    public T Get(int index)
    {
        if (index >= 0 && index < this.length)
        {
            return this.items[index];
        }
        throw new IndexOutOfRangeException("Index "+index.ToString()+" was not valid.");
    }
    public bool Insert(T item, int index)
    {
        if ((index < 0) || (index > this.length))
        {
            return false;
        }
        if (this.length == this.items.Length)
        {
            T[] temp = new T[this.items.Length*2];
            for (int i = 0; i < this.items.Length; i++)
            {
                temp[i] = this.items[i];
            }
            this.items = temp;
        }
        for (int i = this.length; i > index; i--)
        {
            this.items[i] = this.items[i-1];
        }
        this.items[index] = item;
        this.length++;
        return true;
    }
    public bool RemoveAt(int index)
    {
        if ((index < 0) || (index >= this.length))
        {
            return false;
        }
        for (int i = index; i < this.length-1; i++)
        {
            this.items[i] = this.items[i+1];
        }
        this.length--;
        return true;
    }
    public bool Remove(T item)
    {
        int? index = this.IndexOf(item);
        if (!index.HasValue)
        {
            return false;
        }
        return this.RemoveAt((int)index);
    }
    public int Size()
    {
        return this.length;
    }
    public T[] GetItems()
    {
        return this.items;
    }
}
