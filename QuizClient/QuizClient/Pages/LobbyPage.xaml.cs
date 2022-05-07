using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Axiom;
using System.IO;

namespace QuizClient.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LobbyPage : ContentPage
    {
        ConnectPage Main;
        List<Label> scoreboard;
        public LobbyPage(ConnectPage Page)
        {
            InitializeComponent();
            Main = Page;
            Main.receiver.MessageReceived += WaitForMessage;
            Back.Clicked += OnBackButtonPressed;
            scoreboard = Layout.Children.Where(x => x.BackgroundColor == Color.Gray).Select(x => x as Label).ToList();
        }

        void OnBackButtonPressed(object s, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("Disconnect/" + "BackButton");
            Main.stream.Write(buffer, 0, buffer.Length);
            Main.Disconnect();
            Navigation.PopToRootAsync();
        }

        public async void WaitForMessage(object s, MessageArgs m)
        {
            await Device.InvokeOnMainThreadAsync(() =>
            {
                string[] message = m.Message.Split('/');
                switch (message[0])
                {
                    case "Ready":
                        Navigation.PushAsync(new QuizPage(Main, this));
                        break;
                    case "End":
                        End();
                        break;
                    case "Score":
                        IDText.Text = Main.name;

                        string[] temp = message[1].Split('*');
                        for (int i = 0; i < temp.Length; i++)
                        {
                            scoreboard[i].Text = temp[i];
                        }
                        break;
                }
            });
        }

        void End()
        {

        }

    }
}