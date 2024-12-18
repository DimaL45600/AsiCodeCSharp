using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLesson
{
    internal class ConnectionData
    {
        private bool isHost;
        public bool IsHost { get { return isHost; } }
        private TcpListener _listener;
        private TcpClient _client;
        private NetworkStream _stream;

        public event Action<string> OnMessageReceived;
        public event Action OnClientConnected;
        public event Action OnClientDisconnected;

        string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No IPv4 address found!");
        }
        public string GetHostData()
        {
            return $"{GetLocalIPAddress()}:8742";
        }

        public void Start(bool isHost, string ip = "" )
        {
            this.isHost = isHost;
            if(isHost)
            {
                _listener = new TcpListener(IPAddress.Any, 8742);
                _listener.Start();
                Console.WriteLine($"Server started on port:{8742}");

                _listener.BeginAcceptTcpClient(AcceptClientCallback, null);
            }
            else
            {
                try
                {
                    _client = new TcpClient();
                    _client.Connect(ip, 8742);

                    _stream = _client.GetStream();

                    // Начинаем слушать сообщения
                    Thread receiveThread = new Thread(ReceiveMessages);
                    receiveThread.Start();
                    OnClientConnected?.Invoke();
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"Connect error: {ex.Message}");
                    OnMessageReceived?.Invoke("Connect to server error");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Overal error: {ex.Message}");
                    OnMessageReceived?.Invoke("Connection error");
                }
            }
            
        }
        
        private void AcceptClientCallback(IAsyncResult ar)
        {
            try
            {
                _client = _listener.EndAcceptTcpClient(ar);
                _stream = _client.GetStream();
                Console.WriteLine("Client connected");

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                OnClientConnected?.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accepting client: {ex.Message}");
                Disconnect();
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                if (_client?.Connected == true && _stream != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    _stream.Write(data, 0, data.Length);
                }
                else
                {
                    Console.WriteLine("Connection is not available.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error while sending message: {ex.Message}");
                Disconnect();
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (_client?.Connected == true)
                {
                    int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        OnMessageReceived?.Invoke(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while receiving messages: {ex.Message}");
                Disconnect();
            }
        }

        public void Disconnect()
        {
            try
            {
                _stream?.Close();
                _client?.Close();
                _listener?.Stop();
                OnClientDisconnected?.Invoke();
                Console.WriteLine("Disconnected");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during disconnection: {ex.Message}");
            }
        }
    }
}
