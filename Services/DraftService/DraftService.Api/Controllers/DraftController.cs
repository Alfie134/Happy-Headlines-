using Microsoft.AspNetCore.Mvc;
using DraftService.Application.Features.Drafts;

namespace DraftService.Api.Controllers;

[ApiController]
[Route("api/drafts")]

public class ArticlesController : ControllerBase
{
    private readonly IDraftService _draftService;
    private readonly IDraftRepository _draftRepository;


    public ArticlesController(IDraftService draftService, IDraftRepository draftRepository)
    {
        _draftService = draftService;
        _draftRepository = draftRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateArticle([FromBody] CreateDraftRequest request)
    {
        var result = await _draftService.CreateDraftAsync(request);
        return Ok(new
        {
            result.DraftId
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetArticleById(string id)
    {
        var result = await _draftService.GetDraftByIdAsync(id);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateArticle(int id, UpdateDraftRequest request)
    {
        var updateDraft = await _draftService.UpdateDraftAsync(id, request);

        if (updateDraft is null)
            return NotFound();

        return Ok(updateDraft);
    }

    [HttpDelete]
    public Task<bool> DeleteDraft(string id)
    {
        if (!int.TryParse(id, out var intId))
            return Task.FromResult(false);

        var result = _draftRepository.Delete(intId);
        return Task.FromResult(result);
    }

}