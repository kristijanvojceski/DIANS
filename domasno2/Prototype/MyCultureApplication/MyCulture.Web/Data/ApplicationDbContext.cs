using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCulture.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCulture.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyCultureUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
