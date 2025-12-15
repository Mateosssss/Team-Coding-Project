using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.DTOs
{
    public class RefreshTokenRequestDto
    {
        public required string RefreshToken {get;set;}
    }
}