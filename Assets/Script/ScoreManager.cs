using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : Singleton<ScoreManager>
{
    public UnityEvent<int> onScoreChanged;
    
    public int CurrentScore {get; private set;}
    public int HighScore {get; private set;}

    protected override void Awake()
    {
        base.Awake();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            HighScore = 0;
        }
    }

    public void AddScore()
    {
        CurrentScore += 1;
        onScoreChanged.Invoke(CurrentScore);
    }

    public void CheckHighScore()
    {
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
    }
}
