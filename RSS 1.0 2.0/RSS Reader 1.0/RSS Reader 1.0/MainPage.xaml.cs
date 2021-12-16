using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Web.Syndication;
namespace RSS_Reader_1._0
{
    /// <summary>
    /// Business Logic(BL): RSS Reader 1.0
    /// </summary>
    /// 
    public class Item
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string PublishedDate { get; set; }
    }
    public sealed partial class MainPage : Page
    {
        // View Model
        private ObservableCollection<Item> Items = new ObservableCollection<Item>();
        // Constructor
        public MainPage()
        {
            this.InitializeComponent();
            RSS.ItemsSource = Items;
        }
        // Button Click Event Handler
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Download();
        }
        // Download Handler
        private async void Download()
        {
            var uri = new Uri(URI.Text);
            var client = new SyndicationClient();
            var feed = await client.RetrieveFeedAsync(uri);
            if (feed != null)
            {
                foreach (var node in feed.Items)
                {
                    Items.Add(new Item
                    {
                        Title = node.Title.Text,
                        Link = node.Id,
                        PublishedDate = node.PublishedDate.ToString()
                    });
                }
            }
        }
    }
}
