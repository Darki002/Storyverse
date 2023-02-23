namespace DbService.Repositories;

public interface IStoryRepository
{
    void Save(Story story);

    void Delete(int id);
    
    void Update(int id, Story updatedStory);

    Story? GetSingleOrDefaultById(int id);
}