using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Aoife_Ryan_S00190488.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aoife_Ryan_S00190488.Pages.Students
{
    public class CreateModel : PageModel
    {

        private readonly CollegeContext _db;

        public CreateModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();
       
        //public void OnGet()
        //{
        //    Student.Firstname = HttpContext.GetString("Firstname");
        //    Student.Surname = HttpContext.GetString("Surname");
        //    Student.ID = HttpContext.GetString("ID");
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(Student);
                await _db.SaveChangesAsync();

                return RedirectToPage("ListStudents");
            }
            else
            {
                return Page();
            }
        }
    }
}