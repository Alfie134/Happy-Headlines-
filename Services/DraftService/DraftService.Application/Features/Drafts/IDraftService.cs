using DraftService.Domain.Entities;

namespace DraftService.Application.Features.Drafts;


public interface IDraftService
{
    Task<Draft> CreateDraftAsync(CreateDraftRequest request);
    Task<IEnumerable<Draft>> GetDraftByIdAsync(string id);
    Task<IEnumerable<Draft>> UpdateDraftAsync(int id, UpdateDraftRequest request);
    Task<bool> DeleteDraftAsync(int id);

}