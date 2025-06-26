using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f; // Time in seconds to complete the question
    [SerializeField] float timeToShowCorrectAnswer = 10f; // Time in seconds to show the correct answer
    public bool isAnsweringQuestion;
    public float fillFraction;
    public bool loadNextQuestion;

    float timerValue;
    void Update()
    {
        TimerUpdate();
    }

    public void CancelTimer()
    { 
        timerValue = 0f;
    }

    void TimerUpdate()
    { 
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
