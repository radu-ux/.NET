using System;
using System.Collections.Generic;
using UniversityDorms.models;
using UniversityDorms.services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniversityDorms
{
    public partial class App : Application
    {
        public static List<Dorm> Dorms { get; private set; }
        public static string URL = "http://192.168.1.109:8000/Desktop/dorms.json";
        private HttpJsonDataService dormService = new HttpJsonDataService();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Dorms = dormService.GetDorms();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
