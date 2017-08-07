using HoGentApp.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HoGentApp.Views.Admin.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ArticleAdmin : Page
    {
        Article a;
        private ObservableCollection<Article> artikels;
        public ArticleAdmin()
        {
            artikels = new ObservableCollection<Article>();
            a = new Article();
            this.InitializeComponent();
            sp.DataContext = a;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync("http://localhost:1227/api/article");
            artikels = JsonConvert.DeserializeObject<ObservableCollection<Article>>(jsonString);          //install newtonsoftJson
            lv.ItemsSource = artikels;
        }

        private async void AddCampusClick(object sender, RoutedEventArgs e)
        {
            //api/Campus
            artikels.Add(a);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(a);
            var result = await client.PostAsync("http://localhost:1227/api/article", new StringContent(jsonString,
                            System.Text.Encoding.UTF8, "application/json"));
            var status = result.StatusCode;
        }
        private async void RemoveClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Article rA = (Article)b.DataContext;
            artikels.Remove(rA);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(rA);
            var result = await client.DeleteAsync("http://localhost:1227/api/article/" + rA.ArticleId);
            var status = result.StatusCode;
        }
    }
}
