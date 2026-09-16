namespace ArticleService.Application.Features.Articles;

public interface IArticleRepository
{

    public Domain.Entities.Article GetById();
    bool Delete(int id);
}