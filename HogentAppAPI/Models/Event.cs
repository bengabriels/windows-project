using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogentAppAPI.Models
{
    class Event
    {
        public string Title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public Campus campus { get; set; }
    }
}
