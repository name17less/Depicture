using System.Collections.Generic;
using UnityEngine;

public static class ServerDataPlug
{
    public static List<Category> GetCategories()
    {
        return new List<Category>()
        {
            new Category
            {
                id = "Artists", //4
                title = "Artists"
            },

            new Category
            {
                id = "Styles", //3
                title = "Styles"
            },
            
            new Category
            {
                id = "Epochs", //2
                title = "Epochs"
            }
        };
    }
    
    public static List<Topic> GetTopics()
    {
        return new List<Topic>()
        {
            new Topic
            {
                id = "vangogh",
                title = "Vincent van Gogh",
                categoryId = "Artists",
                quizId = "artistsQ",
                cards = new List<Card>()
                {
                    new Card { title="Biography", 
                        text="was a Dutch Post-Impressionist painter who is among the most famous and " +
                             "influential figures in the history of Western art.",
                        image = Resources.Load<Sprite>("Images/vangogh1")
                    },
                    new Card { title="Famous works", 
                        text="Starry Night (1889) is one of the most famous paintings in the world. It is kept in the Museum of Modern Art, New York.",
                        image = Resources.Load<Sprite>("Images/vangogh2")
                    }
                }
            },
            
            new Topic
            {
                id = "davinci",
                title = "Leonardo da Vinci",
                categoryId = "Artists",
                cards = new List<Card>()
                {
                    new Card
                    {
                        title="Biography",
                        text = "One of the most famous artists in the world."
                    }
                }
            },
            
            new Topic
            {
                id = "aivazovsky",
                title = "Ivan Konstantinovich Aivazovsky",
                categoryId = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", 
                        text="was a Russian Romantic painter who is considered one of the greatest masters of marine art.",
                        image = Resources.Load<Sprite>("Images/aivazovsky1")
                    },
                    new Card { title="Famous works", 
                        text="The Ninth Wave (1850, Russian Museum, Saint Petersburg) " +
                             "is considered Aivazovsky's most famous work.",
                        image = Resources.Load<Sprite>("Images/aivazovsky2")
                    }
                }
            },
            
            new Topic
            {
                id = "dali",
                title = "Salvador Dalí",
                categoryId = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", 
                        text="was a Spanish surrealist artist renowned for his technical skill, precise draftsmanship, " +
                             "and the striking and bizarre images in his work.",
                        image = Resources.Load<Sprite>("Images/dali1")
                    },
                    new Card { title="Famous works", 
                        text="The Persistence of Memory - is a 1931 painting by artist Salvador Dalí " +
                             "and one of the most recognizable works of Surrealism. " +
                             "First exhibited at the Julien Levy Gallery in 1932 and sold for $250, " +
                             "The Persistence of Memory was donated to the Museum of Modern Art (MoMA) " +
                             "in New York City two years later in 1934 by an anonymous donor, " +
                             "where it has remained ever since.",
                        image = Resources.Load<Sprite>("Images/dali2")
                    }
                }
            },
            
            new Topic
            {
                id = "raphael",
                title = "Raphael",
                categoryId = "Artists",
                cards = new List<Card>()
                {
                    new Card { title="Biography", 
                        text="was an Italian painter and architect of the High Renaissance. " +
                             "His work is admired for its clarity of form, ease of composition, " +
                             "and visual achievement of the Neoplatonic ideal of human grandeur.",
                        image = Resources.Load<Sprite>("Images/raphael1")
                    },
                    new Card { title="Famous works", 
                        text="The Resurrection of Christ is one of the first preserved works of Raphael " +
                             "in which his natural dramatic style of composition was already obvious, " +
                             "as opposed to the gentle poetic style of his master, Pietro Perugino.",
                        image = Resources.Load<Sprite>("Images/raphael2")
                    }
                }
            },
            
            new Topic
            {
                id = "impressionism",
                title = "Impressionism",
                categoryId = "Styles",
                cards = new List<Card>()
                {
                    new Card { title="Origin", 
                        text="It was a 19th-century art movement characterized by visible brush strokes, open composition, emphasis on accurate depiction of light in its changing qualities (often accentuating the effects of the passage of time), ordinary subject matter, unusual visual angles, and inclusion of movement as a crucial element of human perception and experience.",
                        image = Resources.Load<Sprite>("Images/impressionism1")
                    },
                }
            },
            
            new Topic
            {
                id = "pop",
                title = "Pop art",
                categoryId = "Styles",
                cards = new List<Card>()
                {
                    new Card { title="Origin", 
                        text="It is an art movement that emerged in the United Kingdom and the United States during the mid-to late 1950s.[1][2] The movement presented a challenge to traditions of fine art by including imagery from popular and mass culture—including advertising, comic strips, product packaging, celebrities, and everyday consumer goods—into painting, sculpture, and printmaking.",
                        image = Resources.Load<Sprite>("Images/pop1")
                    },
                }
            },
            
            new Topic
            {
                id = "renaissance",
                title = "Renaissance",
                categoryId = "Epochs",
                cards = new List<Card>()
                {
                    new Card { title="Origin", 
                        text="It is a European period of history and cultural movement, very roughly defined as covering the 14th through 17th centuries,[4][5] though sometimes more narrowly defined for instance as only covering the 15th through 16th centuries.[6] It marked the transition from the Middle Ages to modernity and was characterized by the European rediscovery and revival of the literary, philosophical, and artistic achievements of classical antiquity.",
                        image = Resources.Load<Sprite>("Images/renaissance1")
                    },
                }
            },
            
            new Topic
            {
                id = "renaissance1",
                title = "Renaissance",
                categoryId = "Epochs",
                cards = new List<Card>()
                {
                    new Card { title="Origin1", 
                        text="It is a European period of history and cultural movement, very roughly defined as covering the 14th through 17th centuries,[4][5] though sometimes more narrowly defined for instance as only covering the 15th through 16th centuries.[6] It marked the transition from the Middle Ages to modernity and was characterized by the European rediscovery and revival of the literary, philosophical, and artistic achievements of classical antiquity.",
                        image = Resources.Load<Sprite>("Images/renaissance1")
                    },
                }
            }
        };
    }
}