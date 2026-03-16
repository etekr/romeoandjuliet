using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float kissProgress = 0f;
    public float kissGoal = 3f; // seconds of kissing needed to win
    public bool gameOver = false;
    public bool gameWon = false;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    void Update()
    {
        if (gameOver || gameWon) return; // stop tracking if game has ended
    }

    public void AddKissProgress(float amount)
    {
        if (gameOver || gameWon) return;

        kissProgress += amount;

        if (kissProgress >= kissGoal)
        {
            TriggerWin();
        }
    }

    public void TriggerGameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }

    public void TriggerWin()
    {
        gameWon = true;
        winScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
