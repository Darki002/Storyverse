using System;
using System.Collections.Generic;

namespace StoryverseDb.Modul;

public partial class Story
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public DateTime CreationDate { get; set; }
}
