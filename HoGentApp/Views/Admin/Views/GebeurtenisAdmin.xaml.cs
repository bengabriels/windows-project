using HoGentApp.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    public sealed partial class GebeurtenisAdmin : Page
    {
        Gebeurtenis g;
        private ObservableCollection<Education> campussen;
        private ObservableCollection<Gebeurtenis> gebeurtenissen;
        public GebeurtenisAdmin()
        {
            g = new Gebeurtenis();
            
            g.Campus = new Campus { Name = "SChoonmeersen", Adres= new Adres { City = "Gent", Street = "Voskeslaan", StreetNumber = 12 } };
            this.InitializeComponent();
            sp.DataContext = g;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync("http://localhost:1227/api/gebeurtenis");
            gebeurtenissen = JsonConvert.DeserializeObject<ObservableCollection<Gebeurtenis>>(jsonString);          //install newtonsoftJson
            lv.ItemsSource = gebeurtenissen;

            jsonString = await client.GetStringAsync("http://localhost:1227/api/campus");
            campusList.ItemsSource = JsonConvert.DeserializeObject<ObservableCollection<Education>>(jsonString);          //install newtonsoftJson
        }

        private async void AddCampusClick(object sender, RoutedEventArgs e)
        {
            //api/Campus

            ObservableCollection<Campus> campussen =(ObservableCollection <Campus>) campusList.ItemsSource;
            g.Campus= campussen.Where(c => c.IsChecked).First();
            if(g.Campus==null)
                g.Campus = new Campus { Name = "SChoonmeersen", Adres = new Adres { City = "Gent", Street = "Voskeslaan", StreetNumber = 12 } };
            gebeurtenissen.Add(g);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(g);
            var result = await client.PostAsync("http://localhost:1227/api/gebeurtenis", new StringContent(jsonString,
                            System.Text.Encoding.UTF8, "application/json"));
            var status = result.StatusCode;
            Debug.WriteLine(result.Content);
        }
        private async void RemoveClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Gebeurtenis rG = (Gebeurtenis)b.DataContext;
            gebeurtenissen.Remove(rG);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(rG);
            int a;
            var result = await client.DeleteAsync("http://localhost:1227/api/campus/" + rG.GebeurtenisId);
            var status = result.StatusCode;
        }
    }
}
