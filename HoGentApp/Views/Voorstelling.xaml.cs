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
    public sealed partial class Voorstelling : Page
    {
        public Voorstelling()
        {
            this.InitializeComponent();
        }

        /*
        private void opleidingCheckbox_Click(object sender, RoutedEventArgs e)
        {
            string selectedOpleidingText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { bedrijfsmanagementCheckbox, retailManagementCheckbox, officemanagementCheckbox, toegepasteInformaticaCheckbox};
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedOpleidingText.Length > 1)
                    {
                        selectedOpleidingText += ", ";
                    }
                    selectedOpleidingText += c.Content;
                }
            }
            opleidingList.Text = selectedOpleidingText;
        }
        */
    }
}
