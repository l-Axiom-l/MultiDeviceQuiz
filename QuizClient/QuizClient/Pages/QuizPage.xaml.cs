using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizClient.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        ConnectPage Main;
        LobbyPage Lobby;

        public QuizPage(ConnectPage Page, LobbyPage lobby)
        {
            InitializeComponent();
            Main = Page;
            Lobby = lobby;
            LoadQuestion();

            Answer1.Clicked += SendAnswer;
            Answer2.Clicked += SendAnswer;
            Answer3.Clicked += SendAnswer;
            Answer4.Clicked += SendAnswer;
        }

        async void LoadQuestion()
        {
            string text;
            byte[] buffer = new byte[500];
            await Main.stream.ReadAsync(buffer, 0, 500);
            text = Encoding.ASCII.GetString(buffer);

            string[] temp = text.Split(':');
            Question.Text = temp[0];
            temp = temp[1].Split('-');

            Answer1.Text = temp[0];
            Answer2.Text = temp[1];
            Answer3.Text = temp[2];
            Answer4.Text = temp[3];
        }

        void SendAnswer(object s, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes((s as Button).Text);
            Main.stream.Write(buffer, 0, buffer.Length);
            Lobby.WaitForReady();
            Navigation.PopAsync();
        }
    }
}