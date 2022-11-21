using System;
using MyLib2;

namespace mylib
{
    class Program
    {
        static void Main(string[] args)
        {
            Global func = new Global();

            func.SayHello("Иван");
            Console.WriteLine($"Сумма равна: {func.Sum(10)}");
        }
    }
}
