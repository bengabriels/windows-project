using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogentAppAPI.Models
{
    public class Gebeurtenis
    {
        [Key]
        public int GebeurtenisId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int? CampusId { get; set; }

        [ForeignKey("CampusId")]
        public virtual Campus Campus { get; set; }
    }
}
