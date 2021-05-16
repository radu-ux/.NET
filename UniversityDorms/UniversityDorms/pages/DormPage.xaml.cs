using System;
using UniversityDorms.models;
using UniversityDorms.pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniversityDorms.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DormPage : ContentPage
    {
        public string ButtonId { get; private set; }
        private Dorm dormObject = new Dorm();
        public DormPage(string btnId)
        {
            InitializeComponent();
            ButtonId = btnId;
            foreach(Dorm d in App.Dorms) {
                if(btnId == d.DormName)
                {
                    dormObject.DormName = d.DormName;
                    dormObject.DormLocation = d.DormLocation;
                    dormObject.NrOfFloors = d.NrOfFloors;
                    dormObject.NrOfRooms = d.NrOfRooms;
                    dormObject.PricePerMonth = d.PricePerMonth;
                    dormObject.StudentPerRoom = d.StudentPerRoom;

                }
            }
            DisplayData();
        }

        private void DisplayData()
        {
            DormPageTitle.Text = dormObject.DormName;
            DormLocation.Text = "Location: " + dormObject.DormLocation;
            NrOfFloors.Text = "Number of floors: " + dormObject.NrOfFloors.ToString();
            NrOfRooms.Text = "Number of rooms: " + dormObject.NrOfRooms.ToString();
            PricePerMonth.Text = "Price per month: " + dormObject.PricePerMonth.ToString() + " lei";
            StudentPerRoom.Text = "Students per room: " + dormObject.StudentPerRoom.ToString();
        }

        private async void reserveButtonClicked(object sender, EventArgs args)
        {
            Button pressedBtn = (Button)sender;
            Navigation.PushAsync(new LoginPage(dormObject.DormName));
        }
    }
}