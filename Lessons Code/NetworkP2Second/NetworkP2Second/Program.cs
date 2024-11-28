using System;
using System.Net.Sockets;
using System.Text;

namespace NetworkP2Second
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //using var socet = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //using var socet = new TcpClient();
            //try
            //{
            //    await socet.ConnectAsync("127.0.0.1", 8888);
            //    Console.WriteLine("Connect success!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            using TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync("127.0.0.1", 8888);
            var stream = tcpClient.GetStream();
            var words = new string[] { "red", "blue", "yellow", "green", "test" };
            var response = new List<byte>();
            int bytesRead = 10;
            foreach (var word in words)
            {
                byte[] data = Encoding.UTF8.GetBytes(word + '\n');
                await stream.WriteAsync(data);

                while ((bytesRead = stream.ReadByte()) != '\n')
                {
                    response.Add((byte)bytesRead);
                }
                var translation = Encoding.UTF8.GetString(response.ToArray());
                Console.WriteLine($"Word {word}: {translation}");
                response.Clear();
            }
            await stream.WriteAsync(Encoding.UTF8.GetBytes("END\n"));

            //byte[] buffer = new byte[512];  

            //int bytes = await stream.ReadAsync(buffer);

            //string time = Encoding.UTF8.GetString(buffer,0, bytes);
            //Console.WriteLine($"Current time: {time}");

            //var message = "Hello to server!\nTest";
            //var requestData = Encoding.UTF8.GetBytes(message);
            //var stream = tcpClient.GetStream();
            //await stream.WriteAsync(requestData);
            //Console.WriteLine("Data was send");


            //var messages = new string[] { "Hello to server!\n", "Hello to server!\n", "How Are you!\n", "Goodbye to server!\n", "END\n" };
            //var stream = tcpClient.GetStream();
            //foreach (var message in messages)
            //{
            //    var requestData = Encoding.UTF8.GetBytes(message);
            //    await stream.WriteAsync(requestData);
            //}
            //Console.WriteLine("Data was send");



        }
    }
}
