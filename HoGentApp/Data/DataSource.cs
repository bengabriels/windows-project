using HoGentApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoGentApp.Data
{
   public static class DataSource
    {
        //TODO: Alle dummy data vervangen door opgehaalde data uit backend.

           //StudentViewModel zal inhoud van deze lijst in ObservableCollection zetten
            public static List<Education> Opleidingen { get; set; } = new List<Education>()
        {
            new Education() {Name="Bedrijfsmanagement", Description="De omschrijving van bedrijfsmanagement"},
            new Education() {Name="Officesmanagement", Description="De omschrijving van Officesmanagement"},
            new Education() {Name="Retailmanagement", Description="De omschrijving van Retailmanagement"},
            new Education() {Name="Toegepaste Informatica", Description="De omschrijving van Toegepaste Informatica"}
        };

        //NIEUWS FEEDS
        public static List<Article> NieuwsFeeds { get; set; } = new List<Article>()
        {
           new Article() {Description=
               "Dit is de inhoud van dit artikel Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis."
               , Title="De Titel"},
           new Article() {Description="Dit is de inhoud van dit artikel 2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis.",
               Title ="De Titel 2"},
           new Article() {Description="Dit is de inhoud van dit artikel 3",
               Title ="De Titel 3"}

        };

        //TOEKOMSTIGE ACTIVITEITEN
        public static List<Gebeurtenis> ToekomstigeActiviteiten { get; set; } = new List<Gebeurtenis>()
        {
            new Gebeurtenis() {Title="Kerstmarkt",
                        Description ="De kerstmarkt van HoGent Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis.",
                        Campus = new Campus() { Name="Schoonmeersen", Adres = new Adres {City = "Gent", Street="Valentin Vaerewijckweg", streetNumber=1} },
                        Date = new DateTime(2016, 12, 25)
            },
             new Gebeurtenis() {Title="Kerstmarkt 2",
                        Description ="De kerstmarkt van HoGent Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec suscipit finibus felis sed ultricies. Vestibulum aliquet vestibulum magna, dignissim finibus erat commodo vitae. Nunc accumsan neque eu nunc lacinia eleifend. Cras a urna arcu. Sed vitae odio sit amet urna dictum pretium. Fusce vestibulum ante in lacus finibus, sit amet volutpat leo porttitor. Donec sed facilisis tellus. Suspendisse velit risus, vulputate eu aliquet eu, accumsan at eros. Nulla sit amet commodo risus. Morbi mollis nisl et sapien pellentesque sollicitudin. In venenatis nisl quis urna euismod porta. Aenean vel ex arcu. Proin rutrum et nulla nec aliquam. Cras elementum sapien quis.",
                        Campus = new Campus() { Name="Schoonmeersen", Adres = new Adres {City = "Gent", Street="Valentin Vaerewijckweg", streetNumber=1} },
                        Date = new DateTime(2016, 12, 25)
            },
              new Gebeurtenis() {Title="Kerstmarkt 3",
                        Description ="De kerstmarkt van HoGent",
                        Campus = new Campus() { Name="Schoonmeersen", Adres = new Adres {City = "Gent", Street="Valentin Vaerewijckweg", streetNumber=1} },
                        Date = new DateTime(2016, 12, 25)
            }

        };



    }
}
