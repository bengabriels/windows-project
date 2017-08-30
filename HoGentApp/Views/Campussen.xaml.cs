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

namespace HoGentApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Campussen : Page
    {

        private ObservableCollection<Campus> campus;
        public Campussen()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            campus = viewModel.Campussen;
            lv.ItemsSource = viewModel.Campussen;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Cast het aangeklikte item uit de lijst naar een Campus object
            var aangekliktItem = (Campus)e.ClickedItem;
            
            //Kijk of het item de naam Schoonmeersen heeft, zoja navigeer naar pagina Schoonmeersen
            if (aangekliktItem.Name == "Schoonmeersen") {
                this.Frame.Navigate(typeof(Views.CampusPaginas.Schoonmeersen));
            }
        }
    }
}
