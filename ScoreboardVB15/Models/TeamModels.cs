using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScoreboardVB15.Models
{
    public class TeamModels
    {
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        public DateTime? TeamCreated { get; set; }
        public DateTime? TeamModified { get; set; }
    }
}