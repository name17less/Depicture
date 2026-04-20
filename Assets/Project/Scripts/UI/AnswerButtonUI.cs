using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButtonUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button button;

    private int index;
    private QuizMenuUI quiz;

    public void Setup(QuizAnswer answer, int answerIndex, QuizMenuUI quizUI)
    {
        text.text = answer.answer;
        index = answerIndex;
        quiz = quizUI;

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        quiz.SelectAnswer(index);
    }
}