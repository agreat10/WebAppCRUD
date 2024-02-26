using Microsoft.AspNetCore.Identity;

namespace WebAppCRUD.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        
    }
}
