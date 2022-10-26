using Microsoft.EntityFrameworkCore;

namespace EFCoreCodeFirst.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options): base(options)
        {
        }

        #region DbSet
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        #endregion
    }
}
