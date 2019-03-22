using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Aoife_Ryan_S00190488.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Aoife_Ryan_S00190488.Pages.Students
{
    public class CreateModel : PageModel
    {
        //MODEL FOR DATABASE
        private readonly CollegeContext _db;

        public CreateModel(CollegeContext db)
        {
            _db = db;
        }

        //DECLARING STUDENT CLASS
        [BindProperty]
        public Student Student { get; set; } = new Student();

        //public string[] Days { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

        //[BindProperty]
        //public bool[] IsChecked { get; set; } = new bool[5];

        


            //ACTION THAT HAPPENS ONPOST WHEN SUBMIT
        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {
                _db.Students.Add(Student);            
                await _db.SaveChangesAsync();

                return RedirectToPage("ListStudents");
                //return RedirectToPage("Cost");
            }
            else
            {
                return Page();
            }
           
        }

   
    }
}