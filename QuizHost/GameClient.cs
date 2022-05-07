using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Axiom;
using System.IO;

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
        public bool ReadyState = false;

        public GameClient(GameServer server, Socket socket)
        {
            this.server = server;
            this.socket = socket;
            receiver = new Receiver(socket);
            receiver.MessageReceived += Receive;
        }

        void Receive(object s, MessageArgs m)
        {
            string text = m.Message.Split('/')[1];
            string Keyword = m.Message.Split('/')[0];
            switch (Keyword)
            {
                case "Answer":
                    ReadyState = true;
                    Answer = text;
                    CheckPoints();
                    break;

                case "ID":
                    ID = text;
                    break;

                case "Disconnect":
                    server.Clients.Remove(this);
                    receiver.Disconnect();
                    socket.Close();
                    break;
            }
        }

        public void SendQuestion()
        {
            string temp = server.Questions[server.QuestionCount - 1];
            temp = temp.Replace("_", "");
            socket.Send(Encoding.ASCII.GetBytes("Question/" + temp));
        }

        public void SendEnd()
        {
            socket.Send(Encoding.ASCII.GetBytes($"End/Points: {Points}"));
        }

        public void SendScore()
        {
            if (ID.Length == 0)
                return;

            string temp = "Score/";
            int l = 10;

            if(server.Clients.Count < 9)
                l = server.Clients.Count;

            for (int i = 0; i < l; i++)
                temp += $"{server.Clients[i].ID}({server.Clients[i].Points})*";

            socket.Send(Encoding.ASCII.GetBytes(temp));
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

        public void Disconnect(string Message = "null")
        {
            receiver.MessageReceived -= Receive;
            receiver = null;
            socket.Send(Encoding.ASCII.GetBytes($"Disconnect/{Message}"));
            socket.Disconnect(false);
            server.Clients.Remove(this);
        }
    }
}