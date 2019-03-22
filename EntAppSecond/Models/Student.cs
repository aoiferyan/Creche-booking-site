using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace Aoife_Ryan_S00190488.Models
{
    public class Student
    {
        //START OF PROPERTIES ABOUT THE STUDENT

        //National ID prop which is required and there is a required format like a ppsn where you need 7 digits and a charachter.
        //This was implemented using a regular expression
        [Required(ErrorMessage = "Please enter Personal ID")]
        [Display(Name = "Personal ID number e.g. 1234567A")]
        [RegularExpression(@"\d{7}\S")]
        public string ID { get; set; } = "";

        //there are naming props Both are required
        [Required(ErrorMessage = "Please enter Name")]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter Surname")]     
        public string Surname { get; set; }

        //Date of birth prop is a required field
        [Required(ErrorMessage = "Date Of Birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }


        //gender prop is not required
        [Required(ErrorMessage = "Please enter Gender")]
        public string Gender { get; set; }


        //START OF PROPERTIES ABOUT THE PARENT/GUARDIAN


        //these are naming props Both are required
        [Required(ErrorMessage = "Please enter Parents Firstname")]
        [Display(Name = "Parent/Guardian Firstname")]
        public string ParentFN { get; set; }

        [Required(ErrorMessage = "Please enter Parents Surname")]
        [Display(Name = "Parent/Guardian Surname")]
        public string ParentSN { get; set; }


        //property for relationship to child. It is required and there is validation for this as a regular expression
        [Required(ErrorMessage = "Please enter Relationship")]
        [Display(Name = "Relationship to child: Mother, Father or Other")]
        [RegularExpression(@"Mother|Father|Other")]
        public string Relationship { get; set; }

        //Address property not required
        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }


        //Three properties for mobile  numbers but only 2 are required. It has to be a 10 digit irish number no spaces
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"\d{10}")]
        public string MobileNum { get; set; }

        [Required(ErrorMessage = "Please enter Second Number")]
        [Display(Name = "Secondary mobile Number")]
        [RegularExpression(@"\d{10}")]
        public string SecondNum { get; set; }

        [Display(Name = "Third mobile Number")]
        [RegularExpression(@"\d{10}")]
        public string OtherNum { get; set; }

        //Two properties for email but only 1 required. It has to be a valid email address.
        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "This is not a valid email")]
        [Display(Name = "Primary Email")]
        public string Email1 { get; set; }

        [EmailAddress(ErrorMessage = "This is not a valid email")]
        [Display(Name = "Secondary Email")]
        public string Email2 { get; set; }

        //property for startdate is required. The validation for this is not working
        [Required(ErrorMessage = "Please enter Start date in the Future")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [StartDate]
        public static DateTime StartDate { get; set; }


        //These are the checkbox properties one for each day from Monday to Friday
        [Display(Name = "Monday")]
        public bool Monday { get; set; }

        [Display(Name = "Tuesday")]
        public bool Tuesday { get; set; }

        [Display(Name = "Wednesday")]
        public bool Wednesday { get; set; }

        [Display(Name = "Thursday")]
        public bool Thursday { get; set; }

        [Display(Name = "Friday")]
        public bool Friday { get; set; }


        //These are the Radiobutton properties one for full time and part time
        [Display(Name = "PartTime")]
        public bool PartTime { get; set; }

        [Display(Name = "FullTime")]
        public bool FullTime { get; set; }

        //This is the cost property
        [Display(Name = "Cost")]
        public string Cost { get; set; }




    }
}
