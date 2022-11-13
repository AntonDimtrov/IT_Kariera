using System;
using System.Linq;
using System.Text;

public class DataList
{

    private const int DEFAULT_CAPACITY = 3;

    private string[] data;
    private int count = 0;
    private int capacity;

    public DataList(int capacity = DEFAULT_CAPACITY)
    {
        this.data = new string[capacity];
        this.Capacity = capacity;
    }

    public int Count
    {
        get { return this.count; }
        private set { this.count = value; }
    }
    public int Capacity
    {
        get { return this.capacity; }
        private set { this.capacity = value; }
    }
    public void Add(string element)
    {
        if (Count >= this.data.Length)
        {
            Resize();
        }
        data[Count] = element;
        Count++;
    }
    public bool Contains(string element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (data[i] == element) return true;
        }
        return false;
    }
    public bool RemoveByIndex(int index)
    {
        if (index < Count && index > 0)
        {
            this.data = this.data.Take(index).Concat(data.Skip(index + 1)).ToArray();
            Count--;
            return true;
        }
        return false;
    }
    public void ReplaceLastWithFirst()
    {
        string first = data[0];
        data[0] = data[Count - 1];
        data[Count - 1] = first;
    }
    public StringBuilder Info()
    {
        StringBuilder info = new StringBuilder();
        info.Append($"Count:{this.Count}\n");
        info.Append($"Capacity:{this.Capacity}\n");
        for(int i = 0; i < this.Count; i++)
        {
            info.Append($"{data[i]}\n");
        }
        return info;
    }
    public void Resize()
    {
        int newCapacity = this.capacity * 2;
        string[] temp = new string[newCapacity];
        for (int i = 0; i < this.data.Length; i++)
        {
            temp[i] = data[i];
        }
        data = temp;
        capacity = newCapacity;

    }
}
