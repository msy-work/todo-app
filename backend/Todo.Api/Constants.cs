using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.Api
{
    public static class Constants
    {
        public const string AdminRole     = "Admin";
        public const string SuperUserRole = "SuperUser";
        public const string UserRole      = "User";
    }
}
