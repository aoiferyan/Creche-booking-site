using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoife_Ryan_S00190488.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Aoife_Ryan_S00190488.Pages.Students
{
    public class StudentDetailsModel : PageModel
    {
        private readonly CollegeContext _db;

        public StudentDetailsModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Student = await _db.Students.FindAsync(id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var student = await _db.Students.FindAsync(Student.ID);

            if (student != null)
            {
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("ListStudents");
        }
        //    public void OnGet()
        //    {

        //    }
        //
    }
}