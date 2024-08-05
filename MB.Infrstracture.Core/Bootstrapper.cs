using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrstracture.Core;

public class Bootstrapper
{
    public static void Config(WebApplicationBuilder builder, string connectionString)
    {
        builder.Services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
        builder.Services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

        builder.Services.AddDbContext<MasterBloggerContext>(options =>
            options.UseSqlServer(connectionString));
    }
}