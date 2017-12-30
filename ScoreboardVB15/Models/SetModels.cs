using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScoreboardVB15.Models
{
    public class SetModels
    {
        public int Id { get; set; }
        [Required]
        public int MatchId { get; set; }
        [DefaultValue(1)]
        public int SetNumber { get; set; }
        [DefaultValue(0)]
        public int HomeScore { get; set; }
        [DefaultValue(0)]
        public int GuestScore { get; set; }
        public DateTime? SetCreated { get; set; }
        public DateTime? SetUpdated { get; set; }
        public DateTime? SetEnded { get; set; }
    }
}