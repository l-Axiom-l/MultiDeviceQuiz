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
            Loop();
        }

        async void Loop()
        {
            while (true)
            {
            byte[] data = new byte[100];
            await Main.stream.ReadAsync(data, 0, 100);
            if (Encoding.ASCII.GetString(data) == "Ready")
                await Navigation.PushAsync(new QuizPage(Main));
            }
        }
    }
}