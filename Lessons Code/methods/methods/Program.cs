using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(method1("Nikita"));


            //string method1(string name)
            //{
            //    return $"Hello {name}!";
            //}

            //int[] m1 = { 1, -2, 3, -4, 5, -6, 7, -8 };
            //int[] m2 = { -1, -2, 3, -4, -5, -6, 7, -8 };

            //Console.WriteLine(m2.First(x => x > 5 ));

            //Console.WriteLine($"m1 negative numbers count - {negCount(m1)}");
            //Console.WriteLine($"m2 negative numbers count - {negCount(m2)}");



            //int negCount(int[] mas)
            //{
            //    int count = 0;
            //    for (int i = 0; i < mas.Length; i++)
            //    {
            //        if (mas[i] < 0) count++;
            //    }
            //    return count;
            //}


            //Console.WriteLine(method1("Daniil",34,179));
            //string method1(string name, int age, int height) => $"Hello {name}({age} years, {height} sm)!";

            //Console.WriteLine(method1("Daniil", 34, 179));
            //Console.WriteLine(method1("Daniil", 34));
            //Console.WriteLine(method1("Daniil"));
            //Console.WriteLine(method1());
            //Console.WriteLine(method1(height:290, age:186, name:"Goliaf"));
            //string method1(string name = "BOB", int age = 20, int height = 175) => $"Hello {name}({age} years, {height} sm)!";

            //Console.WriteLine($"a1 before - {a1}");
            //negReverse(out int a1);
            //Console.WriteLine($"a1 after - {a1}");


            //void negReverse(out int i)
            //{
            //    i = 68;
            //    Console.WriteLine($"a1 in - {i}");
            //}

            recursionEndless(1);

            void recursionEndless(int i)
            {
                Console.WriteLine($"recursion №{i}");
                i++;
                recursionEndless(i);
            }

            //ulong factorial(ulong x)
            //{
            //    if (x == 1) return 1;

            //    return x * factorial(x - 1);
            //}

            //Console.WriteLine(factorial(90));
            ////4
            ////4*3
            ////3*2
            ////2*1

        }
    }
    
}
