using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text FinalscoreText;
    
    int myScore = 0;
    
    void Update()
    {
        scoreText.text = myScore.ToString();
        FinalscoreText.text = "Score : " + myScore.ToString();
    }
    public void AddScore(int points){
        myScore += points;
    }
}