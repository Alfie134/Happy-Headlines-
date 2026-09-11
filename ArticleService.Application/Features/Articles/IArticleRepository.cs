namespace ArticleService.Application.Features.Articles;

public interface IArticleRepository
{

    Domain.Entities.Article GetById(int id);
    bool Delete(int id);
}