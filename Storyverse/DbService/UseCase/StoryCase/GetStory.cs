using DbService.Repositories;

namespace DbService.UseCase.StoryCase;

public class GetStory
{
    private readonly IStoryRepository storyRepository;

    public GetStory(IStoryRepository storyRepository)
    {
        this.storyRepository = storyRepository;
    }

    public Story? SingleOrDefaultById(int id) => storyRepository.GetSingleOrDefaultById(id);
}