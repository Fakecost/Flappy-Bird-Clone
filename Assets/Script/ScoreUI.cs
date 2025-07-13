using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    public void SetScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
