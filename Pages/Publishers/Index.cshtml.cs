using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lupu_Cosmina_Lab5.Data;
using Lupu_Cosmina_Lab5.Models;

namespace Lupu_Cosmina_Lab5.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Lupu_Cosmina_Lab5.Data.Lupu_Cosmina_Lab5Context _context;

        public IndexModel(Lupu_Cosmina_Lab5.Data.Lupu_Cosmina_Lab5Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
