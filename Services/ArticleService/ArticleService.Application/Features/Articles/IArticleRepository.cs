namespace ArticleService.Application.Features.Articles;

public interface IArticleRepository
{

    public Domain.Entities.Article GetById(int id);
    bool Delete(int id);
}