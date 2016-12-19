using HoGentApp.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HoGentApp.models
{
    /*
     * Deze klasse moet ook INotifyPropertyChanged implementeren omdat we in StudentViewModel de IsChecked property willen aanpassen na de submit.
     * Wanneer dit gebeurd moet er een notifypropertychanged event afgevuurd worden zodat de view updatet, maar ObservableCollection is hier niet toe in staat.7
     * ObservableCollection notifief enkel wijzigingen op de lijst zelf zoals toevoegen element, verwijderen element, maar niet het wijzigen van een property van een element.
    */
    public class Education : INotifyPropertyChanged, ArticleTarget
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string EducationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public bool IsChecked { get; set; }


        private bool isChecked;
        public bool IsChecked
        {
            get
            {
                return this.isChecked;
            }
            set
            {
                    this.isChecked = value;
                    NotifyPropertyChanged();
            }
        }
    }
}