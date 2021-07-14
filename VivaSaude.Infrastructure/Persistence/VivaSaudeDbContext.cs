using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Entities;
using VivaSaude.Core.Enums;

namespace VivaSaude.Infrastructure.Persistence
{
    public class VivaSaudeDbContext : DbContext
    {
        public VivaSaudeDbContext(DbContextOptions<VivaSaudeDbContext> options) : base(options)
        {
            
        }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<User>()
                .HasKey(u => u.Id);

            model.Entity<User>()
                .Property(u => u.Peso)
                .HasMaxLength(300);

            model.Entity<User>()
                .Property(u => u.Imc)
                .HasPrecision(2, 1);


                
                
                
        }
    }
}
