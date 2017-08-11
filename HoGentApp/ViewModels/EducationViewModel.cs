using HoGentApp.Data;
using HoGentApp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace HoGentApp.ViewModels
{
    class EducationViewModel : NotificationBase<Education>
    {
        public EducationViewModel(Education education = null) : base(education) { }


        public ObservableCollection<Education> Educations { get; set; }

        public EducationViewModel()
        {
            DataSource dataSource = new DataSource();
            Educations = new ObservableCollection<Education>(dataSource.getEducations());
        }
    }
}
