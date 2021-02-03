using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace practice1.Models
{
    public class Context : DbContext 
    {
        public Context() : base("db") { }
        public DbSet<student> Students { get; set; }

    }
}