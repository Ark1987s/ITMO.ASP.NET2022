using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ControlWork.Models
{
    public class Progress
    {
        public int id { get; set; }

        [Display(Name = "First name, Last name")]
        [Required]
        [RegularExpression("[a-zA-Z,' ']*"), MaxLength(50)]
        public string Student { get; set; }

        [Display(Name = "grade")]
        [Required]
        [Range(1, 10)]
        public int Maths { get; set; }

        [Display(Name = "grade")]
        [Required]
        [Range(1, 10)]
        public int Physics { get; set; }

        [Display(Name = "grade")]
        [Required]
        [Range(1, 10)]
        public int History { get; set; }       
        
        public virtual int Score
        {
            get
            {
                int score = Maths + Physics + History;
                return score;
            }
            set { }
        }
    }
    public class ProgressContext : DbContext
    {
        public DbSet<Progress> Progresses { get; set; }        
    }
}