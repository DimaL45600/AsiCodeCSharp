

using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NetworkP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //37.120.16.63
            //2001:0db8:85a3:0000:0000:8a2e:0370:7334 
            //IPAddress iP1 = new IPAddress(new byte[] { 127, 0, 0, 1 });
            //Console.WriteLine(iP1);

            //IPAddress iP2 = new IPAddress(0x0100007F);
            //Console.WriteLine(iP2);

            //IPAddress iP3 = IPAddress.Parse("127.0.0.1");
            //Console.WriteLine(iP3);

            //IPAddress.TryParse("127.0.0.1dfsdg", out IPAddress? iP4);
            //Console.WriteLine(iP4?.ToString());

            //Console.WriteLine(IPAddress.Loopback);
            //Console.WriteLine(IPAddress.Any);
            //Console.WriteLine(IPAddress.Broadcast);

            //Console.WriteLine(iP1.AddressFamily);

            //IPEndPoint endPoint1 = new IPEndPoint(iP1, 8080);
            //Console.WriteLine(endPoint1);

            //Uri uri = new Uri("https://user:password@www.somesite.com:443/home/index?q1=v1&q2=v2#fragmentName");
            //Console.WriteLine($"AbsolutePath: {uri.AbsolutePath}");
            //Console.WriteLine($"AbsoluteUri: {uri.AbsoluteUri}");
            //Console.WriteLine($"Fragment: {uri.Fragment}");
            //Console.WriteLine($"Host: {uri.Host}");
            //Console.WriteLine($"IsAbsoluteUri: {uri.IsAbsoluteUri}");
            //Console.WriteLine($"IsDefaultPort: {uri.IsDefaultPort}");
            //Console.WriteLine($"IsFile: {uri.IsFile}");
            //Console.WriteLine($"IsLoopback: {uri.IsLoopback}");
            //Console.WriteLine($"OriginalString: {uri.OriginalString}");
            //Console.WriteLine($"PathAndQuery: {uri.PathAndQuery}");
            //Console.WriteLine($"Port: {uri.Port}");
            //Console.WriteLine($"Query: {uri.Query}");
            //Console.WriteLine($"Scheme: {uri.Scheme}");
            //Console.WriteLine($"Segments: {string.Join(", ", uri.Segments)}");
            //Console.WriteLine($"UserInfo: {uri.UserInfo}");

            //UriBuilder uriBuilder1 = new UriBuilder("http", "googledata.com", 80, "test/data");
            //Uri uri1 = uriBuilder1.Uri;
            //Console.WriteLine(uri1);


            //UriBuilder uriBuilder2 = new UriBuilder();
            //uriBuilder2.Scheme = "https";
            //uriBuilder2.Host = "somesite.com";
            //uriBuilder2.Port = 80;
            //uriBuilder2.Path = "home";
            //uriBuilder2.Query = "name=Tom&age=38";
            //uriBuilder2.Fragment = "account-info";
            //Uri url2 = uriBuilder2.Uri;
            //Console.WriteLine(url2);

            //var googleEntry = Dns.GetHostEntry("google.com");
            //Console.WriteLine(googleEntry.HostName);
            //foreach(var ip in googleEntry.AddressList)
            //{
            //    Console.WriteLine(ip);
            //}

            //var adapters = NetworkInterface.GetAllNetworkInterfaces();
            //Console.WriteLine($"Обнаружено {adapters.Length} устройств");
            //foreach (NetworkInterface adapter in adapters)
            //{
            //    Console.WriteLine("=====================================================================");
            //    Console.WriteLine();
            //    Console.WriteLine($"ID устройства: ------------- {adapter.Id}");
            //    Console.WriteLine($"Имя устройства: ------------ {adapter.Name}");
            //    Console.WriteLine($"Описание: ------------------ {adapter.Description}");
            //    Console.WriteLine($"Тип интерфейса: ------------ {adapter.NetworkInterfaceType}");
            //    Console.WriteLine($"Физический адрес: ---------- {adapter.GetPhysicalAddress()}");
            //    Console.WriteLine($"Статус: -------------------- {adapter.OperationalStatus}");
            //    Console.WriteLine($"Скорость: ------------------ {adapter.Speed}");

            //    IPInterfaceStatistics stats = adapter.GetIPStatistics();
            //    Console.WriteLine($"Получено: ----------------- {stats.BytesReceived}");
            //    Console.WriteLine($"Отправлено: --------------- {stats.BytesSent}");
            //}

            //var ipProps = IPGlobalProperties.GetIPGlobalProperties();
            //var tcpConnections = ipProps.GetActiveTcpConnections();

            //Console.WriteLine($"Всего {tcpConnections.Length} активных TCP-подключений");
            //Console.WriteLine();
            //foreach (var connection in tcpConnections)
            //{
            //    Console.WriteLine("=============================================");
            //    Console.WriteLine($"Локальный адрес: {connection.LocalEndPoint.Address}:{connection.LocalEndPoint.Port}");
            //    Console.WriteLine($"Адрес удаленного хоста: {connection.RemoteEndPoint.Address}:{connection.RemoteEndPoint.Port}");
            //    Console.WriteLine($"Состояние подключения: {connection.State}");
            //}

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Socket socketUdp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //socket.Close();
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                socket.Close();
            }
        }
    }
}
