﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace HogentAppAPI.Models
{
    public class Campus : ArticleTarget
    {
        public int CampusId { get; set; }
        public string Name { get; set; }
        public Adres Adres { get; set; }
        [NotMapped]
        public bool IsChecked { get; set; }
    }
}