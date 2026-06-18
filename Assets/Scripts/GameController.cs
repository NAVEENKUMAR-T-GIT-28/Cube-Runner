using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapToStartPanel;
    public GameObject scoreText;

    private bool gameStarted = false;

    void Start()
    {
        gameOverPanel.SetActive(false);
        scoreText.SetActive(false);

        tapToStartPanel.SetActive(true);

        Time.timeScale = 0f;
    }

    void Update()
    {
        if (!gameStarted && Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        gameStarted = true;

        tapToStartPanel.SetActive(false);
        scoreText.SetActive(true);

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}