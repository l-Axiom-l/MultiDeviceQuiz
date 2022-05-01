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
        readonly GameServer server;
        public Socket socket;
        public string ID;
        public int Points;
        public string Message;

        public GameClient(GameServer server)
        {
            this.server = server;
            Receive();
            ID = Message;
        }

        public async void Receive()
        {
            byte[] data = new byte[socket.ReceiveBufferSize];
            socket.Receive(data, SocketFlags.None);
            Message =  Encoding.ASCII.GetString(data);
        }

        public async void SendQuestion()
        {
            string temp = server.Questions[server.QuestionCount - 1];
            temp = temp.Replace("_", "");
            socket.Send(Encoding.ASCII.GetBytes(temp));
        }

        public void CheckPoints()
        {

        }
    }
}