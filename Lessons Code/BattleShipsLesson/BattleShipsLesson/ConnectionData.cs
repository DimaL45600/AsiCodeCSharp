using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLesson
{
    internal class ConnectionData
    {
        private bool isHost;
        public bool IsHost {  get { return isHost; } }

        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private NetworkStream stream;

        public event Action<string> OnMessageReceived;
        public event Action OnConnect;
        public event Action OnDisconnect;
        public event Action OnAnotherDisconect;

        private string GetLocalIPAdress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(var ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }throw new Exception("No IPv4 adress found!");
        }
        public string GetHostData()
        {
            return $"{GetLocalIPAdress()}:8742";
        }

        public void Start(bool isHost, string ip = "")
        {
            this.isHost = isHost;
            if (isHost)
            {
                tcpListener = new TcpListener(IPAddress.Any, 8742);
                tcpListener.Start();

                tcpListener.BeginAcceptTcpClient(AcceptClientCallback, null);
            }
            else
            {
                try
                {
                    tcpClient = new TcpClient();
                    tcpClient.Connect(ip, 8742);

                    stream = tcpClient.GetStream();

                    Thread reciveThread = new Thread(ReceiveMessages);
                    reciveThread.Start();

                    OnConnect?.Invoke();
                }
                catch (Exception ex)
                {
                    OnMessageReceived?.Invoke("Connection error");
                }
            }
        }
        private void AcceptClientCallback(IAsyncResult ar)
        {
            try
            {
                tcpClient = tcpListener.EndAcceptTcpClient(ar);
                stream = tcpClient.GetStream();

                Thread reciveThread = new Thread(ReceiveMessages);
                reciveThread.Start();

                OnConnect?.Invoke();
            }
            catch (Exception ex)
            {
                OnMessageReceived?.Invoke("Connection error");
                Disconnect();
            }
        }
        public void SendMessage(string message)
        {
            try
            {
                if(tcpClient.Connected == true && stream != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
                else
                {
                    OnAnotherDisconect?.Invoke();
                }
            }
            catch (Exception ex)
            {
                Disconnect();
            }
        }
        private void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while(tcpClient.Connected == true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if(bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer,0,bytesRead);
                        OnMessageReceived?.Invoke(message);
                    }
                }
                OnAnotherDisconect?.Invoke();
            }
            catch (Exception ex)
            {
                Disconnect();
            }
        }
        public void Disconnect()
        {
            stream?.Close();
            tcpClient?.Close();
            tcpListener?.Stop();
            OnDisconnect?.Invoke();
        }
    }
}
