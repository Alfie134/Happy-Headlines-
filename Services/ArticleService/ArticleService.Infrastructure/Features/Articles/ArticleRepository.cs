using ArticleService.Application.Features.Articles;
using ArticleService.Domain.Entities;

namespace ArticleService.Infrastructure.Features.Article;

public class ArticleRepository : IArticleRepository
{

    public Domain.Entities.Article GetById()
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}