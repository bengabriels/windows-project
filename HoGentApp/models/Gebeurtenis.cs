using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.models
{
    public class Gebeurtenis
    {
        public int GebeurtenisId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Campus Campus { get; set; }
    }
}
