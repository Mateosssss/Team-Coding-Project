using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjektZespołówka.Models
{
   public class User : IdentityUser<Guid>
    {
        // Pól Id, email, passwordHash JUŻ TU NIE WPISUJEMY - są w IdentityUser
        
        public string Name_Surname { get; set; } = string.Empty;
        public Helpers.UserRole role { get; set; }
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}