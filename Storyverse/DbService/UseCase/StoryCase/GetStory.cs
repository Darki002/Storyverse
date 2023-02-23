using DbService.Repositories;

namespace DbService.UseCase.StoryCase;

public class GetStory
{
    public class Handler
    {
        private readonly IStoryRepository storyRepository;
        public Handler(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }
        
        public Story? SingleOrDefaultById(int id) => storyRepository.GetSingleOrDefaultById(id);
    }

    
}