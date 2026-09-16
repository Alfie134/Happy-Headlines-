using ArticleService.Application.Features.Articles;
using Microsoft.AspNetCore.Mvc;

namespace ArticleService.Api.Controllers;

[ApiController]
[Route("api/articles")]

public class ArticlesController : ControllerBase
{
    private readonly IArticlesService _artivcleService;
    private readonly IArticleRepository _articleRepository;


    public ArticlesController(IArticlesService articlesService, IArticleRepository articleRepository)
    {
        _artivcleService = articlesService;
        _articleRepository = articleRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateArticle([FromBody] CreateArticleRequest request)
    {
        var result = await _artivcleService.CreateArticleAsync(request);
        return Ok(new
        {
            result.ArticleId
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetArticleById(string id)
    {
        var result = await _artivcleService.GetArticlesByIdAsync(id);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateArticle(int id, UpdateArticleRequest request)
    {
        var updateArticle = await _artivcleService.UpdateArticleAsync(id, request);

        if (updateArticle is null)
            return NotFound();

        return Ok(updateArticle);
    }

    [HttpDelete]
    public Task<bool> DeleteArticle(string id)
    {
        if (!int.TryParse(id, out var intId))
            return Task.FromResult(false);

        var result = _articleRepository.Delete(intId);
        return Task.FromResult(result);
    }

}