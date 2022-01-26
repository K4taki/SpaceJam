using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endscreen : MonoBehaviour
{
    public Text HStext;

    public void Awake()
    {
        HStext.text ="HIGHSCORE "+ PlayerPrefs.GetInt("Highscore").ToString();
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
