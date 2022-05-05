using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace QuizHost
{
    internal class GameServer
    {
        public TcpListener listener;
        public List<GameClient> Clients = new List<GameClient>();
        public string IP = "10.0.0.7";
        public string IP2;
        public event EventHandler ClientConnected;

        public List<string> Questions = new List<string>();
        public string[] CurrentQuestion = new string[6];
        public int QuestionCount = 0;


        public GameServer()
        {
            IP = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
            IP2 = GetPublicIpAddress();
            listener = new TcpListener(IPAddress.Parse(IP), 700);
            listener.Start();
            StartSocket();
            new Thread(CheckForReady).Start();
        }

        void StartSocket()
        {
            listener.BeginAcceptSocket(new AsyncCallback(AcceptSocket), listener);
        }

        void AcceptSocket(IAsyncResult result)
        {
            TcpListener temp = (TcpListener)result.AsyncState;
            Clients.Add(new GameClient(this, temp.EndAcceptSocket(result)));
            StartSocket();
            ClientConnected.Invoke(this, EventArgs.Empty);
        }

        public void LoadQuiz(string Path) //Läd die Fragen aus einem File
        {
            Questions = File.ReadAllLines(Path).ToList();
        }

        public void LoadQuestion(int QuestionNumber) //Läd eine bestimmte (Index) Frage
        {
            string[] temp = Questions[QuestionNumber].Split(':');
            CurrentQuestion[0] = temp[0];
            temp = temp[1].Split('-');

            CurrentQuestion[1] = temp[0];
            CurrentQuestion[2] = temp[1];
            CurrentQuestion[3] = temp[2];
            CurrentQuestion[4] = temp[3];
        }

        public void LoadQuestion() //Läd die nächste Frage
        {
            if (QuestionCount > Questions.Count)
            {
                OutofQuestions();
                return;
            }

            string[] temp = Questions[QuestionCount].Split(':');
            CurrentQuestion[0] = temp[0];
            temp = temp[1].Split('-');

            CurrentQuestion[1] = temp[0];
            CurrentQuestion[2] = temp[1];
            CurrentQuestion[3] = temp[2];
            CurrentQuestion[4] = temp[3];
            QuestionCount++;
        }

        void OutofQuestions()
        {
            Clients.ForEach(x => x.SendEnd());
        }

        private static string GetPublicIpAddress()
        {
            using (var client = new WebClient())
            {
                return client.DownloadString("http://ifconfig.me").Replace("\n", "");
            }
        }

        public async void StartGame()
        {
            foreach (GameClient Client in Clients)
                Client.Ready();

            await Task.Delay(500);

            foreach (GameClient Client in Clients)
                Client.SendQuestion();
        }

        public void CheckForReady()
        {
            while(true)
            {
                if (Clients.Count == 0)
                    continue;

                if(Clients.All(x => x.ReadyState == true))
                {
                    Clients.ForEach(x => x.ReadyState = false);
                    LoadQuestion();
                    StartGame();
                }
            }
        }
    }
}
