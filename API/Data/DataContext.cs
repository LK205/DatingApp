using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //Khoi tao database
        public DataContext(DbContextOptions options) : base(options) {}
        //Tao bang 
        public DbSet<AppUser> Users { get; set; }
    }
}
    