namespace MB.Application.Contracts.ArticleCategory;

public class ArticleCategoryViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string CreationDate { get; set; }
    public bool IsDeleted { get; set; }
}