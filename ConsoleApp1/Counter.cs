using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1;

internal class Counter
{
    private int _min;
    private int _max;

    public int count { get; set; }

    public int min 
    {
        get { return _min; }
        set { _min = value; }       
    }
    public int max 
    {
        get { return _max; }
        set { _max = value; }
    
    }
    public Counter()
    {
        max=1000;
        min=0;
        count= min;
    }
    public Counter(int min, int max)
    {
        if (min > max)
            throw new Exception("Minimum maksimumdan az ola bilmez");
        this.min = min;
        this.max = max;
        count = min;
    }
    public void decrement()
    {
        if (count != min)
            count--;
    }

    public void increment()
    {
        count++;
        if (count == max)
            count = min;
    }

    public override string ToString()
    {
        return count.ToString();
    }
}


