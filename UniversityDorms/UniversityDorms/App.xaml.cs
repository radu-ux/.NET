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
        public static List<User> Users { get; private set; }
        public static string DORMS_URL = "http://192.168.1.109:8000/dorms";
        public static string USERS_URL = "http://192.168.1.109:8000/users";
        public static string STORE_USER_URL = "http://192.168.1.109:8000/store-user";
        public static HttpJsonDataService dormService = new HttpJsonDataService();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Dorms = dormService.GetDorms();
            Users = dormService.GetUsers();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
