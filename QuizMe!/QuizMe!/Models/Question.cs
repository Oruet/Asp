using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuizMe_.Models
{
    public class Question
    {
        [Key]
        public int ID_Question { get; set; }
        public string QuestionDescription { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string Answer { get; set; }
    }
}