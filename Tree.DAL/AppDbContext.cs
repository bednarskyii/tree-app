using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tree.DAL.Entities;
using Tree.DAL.Entities.ConcreteEntities;
using Tree.DAL.Entities.Layers;

namespace Tree.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Organizations> Organizations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Offering> Offerings { get; set; }
        public DbSet<Department> Departments { get; set; }


        public DbSet<OrganizationsLayer> OrganizationLayers { get; set; }
        public DbSet<CountryLayer> CountryLayers { get; set; }
        public DbSet<BusinessLayer> BusinessLayers { get; set; }
        public DbSet<FamilyLayer> FamilyLayers { get; set; }
        public DbSet<OfferingLayer> OfferingLayers { get; set; }
        public DbSet<DepartmentLayer> DepartmentLayers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
