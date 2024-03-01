﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppCRUD.Data;
using WebAppCRUD.Model;

namespace WebAppCRUD.Pages.Users
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly WebAppCRUD.Data.WebAppCRUDContext _context;

        public IndexModel(WebAppCRUD.Data.WebAppCRUDContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;
        public List<ApplicationUser> Useres { get; set; }

        public async Task OnGetAsync()
        {
            Useres = _context.ApplicationUser.ToList();
            User = await _context.User.ToListAsync();
        }
    }
}
