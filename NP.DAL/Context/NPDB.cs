using Microsoft.EntityFrameworkCore;
using NP.DAL.Entityes;

namespace NP.DAL.Context
{
    public class NPDB : DbContext
    {
        public DbSet<BreakDbModel> Breaks { get; set; }
        public DbSet<СhangeSettingsDbModel> ChangeSettings { get; set; }

        public NPDB(DbContextOptions<NPDB> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
