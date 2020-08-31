using DemoHerokuApp.Models;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static DemoHerokuApp.Models.ContentNetwork;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoHerokuApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void Click(object sender, RoutedEventArgs e)
        {
            
        }
        private async void AllPage(object sender, RoutedEventArgs e)
        {
            Root myContentNetwork = await ContentNetwork.GetContentNetwork();
            string image = String.Format(myContentNetwork.image);
            Image.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
            TemplateTextBlock.Text = myContentNetwork.title;
            ContentDescriptionTextBlock.Text = Convert.ToString(myContentNetwork.content.description);
            LocationTextBlock.Text = myContentNetwork.date;
        }
    }
}
