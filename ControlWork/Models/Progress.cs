using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlWork.Models
{
    public class Progress
    {
        public virtual int id { get; set; }
        public virtual string Student { get; set; }
        public virtual int Math { get; set; }
        public virtual int Physics { get; set; }
        public virtual int History { get; set; }
    }
}