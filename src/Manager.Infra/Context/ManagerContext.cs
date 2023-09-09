using Manager.Domain.Entities;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context{
    public class ManagerContext : DbContext{
        public ManagerContext()
        {}

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {}
        
        // RECOMENDAVEL TIRAR POR SEGURANÇA
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ILV12HB\SQLEXPRESS;Database=USERMANAGERAPI;Integrated Security=True; Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //   optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ILV12HB\SQLEXPRESS;Database=USERMANAGERAPI;User Id=SA;Password=429155;Integrated Security=True; Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}


        public  virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}