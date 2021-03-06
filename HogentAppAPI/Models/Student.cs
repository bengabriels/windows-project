﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogentAppAPI.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Adres Adres { get; set; }

        public virtual ICollection<Education> VoorkeursOpleidingen { get; set; }

        public IEnumerable<int?> EducationIds
        {
            get { return VoorkeursOpleidingen?.Select(a => a.EducationId); }
        }
    }
}