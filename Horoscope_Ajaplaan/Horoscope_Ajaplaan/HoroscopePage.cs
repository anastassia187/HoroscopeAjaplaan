using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Horoscope
{
    public class HoroscopePage : ContentPage
    {

        DatePicker dp;
        Image img;
        Label lbl, sign, description;
        StackLayout st;
        Entry ent;

        public HoroscopePage()
        {
            BackgroundImageSource = "nebo.jpg";


            dp = new DatePicker
            {
                Format = "D",
                Date = DateTime.Now
            };
            dp.DateSelected += Dp_DateSelected;

            img = new Image { Source = "koleso.jpg" };
            lbl = new Label
            {
                Text = "Описание",
                FontSize = 20,
                TextColor = Color.Black,
            };
            sign = new Label { Text = "", FontSize = 25, FontAttributes = FontAttributes.Bold };
            description = new Label { Text = "", FontSize = 20, TextColor = Color.Black };


            ent = new Entry
            {
                Placeholder = "Введите знак зодиака (рус)",
                Text = "",

            };
            ent.Completed += Ent_Completed;


            st = new StackLayout { Children = { dp, img, ent, sign, description } };
            Content = st;
        }
        Dictionary<string, (string image, string description)> signData = new Dictionary<string, (string, string)>()
{
{ "Овен", ("oven.jpg", "Овен (21 марта - 19 апреля): энергичный, решительный, амбициозный, спонтанный, но также иногда несдержанный и импульсивный.")},
{ "Телец", ("telec.jpg", "Телец (20 апреля - 20 мая): упорный, надежный, трудолюбивый, заботливый, но иногда старомодный и упрямый.") },
{"Близнецы", ("bliznecy.jpg", "Близнецы (21 мая - 20 июня): общительный, любознательный, адаптивный, остроумный, но также может быть поверхностным и двуличным.")},
{"Рак",("rak.jpg","Рак (21 июня - 22 июля): чувствительный, защитнический, верный, творческий, но также может быть избирательным и эмоционально неустойчивым." ) },
{"Лев",("leo.jpg", "Лев (23 июля - 22 августа): уверенный в себе, доминирующий, добросердечный, лидерский, но также может быть эгоистичным и высокомерным.") },
{"Дева", ("deva", "Дева (23 августа - 22 сентября): практичный, аналитический, организованный, внимательный, но также может быть критичным и чрезмерно требовательным.") },
{"Весы", ("vesi.jpg", "Весы (23 сентября - 22 октября): дипломатичный, справедливый, общительный, красивый, но также может быть неопределенным и не решительным.") },
{"Стрелец", ("strelec.jpg", "Стрелец (22 ноября - 21 декабря): оптимистичный, веселый, щедрый, энергичный, но также может быть несдержанным и необдуманным.") },
{"Скорпион",("scorp.jpg", "Скорпион (23 октября - 21 ноября): страстный, интуитивный, аналитический, мистический, но также может быть мстительным и недоверчивым.") },
{"Козерог", ("kozerog.jpg", "Козерог (22 декабря - 19 января): целеустремленный, практичный, уважаемый, выдержанный, но также может быть настырным и скрытым.") },
{"Водолей", ("vodolei.jpg", "Водолей (20 января - 18 февраля): независимый, прогрессивный, оригинальный, социальный, но также может быть непредсказуемым и бунтарским.") },
{"Рыбы", ("rybi.jpg", "Рыбы (19 февраля - 20 марта): Интуитивный, чувствительный, мечтательный, склонный к жертвенности и самоотдаче.") }


};

        private void Ent_Completed(object sender, EventArgs e)
        {
            string enteredSign = ent.Text;
            if (signData.ContainsKey(enteredSign))
            {
                var signInfo = signData[enteredSign];
                img.Source = signInfo.image;
                sign.Text = enteredSign;
                sign.TextColor = Color.DarkBlue;
                description.Text = signInfo.description;
                description.TextColor = Color.Black;
            }
        }



        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            lbl.Text = "Выбранная дата: " + e.NewDate.ToString("M");
            var month = e.NewDate.Month;
            var day = e.NewDate.Day;
            st.Children.Add(sign);
            st.Children.Add(lbl);
            if (month == 3 && day >= 21 || month == 4 && day <= 20)
            {
                img.Source = "oven.jpg";
                sign.Text = "Овен";
                sign.TextColor = Color.DarkBlue;
                lbl.Text = "Дата: 21 марта – 20 апреля\nСтихия - огонь\nХарактеристика - амбициозный, независимый, нетерпеливый\nЦвета - ярко-красный, кармин, оранжевый, голубой, сиреневый, малиновый и все блестящие (фиолетовый цвет - неудачный)";

            }
            else if (month == 4 && day >= 21 || month == 5 && day <= 20)
            {
                img.Source = "telec.jpg";
                sign.Text = "Телец";
                lbl.Text = "Дата: 21 апреля – 20 мая\nСтихия - земля\nХарактеристика - основательный, музыкальный, практичный\nЦвета - лимонный, желтый, ярко голубой, глубокий оранжевый, лимонно-зеленый, оранжевый и все весенние (красный цвет неудачный)";
            }
            else if (month == 5 && day >= 21 || month == 6 && day <= 20)
            {
                img.Source = "bliznecy.jpg";
                sign.Text = "Близнецы";
                lbl.Text = "Дата: 21 мая – 20 июня\nСтихия - воздух\nХарактеристика - любопытный, нежный, добрый\nЦвета - фиолетовый, серый, светло-желтый, серо-голубой, оранжевый (зеленый цвет - неудачный)";
            }
            else if (month == 6 && day >= 21 || month == 7 && day <= 22)
            {
                img.Source = "rak.jpg";
                sign.Text = "Рак";
                lbl.Text = "Дата: 21 июня – 22 июля\nСтихия - вода\nХарактеристика - интуитивный, эмоциональный, умный, страстный\nЦвета - белый, светло-голубой, синий, серебряный, цвет зеленого горошка (серый цвет - неудачный)";
            }
            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {
                img.Source = "leo.jpg";
                sign.Text = "Лев";
                lbl.Text = "Дата: 23 июля – 22 августа\nСтихия - огонь\nХарактеристика - горделивый, самоуверенный\nЦвета - пурпурный, золотой, оранжевый, алый, черный (белый цвет - неудачный)";
            }
            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {
                img.Source = "deva.jpg";
                sign.Text = "Дева";
                lbl.Text = "Дата: 23 августа – 22 сентября\nСтихия - земля\nХарактеристика - элегантный, организованный, добрый\nЦвета - белый, голубой, фиолетовый, зеленый";
            }
            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {
                img.Source = "Vesi.jpg";
                sign.Text = "Весы";
                lbl.Text = "Дата: 23 сентября – 22 октября\nСтихия - воздух\nХарактеристика - дипломатичный, артистичный, интеллигентный\nЦвета - темно-голубой, зеленый, морской волны и пастельные тона";
            }
            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {
                img.Source = "scorp.jpg";
                sign.Text = "Скорпион";
                lbl.Text = "Дата: 23 октября – 21 ноября\nСтихия - вода\nХарактеристика - чарующий, страстный, независимый\nЦвета - желтый, темно-красный, алый, малиновый";
            }
            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {
                img.Source = "strelec.jpg";
                sign.Text = "Стрелец";
                lbl.Text = "Дата: 22 ноября – 21 декабря\nСтихия - огонь\nХарактеристика - авантюрный, творческий, волевой\nЦвета - синий, голубой, фиолетовый, багровый";
            }
            else if (month == 12 && day >= 22 || month == 1 && day <= 19)
            {
                img.Source = "kozerog.jpg";
                sign.Text = "Козерог";
                lbl.Text = "Дата: 22 декабря – 19 января\nСтихия - земля\nХарактеристика - дотошный, умный, деятельный\nЦвета - темно-зеленый, черный, пепельно-серый, синий, бледно-желтый, темно-коричневый и все темные тона";
            }
            else if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                img.Source = "vodolei.jpg";
                sign.Text = "Водолей";
                lbl.Text = "Дата: 20 января – 18 февраля\nСтихия - воздух\nХарактеристика - одаренный воображением, идеалистический, интуитивный\nЦвета - серый, лиловый, синезеленый, фиолетовый (черный цвет - неудачный)";
            }
            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {
                img.Source = "rybi.jpg";
                sign.Text = "Рыбы";
                lbl.Text = "Дата: 19 февраля – 20 марта\nСтихия - вода\nХарактеристика - творческий, чувствительный, артистичный\nЦвета - пурпурный, фиолетовый, морской зелени, синий, лиловый, морской волны, стальной";
            }
        }
    }
}
