using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Horoscope
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            BackgroundImageSource = "zvezda.jpg";

            Button button = new Button
            {
                Text = "Гороскоп",
                FontSize = 20,
                BackgroundColor = Color.DarkBlue,
                TextColor = Color.White,
                CornerRadius = 10
            };
            Button button1 = new Button
            {
                Text = "Распорядок дня",
                FontSize = 20,
                BackgroundColor = Color.DarkBlue,
                TextColor = Color.White,
                CornerRadius = 10
            };

            button.Clicked += Button_Clicked;
            button1.Clicked += Button1_Clicked;

            StackLayout stackLayout = new StackLayout
            {
                Children = { button, button1 }
            };

            Content = stackLayout;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HoroscopePage());
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ajaplaan());
        }
    }
}



