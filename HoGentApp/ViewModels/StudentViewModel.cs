using HoGentApp.models;
using HoGentApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.ViewModels
{
    //Opgeven welk model dit ViewModel representeert
    class StudentViewModel : NotificationBase<Student>
    {
        public StudentViewModel(Student student = null) : base(student) { }

        ///////////// PROPERTIES UIT MODEL WRAPPEN EN BINDEN MET VIEW /////////////
        public String FirstName { get { return This.FirstName; } set { SetProperty(This.FirstName, value, () => This.FirstName = value); } }
        public String LastName { get { return This.LastName; } set { SetProperty(This.LastName, value, () => This.LastName = value); } }
        public String Email { get { return This.Email; } set { SetProperty(This.Email, value, () => This.Email = value); } }
        public String PhoneNumber { get { return This.PhoneNumber; } set { SetProperty(This.PhoneNumber, value, () => This.PhoneNumber = value); } }


        //Observable List om opgehaalde data weer te geven in view (om te testen of command werkt)...
        public ObservableCollection<Student> Students { get; set; }


        ///////////// COMMANDS /////////////
        public RelayCommand SaveStudentCommand { get; set; }


        public StudentViewModel()
        {
            //Bij aanroepSaveStudentCommand SaveStudent method uitvoeren
            //Een command kan slechts 1 parameter hebben
            SaveStudentCommand = new RelayCommand((param) => SaveStudent(param));

            Students = new ObservableCollection<Student>();
        }

        ///////////// METHODS /////////////
        private void SaveStudent(object param)
        {
            //Alle ingevulde velden doorgeven aan het model en een nieuw Student object maken
            Student s = new Student() { FirstName = FirstName, LastName=LastName, PhoneNumber = PhoneNumber, Email=Email };
            this.Students.Add(s);//TEST

            //BACKEND CALLEN EN STUDENT OBJECT MEEGEVEN

            Debug.WriteLine("Student toegevoegd met command");
        }
    }
}
