using System.Collections.Generic;
using System.Threading.Tasks;

public class TopicController
{
    private TopicRepository repository = new TopicRepository();

    public async Task<List<Topic>> GetTopics()
    {
        return await repository.GetTopics();
    }
    
    public async Task<List<Category>> GetCategories()
    {
        return await repository.GetCategories();
    }

    public bool IsTopicRead(string id)
    {
        return repository.IsTopicRead(id);
    }

    public void MarkTopicRead(string id)
    {
        repository.MarkTopicRead(id);
    }
}