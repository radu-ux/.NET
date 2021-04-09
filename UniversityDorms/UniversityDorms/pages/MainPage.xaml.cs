using Newtonsoft.Json;
using System;
using UniversityDorms.pages;
using Xamarin.Forms;

namespace UniversityDorms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void cardButtonClicked(object sender, EventArgs args)
        {
            Button pressedBtn = (Button)sender;
            await Navigation.PushAsync(new DormPage(pressedBtn.ClassId));
        }
    }

}
