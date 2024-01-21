namespace Abstraction;
public abstract class Product
{
    protected string name;
    protected double price;
    protected int count;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public int Count
    {
        get { return count; }
        set { count = value; }
    }
    protected Product(string name, double price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
    }
    public abstract void Display();
}