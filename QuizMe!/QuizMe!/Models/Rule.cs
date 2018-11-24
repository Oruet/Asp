using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMe_.Models
{
    public class Rule
    {
        [Key]
        public int ID_Rule { get; set; }
        public int ID_Question { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
       
        [ForeignKey("Quiz")]
        public int ID_Quiz { get; set; }
        public Quiz Quiz { get; set; }
    }
}