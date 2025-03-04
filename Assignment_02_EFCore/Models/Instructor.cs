using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_EFCore.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Decimal Salary { get; set; }

        public Decimal Bouns { get; set; }

        public string Adress { get; set; }

        public int HourRate { get; set; }

        public int Dept_ID { get; set; }
    }
}
