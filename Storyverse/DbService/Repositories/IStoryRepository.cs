namespace DbService.Repositories;

public interface IStoryRepository
{
    void Save(Story story);

    void Delete(int id);
    
    void UpdateTitle(int id, string newTitle);

    void UpdateContent(int id, string newContent);

    Story? GetSingleOrDefaultById(int id);
}