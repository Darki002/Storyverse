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
        var getStory = new GetStory(repo);
        var story = getStory.SingleOrDefaultById(storyId);
        
        return Ok(story);
    }

    [HttpPost(Name = "SaveStory")]
    public IActionResult SaveStory([FromHeader]Story story)
    {
        
        return Ok();
    }
}