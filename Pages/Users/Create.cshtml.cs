using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppCRUD.Data;
using WebAppCRUD.Model;

namespace WebAppCRUD.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly WebAppCRUD.Data.WebAppCRUDContext _context;
        public List<ApplicationUser> Useres { get; set; }


        public CreateModel(WebAppCRUD.Data.WebAppCRUDContext context)
        {
            _context = context;
            
        }

        public IActionResult OnGet()
        {
            Useres = _context.ApplicationUser.ToList();
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


    }

}
