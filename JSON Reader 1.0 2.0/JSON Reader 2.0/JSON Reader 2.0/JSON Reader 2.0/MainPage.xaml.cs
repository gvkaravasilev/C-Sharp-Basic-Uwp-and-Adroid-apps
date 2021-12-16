using AngleSharp.Html.Parser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;

namespace JSON_Reader_2._0
{

    public class Root
    {
        public List<object> categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(new Uri("https://api.chucknorris.io/jokes/random"));
            // Deserialize the JSON
            var joke = JsonConvert.DeserializeObject<Root>(json);
            // Parse the HTML
            var html = new HtmlParser().ParseDocument(joke.value);
            var text = html.Body.TextContent;
            // Tell the Joke
            this.Joke.Text = text;
        }
    }
}
