namespace AsyncBaseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread curentTread = Thread.CurrentThread;

            //Console.WriteLine($"Name: {curentTread.Name}");
            //Console.WriteLine($"{curentTread.IsAlive}");
            //Console.WriteLine($"{curentTread.ManagedThreadId}");
            //Console.WriteLine($"{curentTread.Priority}");
            //Console.WriteLine($"{curentTread.ThreadState}");



            //void Print() => Console.WriteLine("Hello thread");

            //Thread myTread1 = new Thread(Print);
            //Thread myTread2 = new Thread(new ThreadStart(Print));
            //Thread myTread3 = new Thread(() => Console.WriteLine("Hello thread"));

            //myTread1.Start();
            //myTread2.Start();
            //myTread3.Start();

            //void Print()
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine($"Second tread: {i}");
            //        Thread.Sleep(400);
            //    }
            //}
            //Thread myThread = new Thread(Print);
            //myThread.Start();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Main tread: {i}");
            //    Thread.Sleep(600);
            //}


            //void Print(object? message) => Console.WriteLine(message);

            //Thread myTread1 = new Thread(Print);
            //Thread myTread2 = new Thread(new ParameterizedThreadStart(Print));
            //Thread myTread3 = new Thread(message => Console.WriteLine(message));

            //myTread1.Start("Hello");
            //myTread2.Start("Privet");
            //myTread3.Start("Hola");


            //void Print(object? obj)
            //{
            //    if(obj is Person person) Console.WriteLine(person.Name);
            //}
            //int number = 9;
            //Person p = new Person("Jack", 45);
            //Thread myThread = new Thread(p.Print);
            //myThread.Start();

            //int x = 0;
            //object locker = new object();

            //for(int i = 1; i < 6; i++)
            //{
            //    Thread myThread = new Thread(Print);
            //    myThread.Name = $"Thread {i}";
            //    myThread.Start();
            //}
            //void Print()
            //{
            //    lock (locker)
            //    {
            //        x = 1;
            //        for (int i = 1; i < 6; i++)
            //        {
            //            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            //            x++;
            //            Thread.Sleep(100);
            //        } 
            //    }
            //}


            //Console.WriteLine("main starts");
            //Task task = new Task(() =>
            //{
            //    Console.WriteLine("Task starts");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Task ends");
            //});
            //Console.WriteLine($"{task.Status}");
            //task.Start();
            //Console.WriteLine($"{task.Id}");
            //Console.WriteLine($"{task.IsCompleted}");
            //Console.WriteLine($"{task.Status}");
            //task.Wait();
            ////task.RunSynchronously();
            //Console.WriteLine("main ends");

            //var outer = Task.Factory.StartNew(() =>      // внешняя задача
            //{
            //    Console.WriteLine("Outer task starting...");
            //    var inner = Task.Factory.StartNew(() =>  // вложенная задача
            //    {
            //        Console.WriteLine("Inner task starting...");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Inner task finished.");
            //    }, TaskCreationOptions.AttachedToParent);
            //});
            //outer.Wait(); // ожидаем выполнения внешней задачи
            //Console.WriteLine("End of Main");

            //Task[] tasks1 = new Task[3]
            //{
            //    new Task(() => Console.WriteLine("First Task")),
            //    new Task(() => Console.WriteLine("Second Task")),
            //    new Task(() => Console.WriteLine("Third Task"))
            //};
            //foreach (var task in tasks1)
            //{
            //    task.Start();
            //}


            //Task[] tasks2 = new Task[3];
            //int j = 1;
            //for (int i = 0; i < tasks2.Length; i++)
            //    tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));
            //Task.WaitAny(tasks2);

            int n1 = 4, n2 = 10;
            int Sum(int a, int b) => a + b;
            Task<int> sumTask = new Task<int>(() => Sum(n1, n2));
            sumTask.Start();

            int result = sumTask.Result;
            Console.WriteLine($"{n1} + {n2} = {result}");

        }
    }
    record class Person(string Name, int Age)
    {
        public void Print()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
        }
    }
}
