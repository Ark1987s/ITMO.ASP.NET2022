using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControlWork.Models
{
    public class Progress
    {
        public int id { get; set; }
        public string Student { get; set; }
        public int Maths { get; set; }
        public int Physics { get; set; }
        public int History { get; set; }
    }
    public class ProgressContext : DbContext
    {
        public DbSet<Progress> Progresses { get; set; }
    }
}