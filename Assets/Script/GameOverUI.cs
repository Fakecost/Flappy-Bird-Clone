using System;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;
    
    private void OnEnable()
    {
        var scoreManager = ScoreManager.Instance;
        scoreManager.CheckHighScore();
        scoreText.text = ScoreManager.Instance.CurrentScore.ToString();
        highScoreText.text = ScoreManager.Instance.HighScore.ToString();
        
        
    }
}
