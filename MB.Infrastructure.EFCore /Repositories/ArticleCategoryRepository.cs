using MB.Domain.ArticleCategoryAgg;

namespace MB.Infrastructure.EFCore.Repositories;

public class ArticleCategoryRepository : IArticleCategoryRepository
{
    private MasterBloggerContext _context;

    public ArticleCategoryRepository(MasterBloggerContext context)
    {
        _context = context;
    }

    public List<ArticleCategory> GetAll()
    {
        return _context.ArticleCategories.ToList();
    }

    public void Create(ArticleCategory entity)
    {
        _context.ArticleCategories.Add(entity);
        _context.SaveChanges();
    }
}