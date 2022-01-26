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
    public float Gamescore;
    public Text Points;


    public void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        currentTime += 1 * multiTime* Time.deltaTime  ;
        Points.text = currentTime.ToString("0");
        
    }
    public void Endscore()
    {
        Gamescore = currentTime;
    }

    public void Highscoresafe()
    {
       
        
            PlayerPrefs.SetFloat("", Gamescore);
        
    }
        
    
}
