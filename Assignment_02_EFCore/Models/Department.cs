using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EFCore.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        public int Ins_ID { get; set; }

    }
}
