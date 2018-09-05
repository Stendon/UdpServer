
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UdpServer
{
    class UdpServer
    {
        public delegate void OnReceivceMsg(string msg);
        public event OnReceivceMsg receiveMsg;

        private Socket socket;
        private IPEndPoint localEndPoint;
        private EndPoint clientEndPoint;

        public UdpServer(int port)
        {
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            socket.Bind(localEndPoint);

            clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
        }

        public void SendMsg(string msg)
        {
            socket.SendTo(Encoding.UTF8.GetBytes(msg), clientEndPoint);
        }

        public void Receive()
        {
            byte []buffer = new byte[1024];
            while (true)
            {
                int length = socket.ReceiveFrom(buffer, ref clientEndPoint);
                if (length > 0)
                {
                    string msg = Encoding.UTF8.GetString(buffer, 0, length);
                    receiveMsg(msg);
                }
                else
                    Thread.Sleep(100);
            }
        }
    }
}
