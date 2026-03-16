using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float kissProgress = 0f;
    public float kissGoal = 3f;
    public bool gameOver = false;
    public bool gameWon = false;

    public GameObject gameOverScreen;
    public GameObject winScreen;
    public Slider kissProgressBar; // new!

    void Update()
    {
        if (gameOver || gameWon) return;
    }

    public void AddKissProgress(float amount)
    {
        if (gameOver || gameWon) return;

        kissProgress += amount;
        
        // update the slider visually
        if (kissProgressBar != null)
        {
            kissProgressBar.value = kissProgress;
        }

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