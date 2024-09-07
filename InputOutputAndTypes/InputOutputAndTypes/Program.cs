namespace InputOutputAndTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание и инициализация переменных
            var name = "Danil";
            int a1 = 5;
            int a2 = 0;
            byte b1 = 65;
            int b2 = 50;
            //Блок try 
            try
            {
                Console.WriteLine($"B1 = {b1}");
                Console.WriteLine($"--B1 = {--b1}");
                Console.WriteLine($"B1 = {b1}");
                Console.WriteLine($"B1-- = {b1--}");
                Console.WriteLine($"B1 = {b1}");
                Console.WriteLine($"{b1} + {b2} = {b1 += (byte)b2}");
                b2 = b1;
                Console.WriteLine($"b2 = {b2}");
                b2 = 10000;
                checked { b1 = (byte)b2; };
                Console.WriteLine($"b1 = {b1}");
                Console.WriteLine($"{a1 / a2}");
            }
            //Блок catch при делении на ноль
            catch (DivideByZeroException ex)
            {
                Console.WriteLine ("Zero divide");
            }
            //Блок catch при остальных случаях
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //ввод целого числа
            var age = Convert.ToInt32(Console.ReadLine());
            //простой вывод
            Console.WriteLine("Hello, World!");
            //вывод с переменными и форматирование
            Console.WriteLine($"{name}(age - {age.ToString("+####;-###;Zero")}), is human!");
        }
    }
}
