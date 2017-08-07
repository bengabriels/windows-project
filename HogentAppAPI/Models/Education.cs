
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HogentAppAPI.Models
{
    public class Education : ArticleTarget
    {
        public int EducationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public bool IsChecked { get; set; }
    }
}