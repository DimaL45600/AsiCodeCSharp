namespace EnumStatRead
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday, 
            Saturday,
            SunDay
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter day of week");
            //int dayNumber = int.Parse(Console.ReadLine());

            //DaysOfWeek day = (DaysOfWeek)dayNumber;
            //Console.WriteLine($"This is {++day}");

            //Console.WriteLine(Car.CarsCount);
            //Car c1 = new Car(78000, "AF947K09983");
            //Console.WriteLine(Car.CarsCount);
            //Car c2 = new Car(12000, "JSIDGJ89342");
            //Console.WriteLine(Car.CarsCount);
            //c1.GetInfo();
            //c2.GetInfo();
            //Car.mark = "Toyota";
            //c1.GetInfo();
            //c2.GetInfo();

            //Console.WriteLine($"100 hrivna in dollar = {CurrencyConverter.ConvertHrivnaToDollar(100)}");

            //Singleton s1 = Singleton.GetInstance();
            //s1.data = "Chnged";
            //Singleton s2 = Singleton.GetInstance();

            //Console.WriteLine(s1.data);
            //Console.WriteLine(s2.data);

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}

            Queue<(string task, int duration)> taskQueue = new Queue<(string task, int duration)>();

            taskQueue.Enqueue(("Task 1", 1200));
            taskQueue.Enqueue(("Task 2", 500));
            taskQueue.Enqueue(("Task 3", 1600));

            int time = 500;

            while (taskQueue.Count > 0)
            {
                var currentTask = taskQueue.Dequeue();
                string taskName = currentTask.task;
                int remainingTime = currentTask.duration;

                if (remainingTime > time)
                {
                    Console.WriteLine($"{taskName} выполняется в течение {time} мс");
                    Thread.Sleep(time);

                    remainingTime -= time;
                    taskQueue.Enqueue((taskName, remainingTime));
                }
                else
                {
                    Console.WriteLine($"{taskName} выполняется и завершается за {remainingTime} мс");
                    Thread.Sleep(remainingTime);
                }
            }

            Console.WriteLine("Все задачи выполнены!");
        }
    }
    public class Car {
        private static int carsManufactured;
        public static string mark;
        public static string model;
        public int millage;
        public readonly string vinCode;
        static Car()
        {
            carsManufactured = 0;
            mark = "Ford";
            model = "Focus";
        }
        public Car(int millage, string vinCode)
        {
            carsManufactured++;
            this.vinCode = vinCode;
            this.millage = millage;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{mark} {model}: {millage}km, vin:{vinCode}");
        }
        public static int CarsCount { get { return carsManufactured; } }
    }
    public static class CurrencyConverter
    {
        public static double DollatToHrivna = 40.5;
        public static double CronaToHrivana = 1.8;
        public static double ConvertDollarToHrivna( double amount) => amount * DollatToHrivna;
        public static double ConvertHrivnaToDollar( double amount) => amount / DollatToHrivna;
        public static double ConvertCronaToHrivana( double amount) => amount * CronaToHrivana;
        public static double ConvertHrivanaToCrona( double amount) => amount / CronaToHrivana;

    }

    public sealed class Singleton
    {
        // Конструктор Одиночки всегда должен быть скрытым, чтобы предотвратить
        // создание объекта через оператор new.
        public string data;
        private Singleton() { data = "I am single"; }

        // Объект одиночки храниться в статичном поле класса. Существует
        // несколько способов инициализировать это поле, и все они имеют разные
        // достоинства и недостатки. В этом примере мы рассмотрим простейший из
        // них, недостатком которого является полная неспособность правильно
        // работать в многопоточной среде.
        private static Singleton _instance;

        // Это статический метод, управляющий доступом к экземпляру одиночки.
        // При первом запуске, он создаёт экземпляр одиночки и помещает его в
        // статическое поле. При последующих запусках, он возвращает клиенту
        // объект, хранящийся в статическом поле.
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Наконец, любой одиночка должен содержать некоторую бизнес-логику,
        // которая может быть выполнена на его экземпляре.
        public void someBusinessLogic()
        {
            // ...
        }
    }
}
