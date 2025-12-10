using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Utils
{
    public class UserRoleStrings
    {
        public const string ServiceWorker = nameof(Helpers.UserRole.ServiceWorker);
        public const string Investor = nameof(Helpers.UserRole.Investor);
        public const string Admin = nameof(Helpers.UserRole.Admin);
        public const string Manager = nameof(Helpers.UserRole.Manager);
    }
}