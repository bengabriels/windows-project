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
    public sealed partial class CampusAdmin : Page
    {
        Campus c;
        private ObservableCollection<Campus> campus;
        public CampusAdmin()
        {
            this.InitializeComponent();
            campus = new ObservableCollection<Campus>();
            c = new Campus();
            c.Adres = new Adres();
            sp.DataContext = c;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync("http://localhost:1227/api/campus");
            campus = JsonConvert.DeserializeObject<ObservableCollection<Campus>>(jsonString);          //install newtonsoftJson
            lv.ItemsSource = campus;
        }

        private async void AddCampusClick(object sender, RoutedEventArgs e)
        {
            //api/Campus
            campus.Add(c);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(c);
            var result = await client.PostAsync("http://localhost:1227/api/campus", new StringContent(jsonString,
                            System.Text.Encoding.UTF8, "application/json"));
            var status = result.StatusCode;
        }
        private async void RemoveClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Campus rC = (Campus)b.DataContext;
            campus.Remove(rC);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(rC);
            int a;
            var result = await client.DeleteAsync("http://localhost:1227/api/campus/" + rC.CampusId);
            var status = result.StatusCode;
        }
    }
}
