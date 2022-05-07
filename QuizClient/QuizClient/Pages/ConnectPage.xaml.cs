using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Sockets;
using Axiom;

namespace QuizClient.Pages
{
    public partial class ConnectPage : ContentPage
    {
        public TcpClient client;
        public NetworkStream stream;
        public Receiver receiver;
        public string name;

        public ConnectPage()
        {
            InitializeComponent();
            ConnectButton.Clicked += Connect;
        }

        async void Connect(object s, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse(IP.Text), 700);
            stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes("ID/" + Username.Text);
            name = Username.Text;
            receiver = new Receiver(client.Client);
            receiver.MessageReceived += Receive;
            stream.Write(buffer, 0, buffer.Length);
            await Navigation.PushAsync(new LobbyPage(this));
        }

        async void Receive(object s, MessageArgs m)
        {
            if (m.Message.Split('/')[0] == "Disconnect")
            {
                await Device.InvokeOnMainThreadAsync(async () =>
                {
                    Disconnect();
                    await DisplayAlert("Disconnect", m.Message.Split('/')[1], "Ok");
                });
            }
        }

        public async void Disconnect()
        {
            receiver.Disconnect();
            receiver = null;
            client.Close();
            client.Dispose();
            await Navigation.PopToRootAsync();
        }
    }
}
