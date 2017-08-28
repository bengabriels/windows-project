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
    class CampusViewModel : NotificationBase<Campus>
    {
        public CampusViewModel(Campus campus = null) : base(campus) { }
        private ObservableCollection<Campus> campus;

        public ObservableCollection<Campus> Campussen { get; set; }

        public CampusViewModel()
        {
            DataSource dataSource = new DataSource();
            Campussen = new ObservableCollection<Campus>(dataSource.getCampus());
        }
    }
}
