using ASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("ASPNETMVC") { }
        public DbSet<Employee> employees { get; set; }

        public System.Data.Entity.DbSet<ASPNETMVC.Models.Division> Divisions { get; set; }
    }
}