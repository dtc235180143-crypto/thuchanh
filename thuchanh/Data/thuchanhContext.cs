using Microsoft.EntityFrameworkCore;

public class thuchanhContext(DbContextOptions<thuchanhContext> options) : DbContext(options)
{
    public DbSet<day6_2._0.Models.Genre> Genre { get; set; } = default!;
}
