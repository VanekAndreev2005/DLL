using System;

namespace MyLib2
{
    public class Global
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Привет, {name}");
        }
        public int Sum(int x)
        {
            return x + 5;
        }
    }
}
