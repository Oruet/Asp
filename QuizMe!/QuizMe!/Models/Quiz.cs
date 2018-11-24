using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMe_.Models
{
    public class Quiz
    {
        [Key]
        public int ID_Quiz { get; set; }
        public int ID_Question { get; set; }
        
        public int ID_Event { get; set; }
        public string Email { get; set; }
        public int TotalQuestions { get; set; }
        
        public TimeSpan MaxTime { get; set; }
        public int Score { get; set; }
        public virtual ICollection<Rule> Rules { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Question> Questions { get; set; }


        public virtual Event Event { get; set; }
        public virtual Rule Rule { get; set; }
        public virtual Question Question { get; set; }
    }
}