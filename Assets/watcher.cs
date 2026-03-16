using UnityEngine;
using System.Collections;

public class Watcher : MonoBehaviour
{
    public float lookAwayTime = 2f;
    public float lookOverTime = 1.5f;

    public bool isLooking = false;

    public Sprite lookingAwaySprite;
    public Sprite lookingOverSprite;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(WatcherRoutine());
    }

    IEnumerator WatcherRoutine()
    {
        while (true)
        {
            // Look away
            isLooking = false;
            sr.sprite = lookingAwaySprite;
            yield return new WaitForSeconds(lookAwayTime);

            // Look over!
            isLooking = true;
            sr.sprite = lookingOverSprite;
            yield return new WaitForSeconds(lookOverTime);
        }
    }
}