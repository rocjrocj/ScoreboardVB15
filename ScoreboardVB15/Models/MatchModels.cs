using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScoreboardVB15.Models
{
    public class MatchModels
    {
        public int Id { get; set; }
        [Required]
        public string MatchName { get; set; }
        public int? HomeTeamId { get; set; }
        public string HomeTeamName { get; set; }
        public int? GuestTeamId { get; set; }
        public string GuestTeamName { get; set; }
        public DateTime? MatchCreated { get; set; }
        public DateTime? MatchUpdated { get; set; }
        public DateTime? MatchEnded { get; set; }
    }
}