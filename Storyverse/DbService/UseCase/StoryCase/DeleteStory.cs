using DbService.Repositories;

namespace DbService.UseCase.StoryCase;

public class DeleteStory
{
    public class Handler
    {
        private readonly IStoryRepository storyRepository;

        public Handler(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }

        public void Execute(int id) => storyRepository.Delete(id);
    }
}