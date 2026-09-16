namespace DraftService.Domain.Entities;

public class Draft()
{
    public Guid DraftId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public string PublisherId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}