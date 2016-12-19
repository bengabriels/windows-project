using HoGentApp.Data;
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

        ///////////// PROPERTIES UIT MODEL WRAPPEN EN BINDEN MET VIEW (enkel die waar we een binding voor nodig hebben in de view) /////////////
        public String FirstName { get { return This.FirstName; } set { SetProperty(This.FirstName, value, () => This.FirstName = value); } }
        public String LastName { get { return This.LastName; } set { SetProperty(This.LastName, value, () => This.LastName = value); } }
        public String Email { get { return This.Email; } set { SetProperty(This.Email, value, () => This.Email = value); } }
        public String PhoneNumber { get { return This.PhoneNumber; } set { SetProperty(This.PhoneNumber, value, () => This.PhoneNumber = value); } }
        public List<Education> VoorkeursOpleidingen { get { return This.VoorkeursOpleidingen; } set { SetProperty(This.VoorkeursOpleidingen, value, () => This.VoorkeursOpleidingen = value); } }

        //Observable List om opgehaalde data weer te geven in view (om te testen of command werkt)...
        public ObservableCollection<Student> Students { get; set; }

        //Lijst bevat opleidingen
        public ObservableCollection<Education> Opleidingen { get; set; }
        private List<Education> GekozenOpleidingen;


        ///////////// COMMANDS /////////////
        public RelayCommand SaveStudentCommand { get; set; }


        public StudentViewModel()
        {
            DataSource dataSource = new DataSource();
            //Bij aanroepSaveStudentCommand SaveStudent method uitvoeren
            //Een command kan slechts 1 parameter hebben
            SaveStudentCommand = new RelayCommand((param) => SaveStudent(param));

            //Enkel om te testen
            Students = new ObservableCollection<Student>();

            //De opleidingen waaruit de student kan kiezen
            Opleidingen = new ObservableCollection<Education>(dataSource.getEducations().Result);

            //De gekozen voorkeursopleidingen van de student
            VoorkeursOpleidingen = new List<Education>();

        }

        ///////////// METHODS /////////////
        private void SaveStudent(object param)
        {   
            //We overlopen de opleidingen en kijken welke er aangeduid zijn, de aangeduide voegen we toe aan de lijst VoorkeursOpleidingen.
               foreach (Education e in Opleidingen) {
                if (e.IsChecked == true) {
                    VoorkeursOpleidingen.Add(e);
                }
            }

            //Alle ingevulde velden doorgeven aan het model en een nieuw Student object maken
            Student s = new Student() { FirstName = FirstName, LastName = LastName, PhoneNumber = PhoneNumber, Email = Email, VoorkeursOpleidingen=VoorkeursOpleidingen };

            //TEST
            this.Students.Add(s);

            //TODO: BACKEND CALLEN EN STUDENT OBJECT MEEGEVEN



            Debug.WriteLine("Student toegevoegd met command");
        }
      }
}
