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
        public Receiver receiver;

        public ConnectPage()
        {
            InitializeComponent();
            ConnectButton.Clicked += Connect;
        }

        async void Connect(object s, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(IP.Text), 700);
                stream = client.GetStream();
                byte[] buffer = Encoding.ASCII.GetBytes("ID/" + Username.Text);
                receiver = new Receiver(client.Client);
                stream.Write(buffer, 0, buffer.Length);
                await Navigation.PushAsync(new LobbyPage(this));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
