using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Channel6.Domain.Entities;

namespace Channel6.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
