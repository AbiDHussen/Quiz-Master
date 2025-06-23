using UnityEngine;
[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField]string question = "Enter New question text here";
    [SerializeField]string[] answers = new string[4] { "Answer A", "Answer B", "Answer C", "Answer D" };
    [SerializeField]int correctAnswerIndex = 0;
    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswers(int index)
    {
        return answers[index];
    }
}

 
