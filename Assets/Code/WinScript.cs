using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinScript : MonoBehaviour
{
    public string scene_name;
    private int pointsToWin;
    private int currentPoints;
    public GameObject myNumber;
    

    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = myNumber.transform.childCount;    
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin)
        {   
            //  transform.GetChild(0).gameObject.SetActive(true);
             SceneManager.LoadScene(scene_name);
        }
    }
    public void AddPoints()
    {
        currentPoints++;
    }
}
