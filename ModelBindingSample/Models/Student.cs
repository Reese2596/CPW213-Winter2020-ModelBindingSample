using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int FavoriteNumber { get; set; }
    }
}
