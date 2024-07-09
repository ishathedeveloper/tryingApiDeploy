using Microsoft.EntityFrameworkCore;
using static DAL.Modal.AppDbModal;

namespace DAL.Modal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {

        }

        public virtual DbSet<UserMaster> UserMaster { get; set; }


    }
}
