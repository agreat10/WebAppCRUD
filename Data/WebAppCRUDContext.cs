using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppCRUD.Model;

namespace WebAppCRUD.Data
{
    public class WebAppCRUDContext : IdentityDbContext
    {
        public WebAppCRUDContext (DbContextOptions<WebAppCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCRUD.Model.User> User { get; set; } = default!;
    }
}
