using System.Diagnostics.CodeAnalysis;

namespace ArraysAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            //int[] m1 = {-5,23,-29,58,-56,43,-76,34,-16};
            //Console.WriteLine(m1[4]);
            //Console.WriteLine(m1.Length);
            //Console.WriteLine(String.Join(", ",m1));
            //Console.WriteLine(m1.Max());
            //Console.WriteLine(m1.Average());
            //Console.WriteLine(m1.Min());
            //Console.WriteLine(String.Join(", ", m1.OrderDescending()));

            //List<int> l1 = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    l1.Add(rand.Next(1, 10));
            //}

            //Console.WriteLine(l1.IndexOf(11));

            //Console.WriteLine(String.Join(", ",l1));
            //Console.WriteLine(String.Join(", ",m1));

            //List<int> lsub = new List<int>();
            //List<int> lplus = new List<int>();

            //foreach(int element in l1)
            //{
            //    if (element >= 0) lplus.Add(element);
            //    else lsub.Add(element);
            //}

            //m1.ToList().ForEach(element =>
            //{
            //    if (element >= 0) lplus.Add(element);
            //    else lsub.Add(element);
            //});
            //Console.Write("\n\n\n\n\n");
            //Console.WriteLine(String.Join(", ", lsub));
            //Console.WriteLine(String.Join(", ", lplus));

            //string s1 = "Hello, world and students. Low";

            //int [] count = { 0, 0, 0 };
            //foreach (char item in s1.ToLower())
            //{
            //    switch (item)
            //    {
            //        case 'l':
            //            count[0]++;
            //            break;
            //        case 'o':
            //            count[1]++;
            //            break;
            //        case 'w':
            //            count[2]++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine($"L count = {count[0]}\nO count = {count[1]}\nW count = {count[2]}");

            int[,,] mn2 = new int[2, 3, 4];
            Console.WriteLine(mn2.GetLength(0));
            Console.WriteLine(mn2.GetLength(1));
            Console.WriteLine(mn2.GetLength(2));


            int[][][] mn1 = new int[3][][];
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                mn1[i] = new int[4][];
                for (int j = 0; j < 4; j++)
                {
                    mn1[i][j] = new int[5];
                    for (int k = 0; k < 5; k++)
                    {
                        mn1[i][j][k] = count++;
                    }
                }
            }
            Array.Reverse(mn1);
            Console.WriteLine($"Rank - {mn1.Rank}, length - {mn1.Length}");
            Console.WriteLine($"Rank - {mn1[1].Rank}, length - {mn1[1].Length}");
            Console.WriteLine($"Rank - {mn1[1][1].Rank}, length - {mn1[1][1].Length}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        Console.Write($"{mn1[i][j][k]}, ");
                    }
                    Console.WriteLine("--");
                }
                Console.WriteLine();
            }
        }
    }
}
