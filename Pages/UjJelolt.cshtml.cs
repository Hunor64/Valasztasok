using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Valasztasok.Models;

namespace Valasztasok.Pages
{
    public class UjJeloltModel : PageModel
    {
        private readonly Valasztasok.Models.ValasztasDbContext _context;

        public UjJeloltModel(Valasztasok.Models.ValasztasDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PartRovidNev"] = new SelectList(_context.Partok, "RovidNev", "RovidNev");
            return Page();
        }

        [BindProperty]
        public Jelolt Jelolt { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Jeloltek.Add(Jelolt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
