using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Sockets;

namespace QuizClient.Pages
{
    public partial class ConnectPage : ContentPage
    {
        public TcpClient client;
        public NetworkStream stream;

        public ConnectPage()
        {
            InitializeComponent();
            ConnectButton.Clicked += Connect;
        }

        void Connect(object s, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse(IP.Text), 700);
            stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes("ID/" + Username.Text);
            stream.Write(buffer, 0, buffer.Length);
            Navigation.PushAsync(new LobbyPage(this));
        }
    }
}
