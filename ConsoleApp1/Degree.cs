using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Degree
    {
        public string degreeName { get; set; }
        public int degreeId { get; set; }
        public Course course { get; set; }

        public Degree (string name, int Id) { degreeName = name; degreeId = Id; }
    }
}
