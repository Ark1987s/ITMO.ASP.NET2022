using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControlWork.Models
{
    public class ProgressContext: DbContext
    {
        public DbSet<Progress> Progresss { get; set; }
    }
}