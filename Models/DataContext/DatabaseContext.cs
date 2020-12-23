using AYS.Models.Modeller;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace AYS.Models.DataContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Talep> Talep { get; set; }
        

    }
}