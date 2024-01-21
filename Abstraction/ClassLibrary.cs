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

public class Laptop : Product
{
    protected string processor;
    protected string videocard;
    protected int storage;
    protected int ram;
    public string Processor 
    {
        get { return processor; }
        set { processor = value; }
    }
    public string Videocard 
    { 
        get { return videocard; }
        set { videocard = value; }
    }
    public int Storage 
    { 
        get { return storage; }
        set { storage = value; }
    }
    public int Ram 
    {
        get { return ram; }
        set { ram = value; }
    }
    public Laptop(string name, double price, int count, string processor, string videocard, int storage, int ram)
        : base(name, price, count)
    {
        Processor = processor;
        Videocard = videocard;
        Storage = storage;
        Ram = ram;
    }
    public override void Display()
    {
        Console.WriteLine($"Категорія: Ноутбук\nНазва: {name}\nЦіна: {price} грн\nКількість: {count} шт.\n" +
            $"Модель процесора: {processor}\nМодель відеокарти: {videocard}\nОб'єм накопичувача: {storage} гб\nОЗУ: {ram} гб");
    }
}