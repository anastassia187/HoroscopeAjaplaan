using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Horoscope
{
    public partial class Ajaplaan : ContentPage
    {
        TimePicker tp;
        Image img;
        Label title, lbl, label;
        StackLayout st;
        Grid grid;
        public Ajaplaan()
        {
            tp = new TimePicker { Time = new TimeSpan(12, 0, 0) };
            tp.PropertyChanged += Tp_PropertyChanged;
            title = new Label { Text = "Распорядок дня", FontSize = 30, HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand };
            img = new Image { Source = "chasy.jpg" };
            TapGestureRecognizer tap = new TapGestureRecognizer();

            img.GestureRecognizers.Add(tap);

            lbl = new Label { Text = "" };
            label = new Label { Text = "" };

            st = new StackLayout { Children = { title, tp, lbl, label } };

            grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) }
                },
            };
            grid.Children.Add(st, 0, 0);
            grid.Children.Add(img, 0, 1);
            Content = grid;
        }

        private void Tp_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            lbl.Text = "выбранное время: " + tp.Time;
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                TimeCheck();
            }
        }

        public void TimeCheck()
        {
            var time = tp.Time.Hours;
            if (time == 00)
            {
                label.Text = "Спокойной ночи!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "sp.jpg";
            }
            else if (time == 5)
            {
                label.Text = "Доброе утро!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "utro.jpg";
            }
            else if (time == 6)
            {
                label.Text = "Завтрак!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "zavtrak.jpg";
            }
            else if (time == 7)
            {
                label.Text = "Душ!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "dush.jpg";
            }
            else if (time == 8)
            {
                label.Text = "Работа!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "rabota.jpg";
            }
            else if (time == 12)
            {
                label.Text = "Обед!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "obed.jpg";
            }
            else if (time == 13)
            {
                label.Text = "Пора за работу!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "rbt.jpg";
            }
            else if (time == 14)
            {
                label.Text = "Кофе пауза!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "kofe.jpg";
            }
            else if (time == 15)
            {
                label.Text = "И снова за работу!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "zdun.jpg";
            }
            else if (time == 17)
            {
                label.Text = "Конец рабочего дня";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "konec.jpg";
            }
            else if (time == 18)
            {
                label.Text = "Покупки в магазине!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "shop.jpg";
            }
            else if (time == 19)
            {
                label.Text = "Ужин!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "uzin.jpg";
            }
            else if (time == 20)
            {
                label.Text = "Прогулка!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "progulka.jpg";
            }
            else if (time == 21)
            {
                label.Text = "Время просмотра хорошего кино!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "kino.jpg";
            }
            else if (time == 22)
            {
                label.Text = "Чтение любимой книги!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "knigi.jpg";
            }
            else if (time == 23)
            {
                label.Text = "Подготовка ко сну!";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "son.jpg";
            }
            else
            {
                label.Text = "Введите верное время";
                label.FontSize = 30;
                label.TextColor = Color.Black;
                img.Source = "chasy.jpg";
            }
        }
    }
}

