using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Fibonacci_1._0
{
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<int> fibList = new ObservableCollection<int>();
        public MainPage()
        {
            this.InitializeComponent();
            FibSeriesList.ItemsSource = fibList;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int limit = int.Parse(inputLimitField.Text);

            this.fibList.Add(1);
            this.fibList.Add(1);

            int a = 1;
            int b = 1;
            int c = a + b; 

            while(c < limit)
            {
                this.fibList.Add(c);

                a = b;
                b = c;
                c = a + b;
            }
            
        }
    }
}
