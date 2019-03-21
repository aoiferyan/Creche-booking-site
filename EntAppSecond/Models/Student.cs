using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Aoife_Ryan_S00190488.Models
{
    public class Student
    {

        [Required]
        public string ID { get; set; } = "";

        [Required (ErrorMessage ="Please enter Name")]
        [Display (Name = "First Name")]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }


        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string ParentFN { get; set; }
        [Required]
        public string ParentSN { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int? MobileNum { get; set; }
        
        public int? SecondNum { get; set; }
        
        public int? OtherNum { get; set; }
        [Required]
        public string Email1 { get; set; }
        
        public string Email2 { get; set; }
        [Required]
        public string StartDate { get; set; }
    }
}
