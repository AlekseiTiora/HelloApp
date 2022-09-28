using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    // навигационное свойство
    public Company? Company { get; set; }
}
[NotMapped]
public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
}

namespace HelloApp
{
    public class ApplicationContext : DbContext
    {

        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }

    }
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Position { get; set; }
        public Company? Company { get; set; }
    }

}
