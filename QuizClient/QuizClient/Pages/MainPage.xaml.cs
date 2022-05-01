using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Sockets;

namespace QuizClient
{
    public partial class MainPage : ContentPage
    {
        TcpClient client;
        NetworkStream stream;

        public MainPage()
        {
            InitializeComponent();
            ConnectButton.Clicked += Connect;

        }

        void Connect(object s, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse(IP.Text), 700);
            stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes(Username.Text);
            stream.Write(buffer, 0, buffer.Length);
        }
    }
}
