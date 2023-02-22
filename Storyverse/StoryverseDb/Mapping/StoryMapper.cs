using Story = StoryverseDb.Modul.Story;

namespace StoryverseDb.Mapping;

internal static class StoryMapper
{
    public static Story Map(DbService.Story story)
    {
        return new Story
        {
            Title = story.Title,
            Content = story.Content,
            CreationDate = story.CreationDate
        };
    }
    
    public static DbService.Story Map(Story story)
    {
        return new DbService.Story
        {
            Title = story.Title,
            Content = story.Content,
            CreationDate = story.CreationDate
        };
    }
}