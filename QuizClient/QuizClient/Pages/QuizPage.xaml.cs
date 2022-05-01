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

        public QuizPage(ConnectPage Page)
        {
            InitializeComponent();
            Main = Page;
            LoadQuestion();
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
    }
}