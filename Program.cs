using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int i;
            int g;
            Console.WriteLine("ВВедите Y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ВВедите Z");

            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Q");

            int q = Convert.ToInt32(Console.ReadLine());

            //Convert.ToInt32(y);
            //  Convert.ToInt32(z);
            x = y + z;
            i = z + q;
            if (i < x)
            {
                Console.Write($"i меньше, так как i =", i);
            }
            else {
                Console.Write($"i больше, так как i =", i);
                    };
            Console.WriteLine(x);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
