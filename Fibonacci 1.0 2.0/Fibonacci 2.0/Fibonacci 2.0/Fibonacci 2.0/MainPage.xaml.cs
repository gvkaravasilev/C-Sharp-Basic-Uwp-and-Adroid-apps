using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Fibonacci_2._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<int> fibList = new List<int>();
            fibList.Add(1);
            fibList.Add(1);

            int limit = int.Parse(this.LimitField.Text);
            int a = 1;
            int b = 1;
            int c = a + b;

            while(c < limit)
            {
                a = b;
                b = c;
                c = a + b;
            }
            this.FibList.ItemsSource = fibList;
        }
    }
}
