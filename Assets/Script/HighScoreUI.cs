using System;
using TMPro;
using UnityEngine;

public class HighScoreUI : MonoBehaviour
{
    [SerializeField] TMP_Text highScoreText;

    private void OnEnable()
    {
        highScoreText.text = ScoreManager.Instance.HighScore.ToString();
    }
}
