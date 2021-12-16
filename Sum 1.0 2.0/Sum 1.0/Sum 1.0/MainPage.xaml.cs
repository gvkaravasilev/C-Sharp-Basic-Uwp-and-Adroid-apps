using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Sum_1._0
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = float.Parse(A.Text);
            var b = float.Parse(B.Text);

            var c = a + b;

            C.Text = c.ToString();
        }
    }
}
