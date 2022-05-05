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
    public partial class LobbyPage : ContentPage
    {
        ConnectPage Main;
        public LobbyPage(ConnectPage Page)
        {
            InitializeComponent();
            Main = Page;
            Main.receiver.MessageReceived += WaitForReady;
            //WaitForReady();
        }

        public async void WaitForReady(object s, MessageArgs message)
        {
            //byte[] data = new byte[50];
            //await Main.stream.ReadAsync(data, 0, 50);
            //if (Encoding.ASCII.GetString(data).Contains("Ready"))
            //{
            //    await Navigation.PushAsync(new QuizPage(Main, this));
            //}
            await Device.InvokeOnMainThreadAsync(() =>
            {
                if (message.Message.Contains("Ready"))
                    Navigation.PushAsync(new QuizPage(Main, this));
            });
        }


    }
}