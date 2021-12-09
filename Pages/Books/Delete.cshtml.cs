using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lupu_Cosmina_Lab5.Data;
using Lupu_Cosmina_Lab5.Models;

namespace Lupu_Cosmina_Lab5.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly Lupu_Cosmina_Lab5.Data.Lupu_Cosmina_Lab5Context _context;

        public DeleteModel(Lupu_Cosmina_Lab5.Data.Lupu_Cosmina_Lab5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FindAsync(id);

            if (Book != null)
            {
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
