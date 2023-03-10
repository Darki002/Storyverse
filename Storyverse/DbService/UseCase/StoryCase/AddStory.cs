using DbService.Repositories;

namespace DbService.UseCase.StoryCase;

public class AddStory
{
    public class Handler
    {
        private readonly IStoryRepository storyRepository;

        public Handler(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }

        public void Execute(Story story) => storyRepository.Save(story);
    }
}