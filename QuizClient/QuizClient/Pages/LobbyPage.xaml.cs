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
            WaitForReady();
        }

        public async void WaitForReady()
        {
            byte[] data = new byte[50];
            await Main.stream.ReadAsync(data, 0, 50);
            if (Encoding.ASCII.GetString(data).Contains("Ready"))
            {
                await Navigation.PushAsync(new QuizPage(Main, this));
            }
        }


    }
}