using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogentAppAPI.Models
{
    class Student
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Education> PrefEducations { get; set; }
        public List<Campus> PrefCampuses { get; set; }
        public Adres Adres { get; set; }
    }
}
