using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkP2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //try
            //{
            //    await socket.ConnectAsync("www.google.com", 80);
            //    Console.WriteLine("Connect success!");
            //    Console.WriteLine($"Conected: {socket.RemoteEndPoint}");
            //    Console.WriteLine($"My IP: {socket.LocalEndPoint}");

            //    var message = $"GET / HTTP/1.1\r\nHost: www.google.com\r\nConnection: close\r\n\r\n";

            //    var messageBytes = Encoding.UTF8.GetBytes(message);
            //    int bytesSend = await socket.SendAsync(messageBytes);
            //    Console.WriteLine($"Was send {bytesSend} bytes");

            //    var responseBytes = new byte[512];
            //    var builder = new StringBuilder();
            //    int bytes;
            //    int bytesReseive = 0;
            //    do
            //    {
            //        bytes = await socket.ReceiveAsync(responseBytes);
            //        bytesReseive += bytes;
            //        string resposePart = Encoding.UTF8.GetString(responseBytes, 0, bytes);
            //        builder.Append(resposePart);
            //    }
            //    while (bytes > 0);

            //    Console.WriteLine($"Message({bytesReseive}bytes): {builder}");

            //    await socket.DisconnectAsync(true);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8888);
            //using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //socket.Bind(iPEndPoint);

            //Console.WriteLine(socket.LocalEndPoint);

            //socket.Listen(1000);

            //Console.WriteLine("Server runing...");

            //while (true)
            //{

            //    using Socket client = await socket.AcceptAsync();

            //    Console.WriteLine($"Client adress = {client.RemoteEndPoint}");

            //}



            //using TcpClient tcpClient = new TcpClient();
            //try
            //{
            //    await tcpClient.ConnectAsync("www.google.com", 80);
            //    Console.WriteLine("Connect success!");
            //    Console.WriteLine($"Conected: {tcpClient.Client.RemoteEndPoint}");
            //    Console.WriteLine($"My IP: {tcpClient.Client.LocalEndPoint}");

            //    var stream = tcpClient.GetStream();
            //    var message = $"GET / HTTP/1.1\r\nHost: www.google.com\r\nConnection: close\r\n\r\n";

            //    var messageBytes = Encoding.UTF8.GetBytes(message);
            //    await stream.WriteAsync(messageBytes);
            //    Console.WriteLine($"message was send ");

            //    var responseBytes = new byte[512];
            //    var builder = new StringBuilder();
            //    int bytes;
            //    int bytesReseive = 0;
            //    do
            //    {
            //        bytes = await stream.ReadAsync(responseBytes);
            //        bytesReseive += bytes;
            //        string resposePart = Encoding.UTF8.GetString(responseBytes, 0, bytes);
            //        builder.Append(resposePart);
            //    }
            //    while (stream.DataAvailable);

            //    Console.WriteLine($"Message({bytesReseive}bytes): {builder}");

            //    tcpClient.Close();
            //    Console.WriteLine($"Tcp status: {tcpClient.Connected}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //var tcpListener = new TcpListener(IPAddress.Any, 8888);

            //try
            //{
            //    tcpListener.Start();
            //    Console.WriteLine("Server runing...");
            //    while (true)
            //    {
            //        using var tcpClient = await tcpListener.AcceptTcpClientAsync();
            //        Console.WriteLine($"Conected {tcpClient.Client.RemoteEndPoint}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    tcpListener.Stop();
            //}



            //var tcpListener = new TcpListener(IPAddress.Any, 8888);

            //try
            //{
            //    tcpListener.Start();
            //    Console.WriteLine("Server runing...");

            //    //while (true)
            //    //{
            //    //    using var client = await tcpListener.AcceptTcpClientAsync();

            //    //    var stream = client.GetStream();

            //    //    //byte[] data = Encoding.UTF8.GetBytes(DateTime.Now.ToLongTimeString());

            //    //    //await stream.WriteAsync(data);
            //    //    //Console.WriteLine($"Data was sended to {client.Client.RemoteEndPoint}");

            //    //    //var responseData = new byte[512];
            //    //    //int bytes = 0;
            //    //    //var response = new StringBuilder();

            //    //    //do
            //    //    //{
            //    //    //    bytes = await stream.ReadAsync(responseData);
            //    //    //    response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
            //    //    //} while (stream.DataAvailable);
            //    //    //Console.WriteLine(response);


            //    //    var buffer = new List<byte>();
            //    //    int bytesRead = '\n';

            //    //    while((bytesRead = stream.ReadByte()) != '\n')
            //    //    {
            //    //        buffer.Add((byte)bytesRead);
            //    //    }
            //    //    var message = Encoding.UTF8.GetString(buffer.ToArray());
            //    //    Console.WriteLine(message);
            //    //}


            //    while (true)
            //    {
            //        using var client = await tcpListener.AcceptTcpClientAsync();

            //        var stream = client.GetStream();

            //        var buffer = new List<byte>();
            //        int bytesRead = '\n';

            //        while (true)
            //        {
            //            while ((bytesRead = stream.ReadByte()) != '\n')
            //            {
            //                buffer.Add((byte)bytesRead);
            //            }
            //            var message = Encoding.UTF8.GetString(buffer.ToArray());
            //            if (message == "END") break;
            //            Console.WriteLine(message);
            //            buffer.Clear();
            //        }

            //    }
            //}
            //finally
            //{
            //    tcpListener.Stop();
            //}


            var tcpListener = new TcpListener(IPAddress.Any, 8888);
            var words = new Dictionary<string, string>()
            {
                {"red", "красный" },
                {"blue", "синий" },
                {"green", "зеленый" }
            };
            try
            {
                tcpListener.Start();
                Console.WriteLine("Server runing...");
                while (true)
                {
                    using var client = await tcpListener.AcceptTcpClientAsync();

                    var stream = client.GetStream();

                    var buffer = new List<byte>();
                    int bytesRead = '\n';
                    while (true)
                    {
                        while ((bytesRead = stream.ReadByte()) != '\n')
                        {
                            buffer.Add((byte)bytesRead);
                        }
                        var word = Encoding.UTF8.GetString(buffer.ToArray());

                        if (word == "END") break;

                        Console.WriteLine($"Requested translate for {word}");

                        if (!words.TryGetValue(word, out var translation)) translation = "Not found";

                        translation += '\n';

                        await stream.WriteAsync(Encoding.UTF8.GetBytes(translation));
                        buffer.Clear();
                    }
                }
            }
            finally
            {
                tcpListener.Stop();
            }
        }
    }
}
