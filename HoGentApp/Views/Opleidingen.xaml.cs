﻿
using HoGentApp.models;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HoGentApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Opleidingen : Page
    {
        public Opleidingen()
        {
            this.InitializeComponent();
        }

        private void ImageToegepasteInformatica_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.OpleidingPaginas.ToegepasteInformatica));
        }
        private void ImageOfficeManagement_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.OpleidingPaginas.Officemanagement));
        }
        private void ImageRetailManagement_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.OpleidingPaginas.Retailmanagement));
        }
        private void ImageBedrijfsManagement_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.OpleidingPaginas.Bedrijfsmanagement));
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Education item = (Education)e.ClickedItem;
            //TODO:
            this.Frame.Navigate(typeof(Views.OpleidingPaginas.EducationDetail), item);
        }

    }
}
