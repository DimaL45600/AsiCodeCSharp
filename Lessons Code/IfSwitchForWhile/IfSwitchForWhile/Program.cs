namespace IfSwitchForWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число 2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            //bool b1 = false;


            //if (a1 > a2)
            //{
            //    Console.WriteLine($"{a1} > {a2}");
            //}
            //else if (a1 == a2)
            //{
            //    Console.WriteLine($"{a1} = {a2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a1} < {a2}");
            //}


            //switch (a1)
            //{
            //    case 0:
            //        Console.WriteLine("A1 == 0");
            //        break;
            //    case 1:
            //        Console.WriteLine("A1 == 1");
            //        break;
            //    case 10:
            //        Console.WriteLine("A1 == 10");
            //        break;
            //    default:
            //        Console.WriteLine("A1 != 0,1,10");
            //        break;
            //}

            //Console.WriteLine(((a1%2)==0)?$"{a1} - чётное" : $"{a1} - не чётное");

            //for (int i = 0; i <= 40; i++)
            //{
            //    Console.Write($"#{i} - ");
            //    Console.WriteLine((a1 > a2) ? $"{a1} > {a2}": $"{a1} <= {a2}");
            //    a1--;
            //}

            //do
            //{
            //    Console.WriteLine(a1);
            //    if (Console.KeyAvailable) break;
            //    a1--;
            //} while (a1 <10000);
            //DateTime currDateTime = DateTime.Now.AddHours(-17);
            //while (currDateTime.Hour < 23)
            //{
            //    if (currDateTime.Hour >= 4 && currDateTime.Hour < 12) Console.WriteLine($"Is morning ({currDateTime.ToString("HH:mm:ss")})");
            //    else if (currDateTime.Hour >= 12 && currDateTime.Hour < 16) Console.WriteLine($"Is day ({currDateTime.ToString("HH:mm:ss")})");
            //    else if (currDateTime.Hour >= 16 && currDateTime.Hour < 20) Console.WriteLine($"Is evning ({currDateTime.ToString("HH:mm:ss")})");
            //    else if (currDateTime.Hour >= 20 || currDateTime.Hour < 4) Console.WriteLine($"Is night ({currDateTime.ToString("HH:mm:ss")})");
            //    currDateTime = currDateTime.AddHours(1);
            //}
        }
    }
}
