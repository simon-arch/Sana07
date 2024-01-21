﻿namespace Abstraction;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Laptop laptop = new Laptop("Lenovo IdeaPad Gaming 3 15ARH7", 34999, 1, "Ryzen 5 6600H", "GeForce RTX 3050", 512, 16);
        Monitor monitor = new Monitor("Odyssey G5A", 11299, 1, 27, 165, "IPS", "16:9");
        Drive drive = new Drive("Kingston XS2000", 4419, 1, 1, 2000, "SSD", "USB 3.2 Type-C");

        laptop.Display();
        Console.WriteLine();
        monitor.Display();
        Console.WriteLine();
        drive.Display();
    }
}