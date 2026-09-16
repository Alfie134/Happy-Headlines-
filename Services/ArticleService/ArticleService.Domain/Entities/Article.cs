namespace ArticleService.Domain.Entities;

public class Article
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateOnly PublicationDate { get; set; }
    public string Content { get; set; }

}