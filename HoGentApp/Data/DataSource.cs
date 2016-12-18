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
       
            public static List<Education> Opleidingen { get; set; } = new List<Education>()
        {
            //DummyData, moet uit backend komen en in de lijst gestopt worden, StudentViewModel zal dit in ObservableCollection steken.
            new Education() {Name="Bedrijfsmanagement", Description="De omschrijving van bedrijfsmanagement"},
            new Education() {Name="Officesmanagement", Description="De omschrijving van Officesmanagement"},
            new Education() {Name="Retailmanagement", Description="De omschrijving van Retailmanagement"},
            new Education() {Name="Toegepaste Informatica", Description="De omschrijving van Toegepaste Informatica"}
        };
        

    }
}
