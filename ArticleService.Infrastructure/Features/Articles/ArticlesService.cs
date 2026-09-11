using ArticleService.Domain.Entities;
using ArticleService.Application.Features.Articles;

namespace ArticleService.Infrastructure.Features.Articles;

public class ArticlesService : IArticlesService
{
    // public ArticleService()
    // {

    // }
    public async Task<Article> CreateArticleAsync(CreateArticleRequest request)
    {
        var article = new Article
        {
            Title = request.Title,
            Author = request.Author,
            PublicationDate = DateOnly.FromDateTime(DateTime.Now)
        };

        return article;
    }


    public async Task<IEnumerable<Article>> GetArticlesByIdAsync(int id)
    {
        return null;
    }


    public async Task<IEnumerable<Article>> UpdateArticleAsync(int id)
    {
        return null;
    }


    public async Task<bool> DeleteArticleAsync(int id)
    {
        return false;
    }
}