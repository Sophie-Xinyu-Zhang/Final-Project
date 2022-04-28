using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void GoTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void MakeChoice(int rating)
    {
        // This will be directed to the rating system
        // Check the RatingSystem script for more info on when bad, neutral, or good scenes are shown.
        RatingSystem.instance.MakeChoice(rating);
    }

    public void ShowFinalResult()
    {
        RatingSystem.instance.ShowResult();
    }
}