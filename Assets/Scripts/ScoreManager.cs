using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    public float multiTime= 2f;
    public float finishTime;



    public Text Points;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime +=1 * multiTime * Time.deltaTime;
        Points.text = currentTime.ToString("0");
        
    }
    public void Endscore()
    {
       Points.gameObject.SetActive(false);
    }

    public void Highscoresafe()
    {
        if (currentTime > PlayerPrefs.GetFloat("HIGHSCORE"))
        {
            PlayerPrefs.SetFloat("highscore", finishTime);
        }
    }
        
    
}
