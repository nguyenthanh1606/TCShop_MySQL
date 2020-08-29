using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TCShop.Data.Entities
{
    public class AppRole:IdentityRole<Guid>
    {
        public string Derscription { get; set; }
    }
}
