using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Заметка была создана пользователем: {name}");
    }
}
