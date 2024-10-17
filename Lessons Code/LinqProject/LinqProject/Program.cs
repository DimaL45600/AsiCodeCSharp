using System.Runtime.Intrinsics.X86;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Max());

            //List<int> evenNumbers = new List<int>();
            //foreach(var num in numbers)
            //{
            //    if(num %2==0) evenNumbers.Add(num);
            //}
            //foreach(var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            //var evenNumbersLinq = from num in numbers
            //                      where num %2==0
            //                      select num;
            //foreach (var num in evenNumbersLinq)
            //{
            //    Console.WriteLine(num);
            //}
            //var evenNumbersLinq2 = numbers.Where(num => num %2==0);
            //foreach (var num in evenNumbersLinq2)
            //{
            //    Console.WriteLine(num);
            //}

            //List<string> names = new List<string> {"Dmytro", "Maxim", "Yarko", "Illya", "Pavel" };
            //var nameLengths = names.Select(x => new { Name = $"mr. {x}", Length = x.Length });
            //foreach (var data in nameLengths)
            //{
            //    Console.WriteLine($"Name: {data.Name}; Length: {data.Length}");
            //}

            var employees = new List<(string Name, string Department)>
            {
                ("John","HR"),
                ("Carl","IT"),
                ("Jozefina","Finance"),
                ("Paul","HR"),
                ("Jake","HR"),
                ("Nikolas","Finance"),
                ("Maria","HR"),
            };
            var sortedEmployes = employees.OrderByDescending(e => e.Name);
            foreach (var employee in sortedEmployes)
            {
                Console.WriteLine(employee.Name+";Dep:"+employee.Department);
            }
            //var groupedEmployees = employees.GroupBy(e => e.Department);

            //foreach(var group in groupedEmployees)
            //{
            //    Console.WriteLine($"\nDepartment: {group.Key}:");
            //    foreach(var employee in group)
            //    {
            //        Console.WriteLine(employee.Name);
            //    }
            //}
            //var filteredEmployees = employees.First(e => e.Name.StartsWith("Jan"));
            //Console.WriteLine(filteredEmployees.Name + "; Department:" + filteredEmployees.Department);

            //var students = new List<(int Id, string Name)>
            //{
            //    (1, "Alice"),
            //    (2, "Bob"),
            //    (3, "Charlie")
            //};

            //var grades = new List<(int StudentId, string Course, int Grade)>
            //{
            //    (1, "Math", 85),
            //    (1, "History", 90),
            //    (2, "Math", 78),
            //    (3, "History", 95),
            //    (3, "Math", 88)
            //};
            //var studentsGrades = from student in students
            //               join grade in grades on student.Id equals grade.StudentId
            //               select new {student.Name, grade.Course, grade.Grade};
            //var studentsGrades2 = students.Join(grades, (s => s.Id), (g => g.StudentId), (s, g) => new { s.Name, g.Course, g.Grade });
            //foreach (var student in studentsGrades)
            //{
            //    Console.WriteLine($"Name: {student.Name}, Course: {student.Course}, Grade: {student.Grade}");
            //}

            //var products = new List<(string Name, string Category, decimal Price)>
            //{
            //    ("Apple", "Fruit", 1.2m),
            //    ("Banana", "Fruit", 0.8m),
            //    ("Carrot", "Vegetable", 0.5m),
            //    ("Broccoli", "Vegetable", 1.0m),
            //    ("Chicken", "Meat", 5.0m),
            //    ("Beef", "Meat", 7.0m),
            //    ("Beef2", "Meat", 3.2m),
            //    ("Beef3", "Meat", 4.3m)
            //};
            //var avaragePrices = products.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.Price)
            //    });
            //foreach (var item in avaragePrices)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            //}
            //var categories = new List<string> { "Fruit", "Vegetable", "Meat" };
            //var products = new List<string> { "Apple", "Banana", "Carrot", "Broccoli", "Chicken", "Beef" };

            //var categoryProductPairs = categories
            //    .SelectMany(category => products, (category, product) => new { Category = category, Product = product });
            //foreach (var item in categoryProductPairs)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.Product}");
            //}
            //var studentNames = new List<string> { "Alice", "Bob", "Charlie" };
            //var studentGrades = new List<int> { 85, 90, 78 };

            //var studentsWithGrades = studentNames.Zip(studentGrades, (name, grade) => new {Name= name, Grade = grade });

            //foreach (var student in studentsWithGrades)
            //{
            //    Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
            //}

        }
    }
}
