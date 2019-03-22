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
    public class ListStudentsModel : PageModel
    {
        // THIS GETS THE INFO FROM THE DATABASE AND ADDS TO THE LIST
        private readonly CollegeContext _db;

        public ListStudentsModel(CollegeContext db)
        {
            _db = db;
        }

        public IList<Student> Students { get; private set; }

        public async Task OnGetAsync()
        {
            Students = await _db.Students.AsNoTracking().ToListAsync();
        }
    }
}