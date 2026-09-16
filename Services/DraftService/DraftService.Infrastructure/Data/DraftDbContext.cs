using Microsoft.EntityFrameworkCore;
using Services.DraftService.DraftService.Domain.Entities;

namespace Services.DraftService.DraftService.Infrastructure.Data;

public class DraftDbContext : DbContext
{
    public DraftDbContext(DbContextOptions<DraftDbContext> options)
        : base(options) { }

    public DbSet<Draft> Drafts => Set<Draft>();
}