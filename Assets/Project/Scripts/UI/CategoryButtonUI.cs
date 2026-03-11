using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CategoryButtonUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button button;
    public Image background;

    public Color normalColor = Color.white;
    public Color activeColor = new Color(0.7f, 0.9f, 1f);

    private string category;
    private TopicMenuUI menu;

    public void Setup(string categoryName, TopicMenuUI menuUI)
    {
        category = categoryName;
        menu = menuUI;

        text.text = category;

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnClick);

        SetActive(false);
    }

    void OnClick()
    {
        menu.SelectCategory(category, this);
    }

    public void SetActive(bool active)
    {
        if (background != null)
            background.color = active ? activeColor : normalColor;
    }
}