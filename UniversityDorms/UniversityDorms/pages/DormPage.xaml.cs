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
                    dormObject.NrOfFlors = d.NrOfFlors;
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
        }
    }
}