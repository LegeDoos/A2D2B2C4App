﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2D2B2C4App
{
    public partial class App : Application
    {
        public static string databaseLocation = string.Empty;

        public App()
        {
            InitializeComponent();
            //NavigationPage toegevoegd.
            MainPage = new NavigationPage(new MainPage());
        }

        public App(string dbLocation)
        {
            InitializeComponent();
            databaseLocation = dbLocation;
            MainPage = new NavigationPage(new MainPage());
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
