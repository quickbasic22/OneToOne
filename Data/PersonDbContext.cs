using Microsoft.EntityFrameworkCore;
public class PersonDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BagaOneToOne;Trusted_Connection=True;");
    }

    public DbSet<Person> People { get; set; }
    public DbSet<PersonPhoto> PeoplePhoto { get; set; }
}