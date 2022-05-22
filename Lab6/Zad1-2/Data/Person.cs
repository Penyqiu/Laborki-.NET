using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Zad1_2.Data;

public class Person
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}

public class PersonContext : DbContext
{
    public PersonContext()
    {
    }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql("Host=localhost;Database=lab6;Username=postgres;Password=root123")
            .UseSnakeCaseNamingConvention();
}