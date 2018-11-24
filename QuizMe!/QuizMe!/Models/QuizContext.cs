using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace QuizMe_.Models
{
    public class QuizContext :DbContext
    {

        public QuizContext() : base("QuizContext")
        {
        }
        public virtual System.Data.Entity.DbSet<Account> Accounts { get; set; }
        public virtual System.Data.Entity.DbSet<Quiz> Quizes { get; set; }
        public virtual System.Data.Entity.DbSet<Event> Events { get; set; }
        public virtual System.Data.Entity.DbSet<Rule> Rules { get; set; }
        public virtual System.Data.Entity.DbSet<Question> Questions { get; set; }

    }
}