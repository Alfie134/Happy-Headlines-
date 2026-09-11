using ArticleService.Application.Features.Articles;
using Microsoft.AspNetCore.Mvc;

namespace ArticleService.Api.Controllers;

[ApiController]
[Route("api/articles")]

public class ArticlesController : ControllerBase
{
    private readonly IArticlesService _artivcleService;


    public ArticlesController(IArticlesService articlesService)
    {
        _artivcleService = articlesService;
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

    [HttpGet]
    public async Task<IActionResult> GetArticleById(int id)
    {
        return null;
    }

    [HttpPut]
    public async Task<IActionResult> UpdateArticle(int id)
    {
        return null;
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteArticle(int id)
    {
        return null;
    }

}