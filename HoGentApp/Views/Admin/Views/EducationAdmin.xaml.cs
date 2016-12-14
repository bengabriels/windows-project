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
    public sealed partial class EducationAdmin : Page
    {
        Education ed;
        private ObservableCollection<Education> educations;
        public EducationAdmin()
        {
            this.InitializeComponent();
            ed = new Education();
            sp.DataContext = ed;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync("http://localhost:1227/api/education");
            educations = JsonConvert.DeserializeObject<ObservableCollection<Education>>(jsonString);          //install newtonsoftJson
            lv.ItemsSource = educations;
        }

        private async void AddCampusClick(object sender, RoutedEventArgs e)
        {
            //api/Campus
            educations.Add(ed);
            HttpClient client = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(ed);
            var result = await client.PostAsync("http://localhost:1227/api/education", new StringContent(jsonString,
                            System.Text.Encoding.UTF8, "application/json"));
            var status = result.StatusCode;
        }
    }
}
