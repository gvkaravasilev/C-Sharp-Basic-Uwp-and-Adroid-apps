using System;
using Xamarin.Forms;

namespace Sum_2._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var a = float.Parse(inputA.Text);
            var b = float.Parse(inputB.Text);

            var c = a + b;

            Sum.Text = c.ToString();
        }
    }
}
