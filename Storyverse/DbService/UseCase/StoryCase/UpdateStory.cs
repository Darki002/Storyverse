using DbService.Repositories;

namespace DbService.UseCase.StoryCase;

public class UpdateStory
{
    public class ContentHandler
    {
        private readonly IStoryRepository storyRepository;

        public ContentHandler(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }

        public void Execute(int id, string newContent) => storyRepository.UpdateContent(id, newContent);
    }
    
    public class TitleHandler
    {
        private readonly IStoryRepository storyRepository;

        public TitleHandler(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }

        public void Execute(int id, string newTitle) => storyRepository.UpdateTitle(id, newTitle);
    }
}