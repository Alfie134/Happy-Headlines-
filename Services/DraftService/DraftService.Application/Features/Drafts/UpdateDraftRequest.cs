namespace DraftService.Application.Features.Drafts;

public class UpdateDraftRequest
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime? UpdatedAt { get; set; }


}