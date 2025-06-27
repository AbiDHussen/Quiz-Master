using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    [SerializeField]ScoreKeeper scoreKeeper;// it is initialized in the inspector
    public void ShowFinalScore()
    {
         finalScoreText.text = "Congratulations!\nYou Scored " + scoreKeeper.CalculateScore() + "%\n";   
    }


}

