using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Persistence.Data.Configurations;

namespace Persistence.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }
    
    //Tables
    public DbSet<Employee> Employees { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Применение конфигураций
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }
}