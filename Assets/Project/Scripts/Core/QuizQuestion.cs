using System.Collections.Generic;

[System.Serializable]
public class QuizQuestion
{
    public string question;
    public List<QuizAnswer> answers;
    public int correctIndex;
}
