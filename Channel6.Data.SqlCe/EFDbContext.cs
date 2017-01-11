using Channel6.Model;
using System.Data.Entity;
using Channel6.Data;

namespace Channel6.Data.SqlCe
{
    public class EFDbContext : DbContext, IUnitOfWork
    {

        public EFDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Channel> Channels { get; set; }
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// Allows saving changes via the IUnitOfWork interface.
        /// </summary>
        void IUnitOfWork.SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
