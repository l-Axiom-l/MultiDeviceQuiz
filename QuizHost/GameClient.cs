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
        readonly Socket socket;
        public string ID;
        public int Points;
        public string Message;

        public GameClient(GameServer server, Socket socket)
        {
            this.server = server;
            this.socket = socket;
            Receive();
            ID = Message;
            ID = ID.Replace("\0", "");
        }

        public async void Receive()
        {
            byte[] data = new byte[100];
            socket.Receive(data, 100, SocketFlags.None);
            Message = Encoding.ASCII.GetString(data);
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

        public void Ready()
        {
            socket.Send(Encoding.ASCII.GetBytes("Ready"));
        }
    }
}