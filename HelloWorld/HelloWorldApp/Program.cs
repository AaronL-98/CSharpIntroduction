using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("camelCaseLikeThis");
            Console.WriteLine("_underscoreFirstLikeThis");
            Console.WriteLine("PascalCaseLikeThis");
            Console.WriteLine("pythan_casing_like_this");
            Console.WriteLine("Kebab-case-for-html");
            // variables/  in camelCase
            // class/ methods/ properties in PascalCase
            //

            int x = 100;
            x += 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i: " + i + "x " + x);
                x += i;
            }
        }
    }
}