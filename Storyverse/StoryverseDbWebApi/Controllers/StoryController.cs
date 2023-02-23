using DbService;
using DbService.Repositories;
using DbService.UseCase.StoryCase;
using Microsoft.AspNetCore.Mvc;
using StoryverseDb.Repositories;

namespace StoryverseDbWebApi.Controllers;

[ApiController]
[Route("[controller]")]
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
    public IActionResult SaveStory([FromHeader]Story story)
    {
        IStoryRepository repo = new StoryRepository();
        var addStory = new AddStory.Handler(repo);
        addStory.Execute(story);
        return Ok();
    }

    [HttpPost(Name = "UpdateStory")]
    public IActionResult UpdateStory(int id, [FromHeader] Story updatedStory)
    {
        IStoryRepository repo = new StoryRepository();
        var storyUpdater = new UpdateStory.Handler(repo);
        storyUpdater.Execute(id, updatedStory);
        return Ok();
    }
}