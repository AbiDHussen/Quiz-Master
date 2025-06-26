using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;

    public int GetetCorrectAnswers()
    {   
        return correctAnswers;
    }

    public int GetQuestionsSeen()
    {   
        return questionsSeen;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        if (questionsSeen == 0) return 0; // Avoid division by zero
        return (int)((float)correctAnswers / questionsSeen * 100);
    }
}
