using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine()); //123//
        
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b % a == 0 || a % b == 0)
        {
            Console.WriteLine("Да, одно из чисел является делителем другого");
        }
        else
        {
            Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
        }
    }
}
