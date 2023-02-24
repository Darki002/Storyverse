using DbService.Repositories;
using DbService.UseCase.Results;

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

        public Result Execute(int id, Story updatedStory)
        {
            try
            {
                storyRepository.Update(id, updatedStory);
                return new Result(true);
            }
            catch (ArgumentException e)
            {
                return new Result(false, e);
            }
        }
    }
}