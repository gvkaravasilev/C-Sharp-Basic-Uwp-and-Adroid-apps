using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ClickeMania_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public MainPage()
        {
            this.InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int counter = int.Parse(Timer.Text);
            Clicks.Text = (++counter).ToString();
        }

        private void Timer_Tick(object sender, object e)
        {
            int n = int.Parse(Timer.Text);
            Timer.Text = (++n).ToString();

            CPM.Text = (float.Parse(Clicks.Text) / float.Parse(Timer.Text) * 60).ToString("N2");
        
    }
    }
}
