using DraftService.Domain.Entities;

namespace DraftService.Application.Features.Drafts;

public class DraftService : IDraftService
{
    private readonly IDraftRepository _draftRepository;
    public DraftService(IDraftRepository draftRepository)
    {
        _draftRepository = draftRepository;
    }

    public async Task<Draft> CreateDraftAsync(CreateDraftRequest request)
    {
        var draft = new Draft
        {
            Title = request.Title,
            Author = request.Author,
            CreatedAt = DateTime.Now
        };

        return draft;
    }


    public Task<IEnumerable<Draft>> GetDraftByIdAsync(string id)
    {
        if (!int.TryParse(id, out var intId))
            return Task.FromResult<IEnumerable<Draft?>>(Array.Empty<Draft>());

        var result = _draftRepository.GetById(intId);

        IEnumerable<Draft> list =
            result is null ? Array.Empty<Draft>() : new[] { result };

        return Task.FromResult(list);
    }


    public async Task<IEnumerable<Draft>> UpdateDraftAsync(int id, UpdateDraftRequest request)
    {
        return null;
    }


    public async Task<bool> DeleteDraftAsync(int id)
    {
        return false;
    }
}