using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore;

public class MasterBloggerContext : DbContext
{
    public DbSet<ArticleCategory> ArticleCategories { get; set; }
    
    public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // apply models mapping here
        modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
        
        base.OnModelCreating(modelBuilder);
    }
}