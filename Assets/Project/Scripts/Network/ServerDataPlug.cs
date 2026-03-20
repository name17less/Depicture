using System.Collections.Generic;

public static class ServerDataPlug
{
    public static List<Category> GetCategories()
    {
        return new List<Category>()
        {
            new Category
            {
                title = "Artists"
            },

            new Category
            {
                title = "Styles"
            },
            
            new Category
            {
                title = "Epochs"
            },
            
            new Category
            {
                title = "Countries"
            }
        };
    }
    
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
            },
            
            new Topic
            {
                id = "vangigh",
                title = "Vincent van Gigh",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "vangagh",
                title = "Vincent van Gagh",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "vangokhu",
                title = "Vincent van Gokhu",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "van",
                title = "Vincent van ",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "gagh",
                title = "Vincent Gagh",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "vangogh1",
                title = "Vincent van Gogh",
                category = "Artists1",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "vangogh2",
                title = "Vincent van Gogh",
                category = "Artists2",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            },
            
            new Topic
            {
                id = "vangogh3",
                title = "Vincent van Gogh",
                category = "Artists3",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            }
        };
    }
}