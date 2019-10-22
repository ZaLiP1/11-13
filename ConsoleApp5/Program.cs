using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Addition(params int[] numbers)
        {
            int result = 0;
            for (int i=0; i< numbers.Length;i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }

        static void AdditionMas(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int f = 20;
            int z = 15;
            int e = 10;
            string h = Hello();
            int c = Sum();
            int d = Sum1(z, 30);
            int P;
            int S;
            int r1 = Optional(f:1, b:2, j:3, a:4);
            int r2 = Optional(1, 2, 3);
            int r3 = Optional(1, 2);


            Console.WriteLine($"{h}\n");
            Method1();
            Method2();
            Console.WriteLine("");
            Console.WriteLine($"Sum = {c}");
            Console.WriteLine($"Sum1 = {d}\n");
            Console.WriteLine($"Initial Value f = {f}");
            AdditionVal(f, e);
            Console.WriteLine($"Arter AdditionVal f = {f}");
            AdditionRef(ref f, e);
            Console.WriteLine($"Arter AdditionRef f = {f}\n");
            GetData(10, 15, out S, out P);
            Console.WriteLine($"S = {S}");
            Console.WriteLine($"P = {P}\n");
            Console.WriteLine($"{r1}");
            Console.WriteLine($"{r2}");
            Console.WriteLine($"{r3}\n");
            Console.WriteLine("Params1");
            Addition(new int[] { 5, 6, 8, 2 });
            Addition(9, 4, 3, 7, 5);
            Addition();
            Console.WriteLine("");
            Console.WriteLine("Params2");
            AdditionMas(new int[] { 5, 6, 8, 2 });
            Console.ReadKey();
        }

        static string Hello()
        {
            return "Hello World!";
        }

        static int Sum()
        {
            int x = 5;
            int y = 10;
            int s = x + y;
            return s;
        }

        static int Sum1(int a, int b)
        {
            return a + b;
        }

        static void GetData(int width, int height,out int S, out int P)
        {
            P = (width + height) * 2;
            S = width * height;
        }

        static void AdditionRef(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine($"AdditionRef a = {a}");
        }

        static void AdditionVal(int a, int b)
        {
            a = a + b;
            Console.WriteLine($"AdditionVal a = {a}");
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }

        static int Optional(int a,int b, int f = 4, int j = 6)
        {
            return a + b + f + j;
        }
    }
}
