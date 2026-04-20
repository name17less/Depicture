using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TopicViewUI : MonoBehaviour
{
    public Image cardImage;
    public TextMeshProUGUI cardTitle;
    public TextMeshProUGUI cardText;
    public GameObject topicMenuPanel; // <-- новая ссылка на меню

    public GameObject quizButton;
    public QuizMenuUI quizMenu;
    
    private Topic currentTopic;
    private int index;

    private TopicController controller = new TopicController();

    public void OpenTopic(Topic topic)
    {
        currentTopic = topic;
        index = 0;

        gameObject.SetActive(true);

        // Скрываем меню выбора тем
        if (topicMenuPanel != null)
            topicMenuPanel.SetActive(false);
        
        quizButton.SetActive(!string.IsNullOrEmpty(topic.quizId));
        
        ShowCard();
    }

    public void NextCard()
    {
        if (index < currentTopic.cards.Count - 1)
        {
            index++;
            ShowCard();
        }
        else
        {
            controller.MarkTopicRead(currentTopic.id);
        }
    }

    public void PrevCard()
    {
        if (index > 0)
        {
            index--;
            ShowCard();
        }
    }

    void ShowCard()
    {
        Card card = currentTopic.cards[index];

        cardTitle.text = card.title;
        cardText.text = card.text;
        cardImage.sprite = card.image;
    }

    public void StartQuiz()
    {
        if (quizMenu != null && currentTopic != null)
        {
            gameObject.SetActive(false);
            quizMenu.StartQuiz(currentTopic.quizId);
        }
    }
    
    public void Close()
    {
        gameObject.SetActive(false);

        // Возвращаем меню выбора тем
        if (topicMenuPanel != null)
        {
            topicMenuPanel.SetActive(true);

            TopicMenuUI topicMenuUI = topicMenuPanel.GetComponent<TopicMenuUI>();
            if (topicMenuUI != null) topicMenuUI.Refresh();
        }
    }
}