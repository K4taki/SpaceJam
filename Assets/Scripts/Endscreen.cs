using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endscreen : MonoBehaviour
{
    public Text highscore;


    public void Setup(float scorecount)
    {
        highscore.GetComponent<ScoreManager>();
        gameObject.SetActive(true);
        highscore.text = scorecount.ToString() + "HIGHSCORE";
    }
    public void EndScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Update is called once per frame
    public void MainMenu()
    {
        
        SceneManager.LoadScene(0);
    }
}
