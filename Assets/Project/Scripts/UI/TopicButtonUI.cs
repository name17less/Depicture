using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TopicButtonUI : MonoBehaviour
{
    public TextMeshProUGUI title;
    public GameObject checkmark;

    private Topic topic;
    private TopicViewUI topicView;

    public void Setup(Topic topicData, bool isRead, TopicViewUI view)
    {
        topic = topicData;
        topicView = view;

        title.text = topic.title;
        checkmark.SetActive(isRead);

        Button button = GetComponent<Button>();

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OpenTopic);
    }

    void OpenTopic()
    {
        if (topicView != null)
        {
            topicView.OpenTopic(topic);
        }
        else
        {
            Debug.LogError("TopicViewUI not assigned!");
        }
    }
}