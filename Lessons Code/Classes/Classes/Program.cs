using System.Xml.Linq;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book b1 = new Book { author = "Timofei" };
            Book b1 = new Book();
            Console.WriteLine(b1.ToString());
            Console.WriteLine("----------------------");
            Book b2 = new Book("Колобок","Timofey",93);
            Console.WriteLine(b2.ToString());
            //Console.WriteLine("----------------------");
            Humman h1 = new Humman();
            //Console.WriteLine(h1.Name);
            //Console.WriteLine(h1.Age);
            //Console.WriteLine(h1.birthdayDate.ToShortDateString());
            //h1.Age = 456;
            //Console.WriteLine(h1.Age);
            //Console.WriteLine(h1.birthdayDate.ToShortDateString());
            Console.WriteLine("----------------------");
            Console.WriteLine(h1.ToString());
            Console.WriteLine("----------------------");
            h1.AddBookToCollection(b1);
            h1.AddBookToCollection(b2);
            Console.WriteLine(h1.BooksCollection);
            Console.WriteLine(h1.CheckBook("Сталкер"));
            Console.WriteLine(h1.CheckBook("Колобок"));
            Console.WriteLine(h1.CheckBook("C# for beginers"));
            h1.RemoveBookFromCollection("Колобок");
            h1.RemoveBookFromCollection("C# for beginers");
            Console.WriteLine(h1.BooksCollection);
        }
    }
    public class Book
    {
        public string name;
        public int pagesCount;
        public string author;
        public Book()
        {
            name = "Сталкер";
            pagesCount = 375;
            author = "Андрей Левицкий";
        }
        public Book(string name, string author, int pagesCount)
        {
            this.name = name;
            this.pagesCount = pagesCount;
            this.author = author;         
        }
        public override string ToString()
        {
            return $"{name}, {author}({pagesCount})";
        }
    }
    public class Humman
    {
        string name;
        public DateTime birthdayDate;
        List<Book> bookCollection;
        public Humman()
        {
            name = "Yaroslav";
            birthdayDate = DateTime.Parse("01.08.2002");
            bookCollection = new List<Book>();
        }
        public string Name
        {
            get => name; 
            set => name = value;
        }
        public int Age
        {
            get => DateTime.Now.Year - birthdayDate.Year;
            set {
                if (value >= 0 && value < 130) birthdayDate = DateTime.Now.AddYears(-value); 
            }
        }
        public string BooksCollection
        {
            get 
            {
                string result = $"{Name}'s books collection: ";
                foreach (Book book in bookCollection) 
                {
                    result += book.name + ", ";
                }
                return result;
            }
        }
        public void AddBookToCollection(Book newBook)
        {
            bookCollection.Add(newBook);
            Console.WriteLine($"Book \"{newBook.name}\" added to collection!");
        }
        public string FormatToString()
        {
            return $"{Name}, {birthdayDate.ToShortDateString()}({Age})";
        }
        public override string ToString()
        {
            return $"{Name}, {birthdayDate.ToShortDateString()}({Age})";
        }
        public string CheckBook(string name)
        {
            Book searchedBook = bookCollection.FirstOrDefault(x => x.name == name);
            if (searchedBook != null)
            {
                return $"{searchedBook.ToString()} was found in {this.name}'s collection";
            }
            return $"book \"{name}\" was not found in {this.name}'s collection";
        }
        public void RemoveBookFromCollection(string name)
        {
            Book searchedBook = bookCollection.FirstOrDefault(x => x.name == name);
            if (searchedBook != null)
            {
                bookCollection.Remove(searchedBook);
                Console.WriteLine($"Book \"{name}\" was removed from collection");
            }
            else
            {
                Console.WriteLine($"Book \"{name}\" was not found in collection");
            }
        }
    }
}
