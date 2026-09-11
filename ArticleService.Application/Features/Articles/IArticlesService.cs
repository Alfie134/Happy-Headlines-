
using ArticleService.Domain.Entities;
using ArticleService.Application.Features.Articles;

namespace ArticleService.Application.Features.Articles;

public interface IArticlesService
{
    Task<Article> CreateArticleAsync(CreateArticleRequest request);
    Task<IEnumerable<Article>> GetArticlesByIdAsync(int id);
    Task<IEnumerable<Article>> UpdateArticleAsync(int id);
    Task<bool> DeleteArticleAsync(int id);

}