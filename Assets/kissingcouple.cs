using UnityEngine;

public class KissingCouple : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite kissingSprite;

    public Watcher watcher;
    public GameManager gameManager;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = normalSprite;
    }

    void Update()
    {
        if (gameManager.gameOver || gameManager.gameWon) return;

        if (Input.GetMouseButton(0))
        {
            sr.sprite = kissingSprite;

            if (watcher.isLooking)
            {
                gameManager.TriggerGameOver();
            }
            else
            {
                gameManager.AddKissProgress(Time.deltaTime);
            }
        }
        else
        {
            sr.sprite = normalSprite;
        }
    }
}