using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

public class TopicMenuUI : MonoBehaviour
{
    public Transform topicListParent;
    public GameObject topicButtonPrefab;

    public Transform categoryTabsParent;
    public GameObject categoryButtonPrefab;

    public TopicViewUI topicView;

    private TopicController controller = new TopicController();

    private string currentCategory = null;

    private List<Topic> allTopics = new List<Topic>();

    private CategoryButtonUI activeCategoryButton = null;

    async void Start()
    {
        allTopics = await controller.GetTopics();
        CreateCategoryButtons();
    }

    void CreateCategoryButtons()
    {
        HashSet<string> categories = new HashSet<string>();

        foreach (Topic topic in allTopics)
            categories.Add(topic.category);

        foreach (string category in categories)
        {
            GameObject obj = Instantiate(categoryButtonPrefab, categoryTabsParent);

            CategoryButtonUI button = obj.GetComponent<CategoryButtonUI>();

            button.Setup(category, this);
        }
    }

    public async void SelectCategory(string category, CategoryButtonUI button)
    {
        currentCategory = category;

        if (activeCategoryButton != null)
            activeCategoryButton.SetActive(false);

        activeCategoryButton = button;
        activeCategoryButton.SetActive(true);

        await LoadTopics();
    }

    async Task LoadTopics()
    {
        foreach (Transform child in topicListParent)
            Destroy(child.gameObject);

        if (currentCategory == null)
            return;

        foreach (Topic topic in allTopics)
        {
            if (topic.category != currentCategory)
                continue;

            GameObject obj = Instantiate(topicButtonPrefab, topicListParent);

            TopicButtonUI button = obj.GetComponent<TopicButtonUI>();

            button.Setup(
                topic,
                controller.IsTopicRead(topic.id),
                topicView
            );
        }

        await Task.CompletedTask;
    }
}
