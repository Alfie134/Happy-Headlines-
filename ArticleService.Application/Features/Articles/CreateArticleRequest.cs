namespace ArticleService.Application.Features.Articles;

public class CreateArticleRequest
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateOnly? PublicationDate { get; set; }
    public string Content { get; set; } = string.Empty;
}