﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuizClient.Pages;

namespace QuizClient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ConnectPage() { });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
