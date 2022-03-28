using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerce1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("users");
            builder.Entity<IdentityRole>().ToTable("roles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("roleclaim");
            builder.Entity<IdentityUserClaim<string>>().ToTable("userclaim");
            builder.Entity<IdentityUserLogin<string>>().ToTable("userlogin");
            builder.Entity<IdentityUserToken<string>>().ToTable("userstokin");
            builder.Entity<IdentityUserRole<string>>().ToTable("usersroles");
        }
    }
}
