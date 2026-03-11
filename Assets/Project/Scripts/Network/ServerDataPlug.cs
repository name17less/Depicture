using System.Collections.Generic;

public static class ServerDataPlug
{
    public static List<Topic> GetTopics()
    {
        return new List<Topic>()
        {
            new Topic
            {
                id = "impressionism",
                title = "Impressionism",
                category = "Styles",
                cards = new List<Card>()
                {
                    new Card { title="Origin", text="Impressionism started in France..." },
                    new Card { title="Artists", text="Claude Monet, Renoir..." }
                }
            },

            new Topic
            {
                id = "vangogh",
                title = "Vincent van Gogh",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            }
        };
    }
}