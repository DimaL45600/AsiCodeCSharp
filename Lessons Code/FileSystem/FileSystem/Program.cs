namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var Drives = DriveInfo.GetDrives();
            //foreach (var drive in Drives)
            //{
            //    Console.WriteLine(drive.Name);
            //    Console.WriteLine(drive.TotalSize / 1024f / 1024f / 1024f);
            //    Console.WriteLine(drive.AvailableFreeSpace / 1024f / 1024f / 1024f);
            //    Console.WriteLine(drive.DriveType);
            //    Console.WriteLine(drive.DriveFormat);
            //    Console.WriteLine(drive.RootDirectory.FullName);
            //    Console.WriteLine("_______________");
            //}


            DirectoryInfo cSharpDirectory = new DirectoryInfo("C:\\Users\\lumar\\OneDrive\\Рабочий стол\\AsiCodeC#");

            WriteData(cSharpDirectory);




            DirectoryInfo testDirectory = new DirectoryInfo("C:\\Users\\lumar\\OneDrive\\Рабочий стол\\TestFolder");
            string filePath = "example.txt";
            //string copyName = "ExampleCopy.txt";
            string binaryFilePath = "person.MyData";
            //FileInfo file = new FileInfo(Path.Combine(testDirectory.FullName, filePath));
            //FileInfo file = new FileInfo(filePath);
            //Console.WriteLine(file.FullName);
            //Console.WriteLine(file.CreationTime.ToString());
            //Console.WriteLine(file.Length);
            //if (!file.Exists )
            //{
            //    file.Create();
            //}
            //FileStream fileStream = new FileStream(Path.Combine(testDirectory.FullName, filePath), FileMode.OpenOrCreate);
            //StreamWriter writer = new StreamWriter(fileStream);
            //writer.WriteLine("Hello World!");
            //writer.WriteLine("Ok!");
            //writer.Close();
            //fileStream.Close();

            //StreamReader reader = new StreamReader(fileStream);
            //string text = reader.
            //Console.WriteLine(text);
            //while (reader.Peek() != -1)
            //    int i = 0;
            //while (i < 5)
            //{
            //    string line = reader.ReadLine();
            //    char line = (char)reader.Read();
            //    Console.WriteLine(line);
            //    i++;
            //}
            //reader.Close();
            //fileStream.Close();
            //Console.WriteLine(cSharpDirectory.FullName);
            //Console.WriteLine(cSharpDirectory.Name);
            //Console.WriteLine(cSharpDirectory.Parent.FullName);
            //Console.WriteLine(cSharpDirectory.CreationTime.ToString());
            //Console.WriteLine(cSharpDirectory.LastAccessTime.ToString());

            //Peson person = new Peson { Name = "Dmytro", Age = 22 };
            //using (FileStream fileStream1 = new FileStream(Path.Combine(testDirectory.FullName, binaryFilePath), FileMode.OpenOrCreate))
            //using (BinaryWriter writer = new BinaryWriter(fileStream1))
            //{
            //    person.WriteToFile(writer);
            //}
            //Console.WriteLine("file writed");
            //Console.ReadLine();
            //Peson loadedData;
            //using (FileStream fs = new FileStream(Path.Combine(testDirectory.FullName, binaryFilePath), FileMode.Open))
            //using (BinaryReader reader2 = new BinaryReader(fs))
            //{
            //    loadedData = Peson.ReadFromFile(reader2);
            //}
            //Console.WriteLine("Объект считан из файла: " + loadedData);
        }
        public static void WriteData(DirectoryInfo currentDirectory, int level = 0)
        {
            var directories = currentDirectory.GetDirectories();
            var files = currentDirectory.GetFiles();
            for (int i = 0; i < level; i++) Console.Write("- ");
            Console.WriteLine(currentDirectory.Name);
            if (files.Length != 0)
            {
                foreach (var file in files)
                {
                    for (int i = 0; i <= level; i++) Console.Write("- ");
                    Console.WriteLine(file.Name);
                }
            }
            if (directories.Length != 0)
            {
                foreach (var directory in directories)
                {
                    WriteData(directory, level + 1);
                }
            }
        }
        public class Peson
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return $"Имя: {Name}, Возраст: {Age}";
            }
            public void WriteToFile(BinaryWriter writer)
            {
                writer.Write(Name);
                writer.Write(Age);
            }
            public static Peson ReadFromFile(BinaryReader reader)
            {
                Peson peson = new Peson()
                {
                    Name = reader.ReadString(),
                    Age = reader.ReadInt32(),
                };
                return peson;
            }
        }
    }
}
