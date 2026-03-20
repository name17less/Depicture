using UnityEngine;

using System.Collections.Generic;
using System.Threading.Tasks;

public class TopicRepository
{
    private NetworkService network = new NetworkService();
    private ProgressStorage storage = new ProgressStorage();

    public async Task<List<Topic>> GetTopics()
    {
        return await network.GetTopics();
    }
    
    public async Task<List<Category>> GetCategories()
    {
        return await network.GetCategories();
    }

    public bool IsTopicRead(string id)
    {
        return storage.IsTopicRead(id);
    }

    public void MarkTopicRead(string id)
    {
        storage.SaveTopicRead(id);
    }
}

