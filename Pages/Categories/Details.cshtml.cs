using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lupu_Cosmina_Lab5.Data;
using Lupu_Cosmina_Lab5.Models;

namespace Lupu_Cosmina_Lab5.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Lupu_Cosmina_Lab5.Data.Lupu_Cosmina_Lab5Context _context;

        public DetailsModel(Lupu_Cosmina_Lab5.Data.Lupu_Cosmina_Lab5Context context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
