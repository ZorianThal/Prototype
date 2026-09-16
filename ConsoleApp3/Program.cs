using System;
using System.Reflection.PortableExecutable;

class Character
{
    public string Name;
    public int Health;
    public int Attack;
    public int MannaPull;

    public Character Clone()
    {
        Character copy = new Character();
        copy.Name = this.Name;
        copy.Health = this.Health;
        copy.Health = this.MannaPull;

        return copy;
    }
}

class Program
{
    static void Main()
    {
        Character original = new Character();

        original.Name = "Маг";
        original.Health = 50;
        original.MannaPull = 60;

        Character copy = original.Clone();
        copy.Health = 150;
        copy.Name = "Вражеский маг";

        Console.WriteLine("Оригинал");
        Console.WriteLine(original.Name);
        Console.WriteLine(original.Health);
        Console.WriteLine(original.MannaPull);

        Console.WriteLine("Копия");
        Console.WriteLine(copy.Name);
        Console.WriteLine(copy.Health);



    }
}