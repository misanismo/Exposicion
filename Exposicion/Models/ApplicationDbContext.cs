using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentData;

namespace Exposicion.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public IDbContext Context
        {
            get
            {
                return new DbContext().ConnectionStringName("Server=localhost;Database=MSSQLLocalDB;Trusted_Connection=True;",
                    new SqlServerProvider());
            }
        }

        

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<Exposicion.Models.Producto> Productoes { get; set; }
    }
}