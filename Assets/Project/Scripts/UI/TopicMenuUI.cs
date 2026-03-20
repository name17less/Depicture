using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.UI;

public class TopicMenuUI : MonoBehaviour
{
    public Transform topicListParent;
    public GameObject topicButtonPrefab;

    public Transform categoryTabsParent;
    public GameObject categoryButtonPrefab;
    
    public GameObject topicItemWrapperPrefab;

    public TopicViewUI topicView;

    private TopicController controller = new TopicController();

    private string currentCategoryId = null;

    private List<Topic> allTopics = new List<Topic>();

    private CategoryButtonUI activeCategoryButton = null;

    async void Start()
    {
        allTopics = await controller.GetTopics();
        CreateCategoryButtons();
    }

    async void CreateCategoryButtons()
    {
        List<Category> categories = await controller.GetCategories();

        foreach (Category category in categories){
            
            GameObject obj = Instantiate(categoryButtonPrefab, categoryTabsParent);

            CategoryButtonUI button = obj.GetComponent<CategoryButtonUI>();

            button.Setup(category.title, this);
        }
    }

    public async void SelectCategory(string categoryId, CategoryButtonUI button)
    {
        currentCategoryId = categoryId;

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

        if (currentCategoryId == null)
            return;

        int index = 0;
        foreach (Topic topic in allTopics)
        {
            if (topic.categoryId != currentCategoryId)
                continue;
            
            GameObject objWrap = Instantiate(topicItemWrapperPrefab, topicListParent);
            HorizontalLayoutGroup layoutGroup = objWrap.GetComponent<HorizontalLayoutGroup>();

            if (index % 2 == 0)
            {
                layoutGroup.padding.left = 0;
                layoutGroup.padding.right = 400;
            }
            else
            {
                layoutGroup.padding.left = 400;
                layoutGroup.padding.right = 0;
            }
            
            GameObject obj = Instantiate(topicButtonPrefab, objWrap.transform);

            TopicButtonUI button = obj.GetComponent<TopicButtonUI>();

            button.Setup(
                topic,
                controller.IsTopicRead(topic.id),
                topicView
            );

            index++;
        }

        await Task.CompletedTask;
    }

    public async void Refresh()
    {
        await LoadTopics();
    }
}
