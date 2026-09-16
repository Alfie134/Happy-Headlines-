namespace DraftService.Application.Features.Drafts;

public interface IDraftRepository
{
    public Domain.Entities.Draft GetById(int id);
    bool Delete(int id);
}