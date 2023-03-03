namespace StoryverseDbWebApi.Models;

public class Story
{
    public string? Title { get; set; } = null!;

    public string? Content { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DbService.Story Map()
    {
        return new DbService.Story
        {
            Title = Title,
            Content = Content,
            CreationDate = CreationDate
        };
    }
}