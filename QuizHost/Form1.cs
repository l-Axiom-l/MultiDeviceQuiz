using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizHost
{
    public partial class Form1 : Form
    {
        GameServer server;
        Label[] answers = new Label[4];
        public Form1()
        {
            InitializeComponent();
            server = new GameServer();
            server.ClientConnected += OnConnection;
            answers[0] = Answer1Label;
            answers[1] = Answer2Label;
            answers[2] = Answer3Label;
            answers[3] = Answer4Label;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayerCount.Text = $"PlayerCount: {server.Clients.Count}";
            Status.Text = $"PublicIP: {server.IP2}";
            QuestionCounter.Text = $"QuestionCounter: {server.QuestionCount}/{server.Questions.Count}";
            IPAddress.Text = $"IPAddress: {server.IP}";

            Players();
            QuestionText();
        }

        void Players()
        {
                Scoreboard.Items.Clear();
            foreach (GameClient temp in server.Clients)
            {
                string player = temp.ID + $"({temp.Points})";
                Scoreboard.Items.Add(player);
            }
        }

        void QuestionText()
        {
            if(server.CurrentQuestion[0] == null)
                return;

            QuestionLabel.Text = server.CurrentQuestion[0];

            int Index = 1;
            foreach(Label answer in answers)
            {
                answer.Text = server.CurrentQuestion[Index].Trim(new char[] {'_', '.'});
                if(server.CurrentQuestion[Index].Contains("_"))
                    answer.BackColor = Color.Green;
                else answer.BackColor = Color.Red;
                Index++;
            }
        }

        async void OnConnection(object s, EventArgs e)
        {
            GameClient client = server.Clients[0];
            Action safeWrite = delegate { Scoreboard.Items.Add(client.ID + $"({client.Points}) \n"); };
            Scoreboard.Invoke(safeWrite);
        }

        private void KickButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {

        }

        private void ServerBox_Enter(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            QuestionLoader.Title = "Load Question";
            QuestionLoader.Multiselect = false;
            QuestionLoader.CheckFileExists = true;
            DialogResult result =  QuestionLoader.ShowDialog();

            if (result == DialogResult.Cancel|| result == DialogResult.Abort|| result == DialogResult.No)
                return;

            server.LoadQuiz(QuestionLoader.FileName);
            //Scoreboard.Items.Add(server.Questions[0]);
            server.LoadQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.LoadQuestion();
            server.StartGame();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            server.LoadQuestion(0);
            server.QuestionCount = 1;
            server.StartGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Action action = server.Clients[0].SendQuestion;
            action.Invoke();
        }
    }
}
