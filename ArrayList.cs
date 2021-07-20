public class ArrayList
{
    private int length;
    private string[] items;
    public ArrayList()
    {
        this.length = 0;
        this.items = new string[32];
    }
    public ArrayList(int startSize)
    {
        this.length = 0;
        if (startSize > 32)
        {
            this.items = new string[startSize];
        } 
        else 
        {
            this.items = new string[32];
        }
    }
    public ArrayList(string[] startItems)
    {
        this.length = startItems.Length;
        if (startItems.Length < 32)
        {
            string[] temp = new string[32];
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
    public void Append(string item)
    {
        if (this.length == this.items.Length)
        {
            string[] temp = new string[this.items.Length*2];
            for (int i = 0; i < this.items.Length; i++)
            {
                temp[i] = this.items[i];
            }
            this.items = temp;
        }

        this.items[this.length++] = item;
        
    }
    public bool Contains(string item)
    {
        for (int i = 0; i < this.length; i++)
        {
            if (item == this.items[i])
            {
                return true;
            }
        }
        return false;
    }
    public int? IndexOf(string item)
    {
        for (int i = 0; i < this.length; i++)
        {
            if (item == this.items[i])
            {
                return i;
            }
        }
        return null;
    }
    public bool Insert(string item, int index)
    {
        if ((index < 0) || (index > this.length))
        {
            return false;
        }
        if (this.length == this.items.Length)
        {
            string[] temp = new string[this.items.Length*2];
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
    public bool Remove(string item)
    {
        int? index = this.IndexOf(item);
        if (!index.HasValue)
        {
            return false;
        }
        return this.RemoveAt((int)index);
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
}