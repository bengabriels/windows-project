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

namespace HoGentApp.Views.Admin.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Admin : Page
    {
        public Admin()
        {
            this.InitializeComponent();
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            Object loggedIn = localSettings.Values["loggedIn"];

            if (loggedIn != null && (bool)loggedIn == true)
            {
                showAdminPanel();
            }
            else {
                hideAdminPanel();
            }
        }

        private void Student_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StudentAdmin));
        }

        private void Education_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EducationAdmin));
        }

        private void Campus_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CampusAdmin));
        }

        private void Gebeurtenis_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GebeurtenisAdmin));
        }

        private void Article_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ArticleAdmin));
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(Admintb.Text =="admin" && Wachtwoordtb.Password == "ww")
            {
                LoggedInState(true);
                showAdminPanel();
            }
        }

        private void LoggedInState(bool loggedIn) {
            Windows.Storage.ApplicationDataContainer localSettings =
             Windows.Storage.ApplicationData.Current.LocalSettings;
            if (loggedIn)
                localSettings.Values["loggedIn"] = true;
            if(loggedIn == false)
                localSettings.Values["loggedIn"] = false;
        }

        private void showAdminPanel() {
            AdminList.Visibility = Visibility.Visible;
            LoginForm.Visibility = Visibility.Collapsed;
            logoutBtn.Visibility = Visibility.Visible;
        }
        private void hideAdminPanel() {
            AdminList.Visibility = Visibility.Collapsed;
            LoginForm.Visibility = Visibility.Visible;
            logoutBtn.Visibility = Visibility.Collapsed;
            LoggedInState(false);
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            hideAdminPanel();
        }
    }
}
