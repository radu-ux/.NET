using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDorms.models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniversityDorms.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string DormName { get;  private set; }
        public LoginPage(string dormName)
        {
            InitializeComponent();
            DormName = dormName;
        }

        private async void submitButtonClicked(object sender, EventArgs args)
        {
            User user = UserList.getUserByAccount(Email.Text, Password.Text);

            if (user != null)
            {
                if (!user.hasUserReservedTheDorm(user, DormName))
                {
                    Console.WriteLine("User can reserve the dorm ", DormName);
                    user.reserveDorm(DormName);
                    await App.dormService.StoreUser(user);
                    await Navigation.PopToRootAsync();
                } 
                else
                {
                    await DisplayActionSheet("Dorm Already Reserved !", "Cancel", null);
                }
                
            }
            else
            {
                await DisplayActionSheet("Invalid Credentials !", "Cancel", null);
            }
        }
    }
}