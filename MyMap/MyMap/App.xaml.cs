﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(MainPage);
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
