using UnityEngine;
using UnityEngine.InputSystem;

public class KissingCouple : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite kissingSprite;

    public Watcher watcher; // drag your watcher object in here

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = normalSprite;
    }

    void Update()
    {
        if (Mouse.current.leftButton.isPressed) // player is holding the button
        {
            sr.sprite = kissingSprite;

            if (watcher.isLooking) // caught!
            {
                Debug.Log("CAUGHT!");
                // we'll replace this with real game over logic in Step 5
            }
        }
        else
        {
            sr.sprite = normalSprite;
        }
    }
}