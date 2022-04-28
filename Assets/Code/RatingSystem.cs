using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RatingSystem : MonoBehaviour
{
    public static RatingSystem instance;
    public int rating = 0;
    public Vector2 neutralRatingRange = new Vector2(-2, 2); // This is the neutral range. Anything below this range is bad, anything above is good.

    public string badScene;
    public string goodScene;
    public string neutralScene;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void MakeChoice(int rating)
    {
        this.rating += rating;
    }

    public void ShowResult()
    {
        if (rating < neutralRatingRange.x)
        {
            // Show the bad scene
            SceneManager.LoadScene(badScene);
        }
        else if (rating < neutralRatingRange.y)
        {
            // Show the neutral scene
            SceneManager.LoadScene(neutralScene);
        }
        else
        {
            // Show the good scene
            SceneManager.LoadScene(goodScene);
        }
    }
}
