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
using HoGentApp.Views;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HoGentApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {
        public Shell()
        {
            this.InitializeComponent();
        }

        private void BackRadioButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            if (frame?.CanGoBack == true)
            {
                frame.GoBack();
            }
        }

       

        private void HomeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(MainPage))
            {
                frame.Navigate(typeof(MainPage));
            }
        }


        private void CampussenRadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(Campussen))
            {
                frame.Navigate(typeof(Campussen));
            }
        }

        private void VoorstellingRadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(Voorstelling))
            {
                frame.Navigate(typeof(Voorstelling));
            }
        }

        private void ToekomstigeActiviteitenRadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(ToekomstigeActiviteiten))
            {
                frame.Navigate(typeof(ToekomstigeActiviteiten));
            }
        }

        private void NieuwsFeedsRadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(NieuwsFeeds))
            {
                frame.Navigate(typeof(NieuwsFeeds));
            }
        }

        private void ToggleMenuRadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen;
        }

        private void OpleidingenRadioButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(Opleidingen))
            {
                frame.Navigate(typeof(Opleidingen));
            }
        }
    }
}