using ArticleService.Domain.Entities;

namespace ArticleService.Application.Features.Articles;

public class ArticleService : IArticlesService
{
    private readonly IArticleRepository _articleRepository;
    public ArticleService(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

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


    public Task<IEnumerable<Article>> GetArticlesByIdAsync(string id)
    {
        if (!int.TryParse(id, out var intId))
            return Task.FromResult<IEnumerable<Article?>>(Array.Empty<Article>());

        var result = _articleRepository.GetById(intId);

        IEnumerable<Article> list =
            result is null ? Array.Empty<Article>() : new[] { result };

        return Task.FromResult(list);
    }


    public async Task<IEnumerable<Article>> UpdateArticleAsync(int id, UpdateArticleRequest request)
    {
        return null;
    }


    public async Task<bool> DeleteArticleAsync(int id)
    {
        return false;
    }
}