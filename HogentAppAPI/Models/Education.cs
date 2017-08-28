
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HogentAppAPI.Models
{
    public class Education : ArticleTarget
    {
        [Key]
        public int? EducationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }
        [NotMapped]
        public bool IsChecked { get; set; }
    }
}