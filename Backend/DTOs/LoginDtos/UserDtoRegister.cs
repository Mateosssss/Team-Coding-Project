using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.DTOs
{
    public class UserDtoRegister
    {
        public string Email { get; set; }=null!;
        public string Password { get; set; }=null!;
        public string Name_Surname { get; set; }=null!;
    }
}