﻿
namespace HogentAppAPI.Models
{
    public class Campus : ArticleTarget
    {
        public int CampusId { get; set; }
        public string name { get; set; }
        public Adres Adres { get; set; }
    }
}