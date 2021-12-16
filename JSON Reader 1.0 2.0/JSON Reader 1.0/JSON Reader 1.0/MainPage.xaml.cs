using AngleSharp.Html.Parser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace JSON_Reader_1._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Tell_Click(object sender, RoutedEventArgs e)
        {
            if (Joke.Text != "")
            {
                // The media object for controlling and playing audio.
                var mediaElement = new MediaElement();
                // The object for controlling the speech synthesis engine (voice).
                var synth = new SpeechSynthesizer();
                // Generate the audio stream from plain text.
                var stream = await synth.SynthesizeTextToStreamAsync(Joke.Text);
                // Send the stream to the media object.
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }

        private async void Button_Get_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(new Uri("https://api.chucknorris.io/jokes/random"));
            // Deserialize the JSON
            var joke = JsonConvert.DeserializeObject<Root>(json);
            // Parse the HTML
            var html = new HtmlParser().ParseDocument(joke.value);
            var text = html.Body.TextContent;
            // Tell the Joke
            Joke.Text = text;
        }
    }
}
