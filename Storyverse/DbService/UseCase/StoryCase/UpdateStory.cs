using DbService.Repositories;

namespace DbService.UseCase.StoryCase;

public class UpdateStory
{
    public class Handler
    {
        private readonly IStoryRepository storyRepository;

        public Handler(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }

        public void Execute(int id, Story updatedStory)
        {
            storyRepository.Update(id, updatedStory);
        }
    }
}