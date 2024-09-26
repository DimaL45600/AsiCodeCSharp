using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace CollectionsAndStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1,2,3,4,5,6 };
            //Console.WriteLine(String.Join(",",list));
            //list.Insert(1, 10);
            //Console.WriteLine(String.Join(",",list));

            //var dict = new Dictionary<string, string>()
            //{
            //    ["sky"]="blue",
            //    ["Phone"]="black",
            //    ["sun"]="orange"
            //};

            //dict.Add("rabbit","white");
            //dict.TryAdd("rabbit","white");
            //Console.WriteLine(dict["sky"]);

            //Console.WriteLine(dict.Count);

            //foreach(var key in dict.Keys)
            //{
            //    Console.WriteLine($"{key} = {dict[key]}");
            //}
            //Console.WriteLine(dict.ContainsKey("rabbit"));
            //Console.WriteLine(dict.ContainsKey("rabb"));

            //var queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine(String.Join(",", queue));
            //queue.Dequeue();
            //Console.WriteLine(String.Join(",", queue));

            //var stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //Console.WriteLine(String.Join(",", stack));
            //stack.Pop();
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(String.Join(",", stack));
            Student student = new Student(954, 7.2);
            student.GetInfo();
        }
        public struct Student
        {
            public int groupId;
            string firstName;
            string lastName;
            public double avgGrade;
            public Student(int groupId, double avgGrade)
            {
                this.groupId = groupId;
                this.avgGrade = avgGrade;
                firstName = "Jhon";
                lastName = "Dirkinz";
            }
            public string FullName
            {
                get { return $"{firstName} {lastName}"; }
            }
            public void GetInfo()
            {
                Console.WriteLine($"Group:{groupId} Name:{FullName}, avgGrade = {avgGrade}");
            }
        }
    }
}
