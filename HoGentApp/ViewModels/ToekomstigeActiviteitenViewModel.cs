using HoGentApp.Data;
using HoGentApp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.ViewModels
{
    public class ToekomstigeActiviteitenViewModel : NotificationBase<Gebeurtenis>
    {
        public ToekomstigeActiviteitenViewModel(Gebeurtenis gebeurtenis=null) : base(gebeurtenis) {}

        //De lijst met activiteiten
        public ObservableCollection<Gebeurtenis> ToekomstigeActiviteiten { get; set; }

        public ToekomstigeActiviteitenViewModel() {
            //Lijst opvullen met data uit backend
            ToekomstigeActiviteiten = new ObservableCollection<Gebeurtenis>(DataSource.ToekomstigeActiviteiten);
        }
    }
}
