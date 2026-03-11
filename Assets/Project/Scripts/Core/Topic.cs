using System.Collections.Generic;

[System.Serializable]
public class Topic
{
    public string id;
    public string title;
    public string category;
    public List<Card> cards;
}
