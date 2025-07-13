using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    [SerializeField] UnityEvent OnGameOver;

    protected override void Awake()
    {
        base.Awake();
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        OnGameOver.Invoke();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
