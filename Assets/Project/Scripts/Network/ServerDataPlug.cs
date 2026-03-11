using System.Collections.Generic;
using UnityEngine;

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
                    new Card
                    {
                        title="Origin", 
                        text="Impressionism started in France...",
                        image = Resources.Load<Sprite>("Images/impress1")
                    },
                    new Card
                    {
                        title="Artists", text="Claude Monet, Renoir...",
                        image = Resources.Load<Sprite>("Images/impress 2")
                    }
                }
            },

            new Topic
            {
                id = "vangogh",
                title = "Vincent van Gogh",
                category = "Artists",
                cards = new List<Card>()
                {
                    new Card
                    {
                        title="Biography", text="Dutch post-impressionist painter...",
                        image = Resources.Load<Sprite>("Images/van gogh 1")
                    },
                    new Card
                    {
                        title="Famous works", text="Starry Night...",
                        image = Resources.Load<Sprite>("Images/van gogh 2")
                    }
                }
            }
        };
    }
}