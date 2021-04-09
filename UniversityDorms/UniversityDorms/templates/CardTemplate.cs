using AndroidX.CardView.Widget;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UniversityDorms
{
    public class CardTemplate : ContentView
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), String.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), String.Empty);
        public static readonly BindableProperty ButtonIdProperty = BindableProperty.Create(nameof(ButtonId), typeof(string), typeof(CardView), String.Empty);

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }

        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }

        public string ButtonId
        {
            get => (string)GetValue(ButtonIdProperty);
            set => SetValue(ButtonIdProperty, value);
        }
    }
}
