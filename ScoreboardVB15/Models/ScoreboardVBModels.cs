using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoreboardVB15.Models
{
    public class ScoreboardVBModels
    {
        public int Id { get; set; }
        [Required]
        public string MatchName { get; set; }
        [DefaultValue("Home")]
        public string HomeTeam { get; set; }
        [DefaultValue(0)]
        public int? HomeScore { get; set; }
        [DefaultValue("Guest")]
        public string GuestTeam { get; set; }
        [DefaultValue(0)]
        public int? GuestScore { get; set; }
        [DefaultValue(1)]
        public int? SetNumber { get; set; }
        public string Set1Winner { get; set; }
        public string Set2Winner { get; set; }
        public string Set3Winner { get; set; }
        public DateTime? MatchCreated { get; set; }
        public DateTime? MatchUpdated { get; set; }
        public DateTime? MatchEnded { get; set; }


        public ScoreboardVBModels()
        {
            HomeTeam = "Home";
            HomeScore = 0;
            GuestTeam = "Guest";
            GuestScore = 0;
            SetNumber = 1;
            MatchCreated = DateTime.Now;
            MatchUpdated = DateTime.Now;
        }
    }
}