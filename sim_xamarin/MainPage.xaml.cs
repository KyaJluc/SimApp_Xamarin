using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sim_xamarin
{
    public partial class MainPage : ContentPage
    {
        decimal balance = 0.0m;
        double minutes = 50;
        double sms = 175;
        double gigabytes = 7;
        double max_minutes = 200;
        double max_sms = 200;
        double max_gigabytes = 15;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout();

            StackLayout appBar = new StackLayout();
            
            Frame appBar_frame = new Frame()
            {
                Content = new Label()
                {
                    Text = "Баланс: " + balance.ToString(),
                    FontSize = 25.0,
                    TextColor = Color.White,
                    HorizontalOptions = LayoutOptions.Center
                }
            };
            appBar_frame.BackgroundColor = Color.FromHex("#ffbf00");

            appBar.Children.Add(appBar_frame);

            

            StackLayout minutesBar = new StackLayout();

            ProgressBar progressBar_minutes = new ProgressBar { Progress = minutes / max_minutes };
            progressBar_minutes.ProgressColor = Color.FromHex("#ffbf00");

            Label minutesBar_count = new Label()
            {
                Text = minutes.ToString(),
                FontSize = 40.0,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };
            Label minutesBar_label = new Label()
            {
                Text = "минут осталось",
                FontSize = 20.0,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            minutesBar.Children.Add(minutesBar_count);
            minutesBar.Children.Add(minutesBar_label);
            minutesBar.Children.Add(progressBar_minutes);

            StackLayout smsBar = new StackLayout();

            ProgressBar progressBar_sms = new ProgressBar { Progress = sms / max_sms };
            progressBar_sms.ProgressColor = Color.FromHex("#ffbf00");

            Label smsBar_count = new Label()
            {
                Text = sms.ToString(),
                FontSize = 40.0,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };
            Label smsBar_label = new Label()
            {
                Text = "смс осталось",
                FontSize = 20.0,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            smsBar.Children.Add(smsBar_count);
            smsBar.Children.Add(smsBar_label);
            smsBar.Children.Add(progressBar_sms);

            StackLayout gigabytesBar = new StackLayout();

            ProgressBar progressBar_gigabytes = new ProgressBar { Progress = gigabytes / max_gigabytes };
            progressBar_gigabytes.ProgressColor = Color.FromHex("#ffbf00");

            Label gigabytesBar_count = new Label()
            {
                Text = gigabytes.ToString(),
                FontSize = 40.0,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };
            Label gigabytesBar_label = new Label()
            {
                Text = "ГБ осталось",
                FontSize = 20.0,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            gigabytesBar.Children.Add(gigabytesBar_count);
            gigabytesBar.Children.Add(gigabytesBar_label);
            gigabytesBar.Children.Add(progressBar_gigabytes);

            Button fill_balance = new Button() {
                Text = "+ Пополнить баланс",
                TextColor = Color.White,
                FontSize = 20.0,
                BackgroundColor = Color.FromHex("#ffbf00"),
                Margin = new Thickness(40)
            };

            layout.Children.Add(appBar);
            layout.Children.Add(minutesBar);
            layout.Children.Add(smsBar);
            layout.Children.Add(gigabytesBar);
            layout.Children.Add(fill_balance);

            Content = layout;
        }
    }
}
