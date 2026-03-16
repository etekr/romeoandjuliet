using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Watcher : MonoBehaviour
{
    public float lookAwayTime = 2f;
    public float lookOverTime = 1.5f;
    public float warningTime = 1f; // how long the warning shows before they look

    public bool isLooking = false;

    public Sprite lookingAwaySprite;
    public Sprite lookingOverSprite;
    private SpriteRenderer sr;

    public GameObject warningImage; // drag your warning image in here

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(WatcherRoutine());
    }

    IEnumerator WatcherRoutine()
    {
        while (true)
        {
            lookAwayTime = Mathf.Max(0.5f, lookAwayTime - 0.1f);
            warningTime = Mathf.Max(0.2f, warningTime - 0.05f);

            // Look away
            isLooking = false;
            sr.sprite = lookingAwaySprite;
            if (warningImage != null) warningImage.SetActive(false);
            yield return new WaitForSeconds(lookAwayTime);

            // Show warning!
            if (warningImage != null) warningImage.SetActive(true);
            yield return new WaitForSeconds(warningTime);

            // Look over!
            isLooking = true;
            sr.sprite = lookingOverSprite;
            if (warningImage != null) warningImage.SetActive(false);
            yield return new WaitForSeconds(lookOverTime);
        }
    }
}