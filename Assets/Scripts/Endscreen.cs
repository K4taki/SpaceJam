using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Endscreen : MonoBehaviour
{
    public Text HStext;

    void Start()
    {
        HStext.text = "H I G H S C O R E :  " +  PlayerPrefs.GetFloat("highscore");
    }

    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
   

}
