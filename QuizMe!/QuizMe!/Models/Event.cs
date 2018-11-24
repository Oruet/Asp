using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuizMe_.Models
{
    public class Event
    {
        [Key]
        public int ID_Event { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }


       

        public virtual ICollection<Quiz> Quizes { get; set; }
    }
}