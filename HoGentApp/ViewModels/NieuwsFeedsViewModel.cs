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
    class NieuwsFeedsViewModel : NotificationBase<Article>
    {
        public NieuwsFeedsViewModel(Article article = null) : base(article) { }


        public ObservableCollection<Article> NieuwsFeeds { get; set; }

        public NieuwsFeedsViewModel()
        {
            NieuwsFeeds = new ObservableCollection<Article>(new DataSource().getNieuwsFeeds());
        }

    }
}
