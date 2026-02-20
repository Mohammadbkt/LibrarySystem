using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace library_system.Models
{
    public class User : IdentityUser<int>
    {
        string FirstName { get; set; } = String.Empty;
        string LastName { get; set; } = String.Empty;
        
        public bool IsVerified { get; set; }
        public byte MaxBorrowLimit { get; set; } = 10;

    }
}