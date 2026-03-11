using System.Collections.Generic;
using System.Threading.Tasks;

public class NetworkService
{
    public async Task<List<Topic>> GetTopics()
    {
        // имитация сетевого запроса
        await Task.Delay(500);

        return ServerDataPlug.GetTopics();
    }
}