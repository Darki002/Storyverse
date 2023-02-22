using System;
using System.Collections.Generic;

namespace StoryverseDb.Modul;

public class Story
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
