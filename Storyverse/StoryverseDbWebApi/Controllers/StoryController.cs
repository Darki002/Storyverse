using DbService.Repositories;
using DbService.UseCase.StoryCase;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StoryverseDb.Modul;
using StoryverseDb.Repositories;

namespace StoryverseDbWebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
[EnableCors("AllowOrigin")]
public class StoryController : ControllerBase
{
    [HttpGet(Name = "GetStory")]
    public IActionResult GetStory(int storyId)
    {
        IStoryRepository repo = new StoryRepository();
        var getStory = new GetStory.Handler(repo);
        var story = getStory.SingleOrDefaultById(storyId);
        
        return Ok(story);
    }

    [HttpPost(Name = "SaveStory")]
    public IActionResult SaveStory([FromBody]Models.Story story)
    {
        IStoryRepository repo = new StoryRepository();
        var addStory = new AddStory.Handler(repo);
        addStory.Execute(story.Map());
        return Ok();
    }

    [HttpPost(Name = "UpdateStory")]
    public IActionResult UpdateStory(int id, [FromBody] Models.Story updatedStory)
    {
        IStoryRepository repo = new StoryRepository();
        var storyUpdater = new UpdateStory.Handler(repo);
        var result = storyUpdater.Execute(id, updatedStory.Map());
        return result.IsSuccess ? Ok() : BadRequest(result.Exception);
    }
}