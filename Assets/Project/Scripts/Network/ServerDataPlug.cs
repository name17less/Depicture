using System.Collections.Generic;

public static class ServerDataPlug
{
    public static List<Category> GetCategories()
    {
        return new List<Category>()
        {
            new Category
            {
                id = "Artists",
                title = "Artists"
            },

            new Category
            {
                id = "Styles",
                title = "Styles"
            },
            
            new Category
            {
                id = "Epochs",
                title = "Epochs"
            },
            
            new Category
            {
                id = "Countries",
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
                categoryId = "Styles",
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
                categoryId = "Artists",
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
                categoryId = "Artists",
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
                categoryId = "Artists",
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
                categoryId = "Artists",
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
                categoryId = "Artists",
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
                categoryId = "Artists",
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
                categoryId = "Artists1",
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
                categoryId = "Artists2",
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
                categoryId = "Artists3",
                cards = new List<Card>()
                {
                    new Card { title="Biography", text="Dutch post-impressionist painter..." },
                    new Card { title="Famous works", text="Starry Night..." }
                }
            }
        };
    }
}