using HoGentApp.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.Data
{
    public class DataSource
    {
        public List<Education> getEducations()
        {
           try
            {
                Debug.WriteLine("http werkt");
                HttpClient client = new HttpClient();
                var jsonString = client.GetStringAsync("http://localhost:1227/api/education").Result;
                var educations = JsonConvert.DeserializeObject<ObservableCollection<Education>>(jsonString);
                Debug.WriteLine("opleidingen opslaan");
                return educations.ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine("error");
                Debug.WriteLine(e.Message);
                throw;
            }
            
        }
            //await new HttpClient().GetAsync("");
            /*
            return new List<Education>()
        {
            //DummyData, moet uit backend komen en in de lijst gestopt worden, StudentViewModel zal dit in ObservableCollection steken.
            new Education() {Name="Bedrijfsmanagement", Description="De omschrijving van bedrijfsmanagement"},
            new Education() {Name="Officesmanagement", Description="De omschrijving van Officesmanagement"},
            new Education() {Name="Retailmanagement", Description="De omschrijving van Retailmanagement"},
            new Education() {Name="Toegepaste Informatica", Description="De omschrijving van Toegepaste Informatica"}
        };
        */
        //NIEUWS FEEDS
        public List<Article> getNieuwsFeeds()
        {
             try
            {
                HttpClient client = new HttpClient();
                var jsonString = client.GetStringAsync("http://localhost:1227/api/article").Result;
                var newsFeed = JsonConvert.DeserializeObject<ObservableCollection<Article>>(jsonString);
                return newsFeed.ToList();
            }
            catch (Exception e)
            {
                Debug.WriteLine("error");
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        /*
       new Article() {Description=
           "Dit is de inhoud van dit artikel Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis."
           , Title="De Titel"},
       new Article() {Description="Dit is de inhoud van dit artikel 2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis.",
           Title ="De Titel 2"},
       new Article() {Description="Dit is de inhoud van dit artikel 3",
           Title ="De Titel 3"}
           */


        public async void saveStudent(Student s)
        {
            try
            {
                HttpClient client = new HttpClient();
                var jsonString = JsonConvert.SerializeObject(s);
                var result = await client.PostAsync("http://localhost:1227/api/students", new StringContent(jsonString,
                                System.Text.Encoding.UTF8, "application/json"));
                var status = result.StatusCode;
            }
            catch (Exception e)
            {
                Debug.WriteLine("error");
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        //TOEKOMSTIGE ACTIVITEITEN
        public static List<Gebeurtenis> ToekomstigeActiviteiten { get; set; } = new List<Gebeurtenis>()
        {
            
                       new Gebeurtenis() {Title="Kerstmarkt",
                        Description ="De kerstmarkt van HoGent Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis.",
                        Campus = new Campus() { Name="Schoonmeersen", Adres = new Adres {City = "Gent", Street="Valentin Vaerewijckweg", StreetNumber=1} },
                        Date = new DateTime(2016, 12, 25)
            },
             new Gebeurtenis() {Title="Kerstmarkt 2",
                        Description ="De kerstmarkt van HoGent Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis.",
                        Campus = new Campus() { Name="Schoonmeersen", Adres = new Adres {City = "Gent", Street="Valentin Vaerewijckweg", StreetNumber=1} },
                        Date = new DateTime(2016, 12, 25)
            },
              new Gebeurtenis() {Title="Kerstmarkt 3",
                        Description ="De kerstmarkt van HoGent",
                        Campus = new Campus() { Name="Schoonmeersen", Adres = new Adres {City = "Gent", Street="Valentin Vaerewijckweg", StreetNumber=1} },
                        Date = new DateTime(2016, 12, 25)
            }
      
        };


        public List<Campus> getCampus()
        {
            HttpClient client = new HttpClient();
            var jsonString = client.GetStringAsync("http://localhost:1227/api/campus").Result;
            var campus = JsonConvert.DeserializeObject<ObservableCollection<Campus>>(jsonString);          //install newtonsoftJson
            return campus.ToList();
        }
/*
        public List<Education> Opleidingen { get; set; }
        public  List<Campus> Campussen { get; set; } 
        */
    }
}
