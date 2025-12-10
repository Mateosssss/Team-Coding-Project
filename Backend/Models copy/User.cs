using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public string Name_Surname { get; set; }
        public Helpers.UserRole role { get; set; }
        public DateTime createdAt { get; set; } 
        public string? RefreshToken {get;set;}
        public DateTime? RefreshTokenExpiryTime {get;set;}
    }
}