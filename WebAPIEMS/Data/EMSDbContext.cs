using Microsoft.EntityFrameworkCore;
using WebAPIEMS.Models;

namespace WebAPIEMS.Data
{
    public class EMSDbContext : DbContext
    {
        public EMSDbContext(DbContextOptions<EMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIEMS.Models.EmpProfile> EmpProfile { get; set; } = default!;

        public DbSet<WebAPIEMS.Models.DeptMaster>? DeptMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed DeptMaster data
            modelBuilder.Entity<DeptMaster>().HasData(
                new DeptMaster { DeptCode = 1, DeptName = "CSE" },
                new DeptMaster { DeptCode = 2, DeptName = "MPC" },
                new DeptMaster { DeptCode = 3, DeptName = "MECH" },
                new DeptMaster { DeptCode = 4, DeptName = "ECE" },
                new DeptMaster { DeptCode = 5, DeptName = "IT" }
            );

            // Seed EmpProfile data
            modelBuilder.Entity<EmpProfile>().HasData(
                new EmpProfile { EmpCode = 101, EmpName = "Ramana", Email = "RamaaLoadethalra@gmail.com", DeptCode = 1, DateOfBirth = new DateTime(2004, 4, 12) },
                new EmpProfile { EmpCode = 102, EmpName = "Vikas", Email = "vickyjain@outlook.com", DeptCode = 2, DateOfBirth = new DateTime(1678, 2, 22) },
                new EmpProfile { EmpCode = 103, EmpName = "Vikram Rathore", Email = "vikramrathore@yahoo.com", DeptCode = 3, DateOfBirth = new DateTime(2008, 11, 9) },
                new EmpProfile { EmpCode = 104, EmpName = "Pepper pots", Email = "loveyou3000@gmail.com", DeptCode = 4, DateOfBirth = new DateTime(1999, 1, 7) },
                new EmpProfile { EmpCode = 105, EmpName = "chris Hemsworth", Email = "captainamerica@heroo.com", DeptCode = 5, DateOfBirth = new DateTime(2006, 11, 8) }
            );
        }
    }
}
