using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public int ProductCode { get; set; }

        [BindProperty]
        public string IsChecked { get; set; }


        public string Message { get; set; } = "";

        public void OnPost(String Operation)
        {
            switch (Operation)
            {
                case "Red":
                    Message = $"You have chosen Red";
                    break;
                case "Yellow":
                    Message = $"You have chosen Yellow";
                    break;
                case "Black":
                    Message = $"You have chosen Black";
                    break;

            }
        }
    }
}