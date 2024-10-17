using System.Xml.Linq;

namespace EventDelegate
{
    public delegate void MessageDelegate(string name);
    internal class Program
    {
        //public delegate void TaskCompleted(string message);


        public static void PrintMessage(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        //public static void PrintGoodByeMessage(string name)
        //{
        //    Console.WriteLine($"Goodbye {name}!");
        //}
        private static void ProcessorFileProcessed(object sender, FileEventArgs e)
        {
            Console.WriteLine($"File {e.FileName} was processed in Class {sender.GetType()}");
        }

        static void Main(string[] args)
        {
            //MessageDelegate messageDelegate1 = PrintMessage;
            //MessageDelegate messageDelegate2 = PrintGoodByeMessage;
            //MessageDelegate messageDelegate = messageDelegate1;
            //messageDelegate -= PrintMessage;
            //messageDelegate?.Invoke("Tom");
            //messageDelegate("Jhon");
            //messageDelegate("Maria");



            //TaskCompleted taskCompleted = messege => Console.WriteLine(messege);

            //PerformTask(3, taskCompleted);

            //Console.WriteLine("Main thread continues to run ...");
            //Console.ReadLine();
            //Button button = new Button();
            //button.Click += ButtonClick;

            //button.OnClick();
            //button.OnClick();
            //button.OnClick();
            //button.OnClick();
            //button.OnClick();
            FileProcessor processor = new FileProcessor();
            processor.FileProcessed += ProcessorFileProcessed;
            processor.Message += PrintMessage;
            processor.ProcessFile("Google.exe");
            processor.ProcessFile("File.txt");
            processor.ProcessFile("Logo.psd");
        }
        //public static void PerformTask(int seconds, TaskCompleted onCompete)
        //{
        //    new Thread(() =>
        //    {
        //        Console.WriteLine($"Task started({seconds} seconds)");
        //        Thread.Sleep(seconds * 1000);
        //        onCompete?.Invoke("TaskComplete");
        //    }).Start();
        //}

        private static void ButtonClick()
        {
            Console.WriteLine("Button was Clicked!!!");
        }

        public class Button
        {
            public event Action Click;

            public void OnClick()
            {
                if(Click != null)
                {
                    Click.Invoke();
                }
            }
        }

        public class FileEventArgs : EventArgs
        {
            public string FileName { get; set; }
        }

        public class FileProcessor
        {
            public event MessageDelegate Message;
            public event EventHandler<FileEventArgs> FileProcessed;

            public void ProcessFile(string fileName)
            {
                Console.WriteLine($"File \"{fileName}\" in processing!");
                OnFileProcessed(new FileEventArgs { FileName = fileName });
            }
            protected virtual void OnFileProcessed(FileEventArgs e)
            {
                FileProcessed?.Invoke(this, e);
                Message?.Invoke("FileProcessed");
            }
        }

    }
}
