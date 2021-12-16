using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Primes_1._0
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int limit = int.Parse(limitInputField.Text);

            for(int i = 2; i < limit; i++)
            {
                if(isPrime(i))
                {
                    PrimesList.Items.Add(i);
                }
            }
        }

        public bool isPrime(int n)
        {
            if(n <= 1)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }


            return true;
        }
    }
}
