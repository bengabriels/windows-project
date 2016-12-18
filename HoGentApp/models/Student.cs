using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;

namespace HoGentApp.models
{

        public class Student
        {
            private string firstName;
            private string lastName;
            private string email;
            private string phoneNumber;
            //private Adres adres;


        public Student() {}
             
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            //public string Adres {get; set; }

    }
}
