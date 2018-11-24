using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizMe_.Models
{
    public class Account
    {
        [Key]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string OnlinePassword { get; set; }
        protected string Type { get; set; }

        public int ID_Quiz { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
    //public class HtmlHelper { }
}