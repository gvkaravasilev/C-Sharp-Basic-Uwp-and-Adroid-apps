using System;
using Xamarin.Forms;

namespace ClickerMania_3._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), TimerTick);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int counter = int.Parse(this.Clicks.Text);
            this.Clicks.Text = (++counter).ToString();
        }

        private bool TimerTick()
        {
            int c = int.Parse(this.Timer.Text);
            this.Timer.Text = (++c).ToString();


            this.CPM.Text = (float.Parse(this.Clicks.Text) /
            float.Parse(this.Timer.Text) * 60).ToString("N2");
            return true;
        }
    }
}
