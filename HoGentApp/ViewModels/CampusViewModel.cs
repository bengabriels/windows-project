﻿using HoGentApp.Data;
using HoGentApp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.ViewModels
{
    class CampusViewModel : NotificationBase<Education>
    {
        public CampusViewModel(Education campus = null) : base(campus) { }


        public ObservableCollection<Education> Campussen { get; set; }

        public CampusViewModel()
        {
            DataSource dataSource = new DataSource();
<<<<<<< HEAD
            Campussen = new ObservableCollection<Education>(dataSource.getCampus());
=======
            Campussen = new ObservableCollection<Campus>(dataSource.getCampus());
>>>>>>> c82911f8371fb3f31bc809cb675c6b7c69fa3de1
        }
    }
}
