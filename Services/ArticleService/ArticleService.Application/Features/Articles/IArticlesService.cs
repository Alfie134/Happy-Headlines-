using ArticleService.Domain.Entities;

namespace ArticleService.Application.Features.Articles;

public interface IArticlesService
{
    Task<Article> CreateArticleAsync(CreateArticleRequest request);
    Task<IEnumerable<Article>> GetArticlesByIdAsync(string id);
    Task<IEnumerable<Article>> UpdateArticleAsync(int id, UpdateArticleRequest request);
    Task<bool> DeleteArticleAsync(int id);

}