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
        public async Task<List<Education>>  getEducations()
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
            //await new HttpClient().GetAsync("");
            /*
            return new List<Education>()
        {
            //DummyData, moet uit backend komen en in de lijst gestopt worden, StudentViewModel zal dit in ObservableCollection steken.
            new Education() {Name="Bedrijfsmanagement", Description="De omschrijving van bedrijfsmanagement"},
            new Education() {Name="Officesmanagement", Description="De omschrijving van Officesmanagement"},
            new Education() {Name="Retailmanagement", Description="De omschrijving van Retailmanagement"},
            new Education() {Name="Toegepaste Informatica", Description="De omschrijving van Toegepaste Informatica"}
        };*/
        }



        public async Task<List<Campus>> getCampus()
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
