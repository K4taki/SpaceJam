using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    private int time = 0;
    private int multitime = 2;
    public Text timer;
    public Text HStext;
    void Start()
    {
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
       
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            HStext.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
       
    }

   

    public void StopTimer()
    {
        CancelInvoke();
        if (PlayerPrefs.GetInt("Highscore") < time)
        {
            SetHighscore();
        }

    }

    public void SetHighscore()
    {
        PlayerPrefs.SetInt("Highscore", time);
      timer.text =PlayerPrefs.GetInt("Highscore").ToString();
        Debug.Log("highscore");

    }

    

    void IncrimentTime()
    {
        time += 1*multitime;
        timer.text = "" + time;
    }
}

