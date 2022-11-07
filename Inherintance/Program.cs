using System;

namespace Inherintance
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan superman = new();
            BatMan batman = new();
            SpiderMan spiderman = new();

            superman.GetName();
            batman.GetName();
            spiderman.GetName();

            Console.ReadKey();
        }
    }
}
