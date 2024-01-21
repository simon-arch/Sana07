namespace Abstraction;
public abstract class Product
{
    protected string name;
    protected double price;
    protected int count;
    public string Name
    {
        get { return name; }
        set { if (value.Length <= 0) throw new ArgumentException("The product name field cannot be empty!"); name = value; }
    }
    public double Price
    {
        get { return price; }
        set { if (value <= 0) throw new ArgumentException("The product price field cannot be zero or negative!"); price = value; }
    }
    public int Count
    {
        get { return count; }
        set { if (value <= 0) throw new ArgumentException("The product count field cannot be zero or negative!"); count = value; }
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
        set { if (value.Length <= 0) throw new ArgumentException("The product processor field cannot be empty!"); processor = value; }
    }
    public string Videocard 
    { 
        get { return videocard; }
        set { if (value.Length <= 0) throw new ArgumentException("The product videocard field cannot be empty!"); videocard = value; }
    }
    public int Storage 
    { 
        get { return storage; }
        set { if (value <= 0) throw new ArgumentException("The product storage field cannot be zero or negative!"); storage = value; }
    }
    public int Ram 
    {
        get { return ram; }
        set { if (value <= 0) throw new ArgumentException("The product ram field cannot be zero or negative!"); ram = value; }
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
            $"Модель процесора: {processor}\nМодель відеокарти: {videocard}\nОб'єм накопичувача: {storage}гб\nОЗУ: {ram}гб");
    }
}
public class Monitor : Product
{
    protected int diagonal;
    protected int frequency;
    protected string matrix;
    protected string ratio;
    public int Diagonal
    {
        get { return diagonal; }
        set { if (value <= 0) throw new ArgumentException("The product diagonal field cannot be zero or negative!"); diagonal = value; }
    }
    public int Frequency
    {
        get { return frequency; }
        set { if (value <= 0) throw new ArgumentException("The product frequency field cannot be zero or negative!"); frequency = value; }
    }
    public string Matrix
    {
        get { return matrix; }
        set { if (value.Length <= 0) throw new ArgumentException("The product matrix field cannot be empty!"); matrix = value; }
    }
    public string Ratio
    {
        get { return ratio; }
        set { if (value.Length <= 0) throw new ArgumentException("The product ratio field cannot be empty!"); ratio = value; }
    }
    public Monitor(string name, double price, int count, int diagonal, int frequency, string matrix, string ratio)
        : base(name, price, count)
    {
        Diagonal = diagonal;
        Frequency = frequency;
        Matrix = matrix;
        Ratio = ratio;
    }
    public override void Display()
    {
        Console.WriteLine($"Категорія: Монітор\nНазва: {name}\nЦіна: {price} грн\nКількість: {count} шт.\n" +
            $"Діагональ екрана: {diagonal}''\nЧастота оновлення: {frequency}гц\nТип матриці: {matrix}\nСпіввідношення сторін: {ratio}");
    }
}
public class Drive : Product
{
    protected int storage;
    protected int transfer;
    protected string type;
    protected string usb;
    public int Storage
    {
        get { return storage; }
        set { if (value <= 0) throw new ArgumentException("The product storage field cannot be zero or negative!"); storage = value; }
    }
    public int Transfer
    {
        get { return transfer; }
        set { if (value <= 0) throw new ArgumentException("The product transfer field cannot be zero or negative!"); transfer = value; }
    }
    public string Type
    {
        get { return type; }
        set { if (value.Length <= 0) throw new ArgumentException("The product type field cannot be empty!"); type = value; }
    }
    public string Usb
    {
        get { return usb; }
        set { if (value.Length <= 0) throw new ArgumentException("The product usb field cannot be empty!"); usb = value; }
    }
    public Drive(string name, double price, int count, int storage, int transfer, string type, string usb)
        : base(name, price, count)
    {
        Storage = storage;
        Transfer = transfer;
        Type = type;
        Usb = usb;
    }
    public override void Display()
    {
        Console.WriteLine($"Категорія: Зовнішній накопичувач\nНазва: {name}\nЦіна: {price} грн\nКількість: {count} шт.\n" +
            $"Об'єм накопичувача: {storage}тб\nШвидкість передачі даних: {transfer}мб/с\nТип накопичувача: {type}\nUSB Інтерфейс: {usb}");
    }
}

public class ShoppingCart
{
    private List<Product> products = new List<Product>();
    public void Add(Product product)
    {
        products.Add(product);
    }
    public void Display()
    {
        foreach (Product product in products)
        {
            product.Display();
        }
    }
    public double Total()
    {
        return products.Sum(prod => prod.Price * prod.Count);
    }
}