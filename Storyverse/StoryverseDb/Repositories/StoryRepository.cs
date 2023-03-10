using System.IO.MemoryMappedFiles;
using DbService;
using DbService.Repositories;
using StoryverseDb.Mapping;

namespace StoryverseDb.Repositories;

public class StoryRepository : IStoryRepository
{
    public void Save(Story story)
    {
        using var context = new StoryverseContext();
        var storyToSave = StoryMapper.Map(story);
        context.Stories.Add(storyToSave);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        using var context = new StoryverseContext();
        var existingStory = context.Stories.SingleOrDefault(s => s.Id == id);
        if (existingStory is null) throw new ArgumentException($"Story with id {id} not found");
        context.Remove(existingStory);
        context.SaveChanges();
    }

    public void Update(int id, Story updatedStory)
    {
        using var context = new StoryverseContext();
        var existingStory = context.Stories.SingleOrDefault(s => s.Id == id);
        if (existingStory is null) throw new ArgumentException($"Story with id {id} not found");

        existingStory.Title = updatedStory.Title;
        existingStory.Content = updatedStory.Content;
        context.SaveChanges();
    }

    public Story? GetSingleOrDefaultById(int id)
    {
        using var context = new StoryverseContext();
        var story = context.Stories.SingleOrDefault(s => s.Id == id);
        return story is null ? null : StoryMapper.Map(story);
    }
}