namespace DraftService.Application.Features.Drafts;

public class CreateDraftRequest
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
}