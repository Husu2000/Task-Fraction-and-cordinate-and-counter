namespace ConsoleApp1;

internal class Cordinate
{
    private int _y;
    private int _x;
    public int y
    {

        get { return _y; }
        set { _y=value; }

    }
    public int x
    {
        get { return _x; }
        set { _x = value; }

    }
    public Cordinate()
    {
        x = 0;
        y = 0;
    }
    public Cordinate (int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x},{y})";
    }
    public void ShowData()
    {
        Console.WriteLine(this);
    }
}
