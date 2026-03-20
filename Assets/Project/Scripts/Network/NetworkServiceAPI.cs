using System.Collections.Generic;
using System.Threading.Tasks;

public class NetworkService
{
    public async Task<List<Topic>> GetTopics()
    {
        return ServerDataPlug.GetTopics();
    }

    public async Task<List<Category>> GetCategories()
    {
        return ServerDataPlug.GetCategories();
    }
}