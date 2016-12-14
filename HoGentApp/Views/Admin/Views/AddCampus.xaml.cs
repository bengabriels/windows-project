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
    public sealed partial class AddCampus : Page
    {
        Campus c;
        private ObservableCollection<Campus> campus;
        public AddCampus()
        {
            this.InitializeComponent();
            c = new Campus();
            c.Adres = new Adres();
            this.DataContext = c;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync("http://localhost:1227/api/Campus");
            campus = JsonConvert.DeserializeObject<ObservableCollection<Campus>>(jsonString);          //install newtonsoftJson
            lv.ItemsSource = campus;
        }

        private async void AddCampusClick(object sender, RoutedEventArgs e)
        {
            //api/Campus
            //campuses.Add(c);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(c);
            var result = await client.PostAsync("http://localhost:1227/api/campus", new StringContent(jsonString,
                            System.Text.Encoding.UTF8, "application/json"));
            var status = result.StatusCode;
        }
    }
}
