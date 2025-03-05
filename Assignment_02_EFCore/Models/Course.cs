using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EFCore.Models
{
    public class Course
    {
        public int ID { get; set; }

        public int Duration { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Top_ID { get; set; }

        public ICollection<Stud_Course> Stud_Course { get; set; }
    }
}
