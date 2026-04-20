using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class QuizMenuUI : MonoBehaviour
{
    public GameObject topicMenuPanel;
    
    public TextMeshProUGUI questionLabel;
    public TextMeshProUGUI questionText;

    public Transform answersParent;
    public GameObject answerButtonPrefab;

    public GameObject nextButton;
    public GameObject exitButton;

    private List<QuizQuestion> questions;
    private int currentIndex = 0;
    private bool answered = false;

    public void StartQuiz(string quizId)
    {
        questions = FakeQuizData.GetQuestionsById(quizId);
        currentIndex = 0;

        gameObject.SetActive(true);

        ShowQuestion();
    }
    
    void ShowQuestion()
    {
        answered = false;
        nextButton.SetActive(false);

        foreach (Transform child in answersParent)
            Destroy(child.gameObject);

        QuizQuestion q = questions[currentIndex];

        questionLabel.text = $"Question {currentIndex + 1}";
        questionText.text = q.question;

        for (int i = 0; i < q.answers.Count; i++)
        {
            GameObject obj = Instantiate(answerButtonPrefab, answersParent);

            AnswerButtonUI button = obj.GetComponent<AnswerButtonUI>();
            button.Setup(q.answers[i], i, this);
        }
    }

    public void SelectAnswer(int index)
    {
        if (answered) return;

        answered = true;

        QuizQuestion q = questions[currentIndex];

        // Подсветка ответов
        for (int i = 0; i < answersParent.childCount; i++)
        {
            var btn = answersParent.GetChild(i).GetComponent<UnityEngine.UI.Image>();

            if (i == q.correctIndex)
                btn.color = Color.green;
            else if (i == index)
                btn.color = Color.red;
        }

        nextButton.SetActive(true);
    }

    public void NextQuestion()
    {
        currentIndex++;

        if (currentIndex >= questions.Count)
        {
            Debug.Log("Quiz finished");
            gameObject.SetActive(false);
            return;
        }

        ShowQuestion();
    }

    public void ExitQuiz()
    {
        gameObject.SetActive(false);

        if (topicMenuPanel != null)
            topicMenuPanel.SetActive(true);
    }
}
