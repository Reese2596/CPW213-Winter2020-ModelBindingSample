using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Display(Name ="Full Name:")] //Data annotations
        [Required(ErrorMessage ="Full Name is Required")]
        public string FullName { get; set; }

        [Display(Name ="Date of Birth:")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name ="Favorite Number:")]
        [Range(1, 99, ErrorMessage ="Pick a Number between 0 and 99")]
        [Required] //int is always required becasue it is a value type
                   //unless you make the int nullable(ex:int?)
        public int FavoriteNumber { get; set; }
    }
}
