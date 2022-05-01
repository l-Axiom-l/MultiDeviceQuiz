using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QuizHost
{
    internal class GameClient
    {
        public Socket socket;
        public string ID;
        public int Points;
        public string Message;

        public async void Receive()
        {
            byte[] data = new byte[socket.ReceiveBufferSize];
            socket.Receive(data, SocketFlags.None);
            Message =  Encoding.UTF8.GetString(data);
        }

        public async void SendQuestion()
        {

        }

        public void CheckPoints()
        {

        }
    }
}
