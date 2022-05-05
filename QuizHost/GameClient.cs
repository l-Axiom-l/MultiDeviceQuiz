using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Axiom;

namespace QuizHost
{
    internal class GameClient
    {
        readonly GameServer server;
        readonly Socket socket;
        Receiver receiver;
        public string ID;
        public int Points;
        string Answer;

        public GameClient(GameServer server, Socket socket)
        {
            this.server = server;
            this.socket = socket;
            receiver = new Receiver(socket);
            receiver.MessageReceived += Receive;
            //ID = Receive();
            //ID = ID.Replace("\0", "");
        }

        void Receive(object s, MessageArgs m)
        {
            string text = m.Message.Split('/')[1];
            string Keyword = m.Message.Split('/')[0];
            switch(Keyword)
            {
                case "Answer":
                    Answer = text;
                    CheckPoints();
                    break;

                case "ID":
                    ID = text;
                    break;
            }
        }


        //public string Receive()
        //{
        //    byte[] data = new byte[200];
        //    socket.Receive(data, 200, SocketFlags.None);
        //    return Encoding.ASCII.GetString(data);
        //}

        public void SendQuestion()
        {
            string temp = server.Questions[server.QuestionCount - 1];
            temp = temp.Replace("_", "");
            socket.Send(Encoding.ASCII.GetBytes(temp));
            //Answer = Receive().Replace("\0", "");
            //CheckPoints();
        }

        public void CheckPoints()
        {
            string answer = server.CurrentQuestion.Where(x => x.Contains("_")).ElementAt(0).Trim('_');
            if (Answer == answer)
                Points++;
        }

        public void Ready()
        {
            socket.Send(Encoding.ASCII.GetBytes("Ready"));
        }
    }
}