using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    public Sprite[] slides;
    public Image slideImage;

    private int currentSlide = 0;

    void Start()
    {
        if (slides.Length > 0)
        {
            slideImage.sprite = slides[0];
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextSlide();
        }
    }

    void NextSlide()
    {
        currentSlide++;

        if (currentSlide >= slides.Length)
        {
            SceneManager.LoadScene("CutScene");
        }
        else
        {
            slideImage.sprite = slides[currentSlide];
        }
    }
    public void SkipCutscene()
    {
         SceneManager.LoadScene("Scenes/SampleScene");
    }
}