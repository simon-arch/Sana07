namespace Abstraction;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Laptop laptop = new Laptop("Lenovo IdeaPad Gaming 3 15ARH7", 34999, 1, "Ryzen 5 6600H", "GeForce RTX 3050", 512, 16);
        laptop.Display();
    }
}