using UnityEngine;

public class ProgressStorage
{
    public void SaveTopicRead(string topicId)
    {
        PlayerPrefs.SetInt(topicId, 1);
        PlayerPrefs.Save();
    }

    public bool IsTopicRead(string topicId)
    {
        return PlayerPrefs.GetInt(topicId, 0) == 1;
    }
}