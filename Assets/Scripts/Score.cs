using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int time = 0;
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
        else
        {
            HStext.text = "No High Scores Yet";
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
        Debug.Log(timer.text);

    }

    

    void IncrimentTime()
    {
        time += 1;
        timer.text = "" + time;
    }
}

