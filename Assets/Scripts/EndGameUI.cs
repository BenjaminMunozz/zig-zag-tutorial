using UnityEngine;
using TMPro;

public class EndGameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;

    public void ShowScores(int score)
    {
        scoreText.text = "Score: " + score;
        if (PlayerPrefs.HasKey("highscore"))
        {
            int highScore = PlayerPrefs.GetInt("highScore");
            if(score > highScore)
            {
                highScore= score;
                PlayerPrefs.SetInt("highScore", score);
            }
        }
    }
   
}
