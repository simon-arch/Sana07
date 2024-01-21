﻿namespace Abstraction;
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
        set { diagonal = value; }
    }
    public int Frequency
    {
        get { return frequency; }
        set { frequency = value; }
    }
    public string Matrix
    {
        get { return matrix; }
        set { matrix = value; }
    }
    public string Ratio
    {
        get { return ratio; }
        set { ratio = value; }
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
        set { storage = value; }
    }
    public int Transfer
    {
        get { return transfer; }
        set { transfer = value; }
    }
    public string Type
    {
        get { return type; }
        set { type = value; }
    }
    public string Usb
    {
        get { return usb; }
        set { usb = value; }
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