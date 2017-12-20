using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScoreboardVB15.Models
{
    public class FeedbackModels
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Required]
        public string Feedback { get; set; }
        public DateTime? FeedbackCreated { get; set; }

        public FeedbackModels()
        {
            FeedbackCreated = DateTime.Now;
        }

    }
}